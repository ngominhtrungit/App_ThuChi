select ngaytaocp,tenCa,tenCDT,sotienlay
from DoanhThuTheoCa ca, CTChuDauTu_ChiPhiTheoCa ctcdt, ChuDauTu cdt, ChiPhiTheoCa cp
where cdt.tenCDT like N'%n%' and ca.caID = cp.caID and cp.chiphitcID = ctcdt.chiphitcID and cdt.cdtID = ctcdt.cdtID
order by tenCa desc