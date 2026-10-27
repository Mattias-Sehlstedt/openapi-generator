package org.openapitools.codegen.utils;

import org.openapitools.codegen.model.EnumVarMap;
import org.testng.annotations.Test;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.HashMap;
import java.util.Map;

import static org.testng.Assert.assertFalse;
import static org.testng.Assert.assertTrue;

public class EnumUtilsTest {

    @Test
    public void isNarrowedEnum_childIsStrictSubsetOfParent_returnsTrue() {
        assertTrue(EnumUtils.isNarrowedEnum(enumValues("A", "B", "C"), enumValues("A", "B")));
    }

    @Test
    public void isNarrowedEnum_childEqualsParent_returnsTrue() {
        assertTrue(EnumUtils.isNarrowedEnum(enumValues("A", "B"), enumValues("B", "A")));
    }

    @Test
    public void isNarrowedEnum_childHasValueNotInParent_returnsFalse() {
        assertFalse(EnumUtils.isNarrowedEnum(enumValues("A", "B"), enumValues("A", "D")));
    }

    @Test
    public void isNarrowedEnum_childBroadensParent_returnsFalse() {
        assertFalse(EnumUtils.isNarrowedEnum(enumValues("A"), enumValues("A", "B")));
    }

    @Test
    public void isNarrowedEnum_nullAllowableValues_returnsFalse() {
        assertFalse(EnumUtils.isNarrowedEnum(null, null));
        assertFalse(EnumUtils.isNarrowedEnum(null, enumValues("A")));
        assertFalse(EnumUtils.isNarrowedEnum(enumValues("A"), null));
    }

    @Test
    public void isNarrowedEnum_parentHasNoEnumValues_returnsFalse() {
        assertFalse(EnumUtils.isNarrowedEnum(new HashMap<>(), enumValues("A")));
    }

    @Test
    public void isNarrowedEnum_childHasNoEnumValues_returnsFalse() {
        assertFalse(EnumUtils.isNarrowedEnum(enumValues("A"), new HashMap<>()));
    }

    @Test
    public void isNarrowedEnum_integerValues_subset_returnsTrue() {
        assertTrue(EnumUtils.isNarrowedEnum(enumValues(1, 2, 3), enumValues(2, 3)));
    }

    @Test
    public void isNarrowedEnum_integerValues_notSubset_returnsFalse() {
        assertFalse(EnumUtils.isNarrowedEnum(enumValues(1, 2, 3), enumValues(3, 4)));
    }

    @Test
    public void isNarrowedEnum_differentValueTypes_returnsFalse() {
        assertFalse(EnumUtils.isNarrowedEnum(enumValues(1, 2), enumValues("1")));
    }

    private static Map<String, Object> enumValues(Object... values) {
        Map<String, Object> allowableValues = new HashMap<>();
        allowableValues.put(EnumVarMap.ENUM_VALUES, new ArrayList<>(Arrays.asList(values)));
        return allowableValues;
    }
}

