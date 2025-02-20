# coding: utf-8

from typing import ClassVar, Dict, List, Tuple  # noqa: F401

from pydantic import Field, StrictStr
from typing import Any, Optional
from typing_extensions import Annotated


class BaseFakeApi:
    subclasses: ClassVar[Tuple] = ()

    def __init_subclass__(cls, **kwargs):
        super().__init_subclass__(**kwargs)
        BaseFakeApi.subclasses = BaseFakeApi.subclasses + (cls,)
    async def fake_query_param_default(
        self,
        has_default: Annotated[Optional[StrictStr], Field(description="has default value")],
        no_default: Annotated[Optional[StrictStr], Field(description="no default value")],
    ) -> None:
        """"""
        ...
