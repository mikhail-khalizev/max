using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c7b0a8b1-e119-471c-b107-26c7ea13aa8c")]
        public void Method_100d_1447()
        {
            ii(0x100d_1447, 5); pushd(0x98);                            /* push 0x98 */
            ii(0x100d_144c, 5); calld(Definitions.sys_check_available_stack_size, 0x9_4901); /* call 0x10165d52 */
            ii(0x100d_1451, 1); pushd(ebx);                             /* push ebx */
            ii(0x100d_1452, 1); pushd(ecx);                             /* push ecx */
            ii(0x100d_1453, 1); pushd(edx);                             /* push edx */
            ii(0x100d_1454, 1); pushd(esi);                             /* push esi */
            ii(0x100d_1455, 1); pushd(edi);                             /* push edi */
            ii(0x100d_1456, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_1457, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_1459, 6); sub(esp, 0x6c);                         /* sub esp, 0x6c */
            ii(0x100d_145f, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100d_1462, 5); mov(edx, 0x11c);                        /* mov edx, 0x11c */
            ii(0x100d_1467, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_146a, 3); mov(eax, memd_a32[ds, eax + 0x42]);     /* mov eax, [eax+0x42] */
            ii(0x100d_146d, 5); calld(0x100c_f2ba, -0x21b8);            /* call 0x100cf2ba */
            ii(0x100d_1472, 5); mov(edx, 0x11f);                        /* mov edx, 0x11f */
            ii(0x100d_1477, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_147a, 3); mov(eax, memd_a32[ds, eax + 0x46]);     /* mov eax, [eax+0x46] */
            ii(0x100d_147d, 5); calld(0x100c_f2ba, -0x21c8);            /* call 0x100cf2ba */
            ii(0x100d_1482, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100d_1485, 5); calld(0x100d_5224, 0x3d9a);             /* call 0x100d5224 */
            ii(0x100d_148a, 1); pushd(eax);                             /* push eax */
            ii(0x100d_148b, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100d_148e, 5); calld(0x100d_5250, 0x3dbd);             /* call 0x100d5250 */
            ii(0x100d_1493, 1); pushd(eax);                             /* push eax */
            ii(0x100d_1494, 3); lea(eax, ebp - 0x40);                   /* lea eax, [ebp-0x40] */
            ii(0x100d_1497, 5); calld(0x100d_527c, 0x3de0);             /* call 0x100d527c */
            ii(0x100d_149c, 1); pushd(eax);                             /* push eax */
            ii(0x100d_149d, 3); lea(eax, ebp - 0x44);                   /* lea eax, [ebp-0x44] */
            ii(0x100d_14a0, 5); calld(0x100d_52a8, 0x3e03);             /* call 0x100d52a8 */
            ii(0x100d_14a5, 1); pushd(eax);                             /* push eax */
            ii(0x100d_14a6, 5); calld(0x100d_52d4, 0x3e29);             /* call 0x100d52d4 */
            ii(0x100d_14ab, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100d_14ae, 5); calld(0x100d_52f8, 0x3e45);             /* call 0x100d52f8 */
            ii(0x100d_14b3, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100d_14b6, 5); mov(edx, StringDefinitions.Done7);      /* mov edx, 0x101a1476 */
            ii(0x100d_14bb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_14be, 3); mov(eax, memd_a32[ds, eax + 0x4e]);     /* mov eax, [eax+0x4e] */
            ii(0x100d_14c1, 5); calld(0x100c_ef64, -0x2562);            /* call 0x100cef64 */
            ii(0x100d_14c6, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100d_14c9, 5); calld(0x100d_5224, 0x3d56);             /* call 0x100d5224 */
            ii(0x100d_14ce, 1); pushd(eax);                             /* push eax */
            ii(0x100d_14cf, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x100d_14d2, 5); calld(0x100d_5250, 0x3d79);             /* call 0x100d5250 */
            ii(0x100d_14d7, 1); pushd(eax);                             /* push eax */
            ii(0x100d_14d8, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100d_14db, 5); calld(0x100d_527c, 0x3d9c);             /* call 0x100d527c */
            ii(0x100d_14e0, 1); pushd(eax);                             /* push eax */
            ii(0x100d_14e1, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x100d_14e4, 5); calld(0x100d_52a8, 0x3dbf);             /* call 0x100d52a8 */
            ii(0x100d_14e9, 1); pushd(eax);                             /* push eax */
            ii(0x100d_14ea, 5); calld(0x100d_52d4, 0x3de5);             /* call 0x100d52d4 */
            ii(0x100d_14ef, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100d_14f2, 5); calld(0x100d_52f8, 0x3e01);             /* call 0x100d52f8 */
            ii(0x100d_14f7, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100d_14fa, 5); mov(edx, StringDefinitions.Cancel8);    /* mov edx, 0x101a147b */
            ii(0x100d_14ff, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_1502, 3); mov(eax, memd_a32[ds, eax + 0x56]);     /* mov eax, [eax+0x56] */
            ii(0x100d_1505, 5); calld(0x100c_ef64, -0x25a6);            /* call 0x100cef64 */
            ii(0x100d_150a, 3); lea(eax, ebp - 0x4c);                   /* lea eax, [ebp-0x4c] */
            ii(0x100d_150d, 5); calld(0x100d_5224, 0x3d12);             /* call 0x100d5224 */
            ii(0x100d_1512, 1); pushd(eax);                             /* push eax */
            ii(0x100d_1513, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x100d_1516, 5); calld(0x100d_5250, 0x3d35);             /* call 0x100d5250 */
            ii(0x100d_151b, 1); pushd(eax);                             /* push eax */
            ii(0x100d_151c, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100d_151f, 5); calld(0x100d_527c, 0x3d58);             /* call 0x100d527c */
            ii(0x100d_1524, 1); pushd(eax);                             /* push eax */
            ii(0x100d_1525, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100d_1528, 5); calld(0x100d_52a8, 0x3d7b);             /* call 0x100d52a8 */
            ii(0x100d_152d, 1); pushd(eax);                             /* push eax */
            ii(0x100d_152e, 5); calld(0x100d_52d4, 0x3da1);             /* call 0x100d52d4 */
            ii(0x100d_1533, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100d_1536, 5); calld(0x100d_52f8, 0x3dbd);             /* call 0x100d52f8 */
            ii(0x100d_153b, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100d_153e, 5); mov(edx, StringDefinitions.BuildX1);    /* mov edx, 0x101a1482 */
            ii(0x100d_1543, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_1546, 3); mov(eax, memd_a32[ds, eax + 0x5e]);     /* mov eax, [eax+0x5e] */
            ii(0x100d_1549, 5); calld(0x100c_ef64, -0x25ea);            /* call 0x100cef64 */
            ii(0x100d_154e, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x100d_1551, 5); calld(0x100d_5224, 0x3cce);             /* call 0x100d5224 */
            ii(0x100d_1556, 1); pushd(eax);                             /* push eax */
            ii(0x100d_1557, 3); lea(eax, ebp - 0x54);                   /* lea eax, [ebp-0x54] */
            ii(0x100d_155a, 5); calld(0x100d_5250, 0x3cf1);             /* call 0x100d5250 */
            ii(0x100d_155f, 1); pushd(eax);                             /* push eax */
            ii(0x100d_1560, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100d_1563, 5); calld(0x100d_527c, 0x3d14);             /* call 0x100d527c */
            ii(0x100d_1568, 1); pushd(eax);                             /* push eax */
            ii(0x100d_1569, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x100d_156c, 5); calld(0x100d_52a8, 0x3d37);             /* call 0x100d52a8 */
            ii(0x100d_1571, 1); pushd(eax);                             /* push eax */
            ii(0x100d_1572, 5); calld(0x100d_52d4, 0x3d5d);             /* call 0x100d52d4 */
            ii(0x100d_1577, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100d_157a, 5); calld(0x100d_52f8, 0x3d79);             /* call 0x100d52f8 */
            ii(0x100d_157f, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100d_1582, 5); mov(edx, StringDefinitions.BuildX2);    /* mov edx, 0x101a148b */
            ii(0x100d_1587, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_158a, 3); mov(eax, memd_a32[ds, eax + 0x62]);     /* mov eax, [eax+0x62] */
            ii(0x100d_158d, 5); calld(0x100c_ef64, -0x262e);            /* call 0x100cef64 */
            ii(0x100d_1592, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100d_1595, 5); calld(0x100d_5224, 0x3c8a);             /* call 0x100d5224 */
            ii(0x100d_159a, 1); pushd(eax);                             /* push eax */
            ii(0x100d_159b, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x100d_159e, 5); calld(0x100d_5250, 0x3cad);             /* call 0x100d5250 */
            ii(0x100d_15a3, 1); pushd(eax);                             /* push eax */
            ii(0x100d_15a4, 3); lea(eax, ebp - 0x50);                   /* lea eax, [ebp-0x50] */
            ii(0x100d_15a7, 5); calld(0x100d_527c, 0x3cd0);             /* call 0x100d527c */
            ii(0x100d_15ac, 1); pushd(eax);                             /* push eax */
            ii(0x100d_15ad, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100d_15b0, 5); calld(0x100d_52a8, 0x3cf3);             /* call 0x100d52a8 */
            ii(0x100d_15b5, 1); pushd(eax);                             /* push eax */
            ii(0x100d_15b6, 5); calld(0x100d_52d4, 0x3d19);             /* call 0x100d52d4 */
            ii(0x100d_15bb, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100d_15be, 5); calld(0x100d_52f8, 0x3d35);             /* call 0x100d52f8 */
            ii(0x100d_15c3, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100d_15c6, 5); mov(edx, StringDefinitions.BuildX4);    /* mov edx, 0x101a1494 */
            ii(0x100d_15cb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_15ce, 3); mov(eax, memd_a32[ds, eax + 0x66]);     /* mov eax, [eax+0x66] */
            ii(0x100d_15d1, 5); calld(0x100c_ef64, -0x2672);            /* call 0x100cef64 */
            ii(0x100d_15d6, 5); mov(edx, 0x450);                        /* mov edx, 0x450 */
            ii(0x100d_15db, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_15de, 3); mov(eax, memd_a32[ds, eax + 0x4a]);     /* mov eax, [eax+0x4a] */
            ii(0x100d_15e1, 5); calld(0x100d_5164, 0x3b7e);             /* call 0x100d5164 */
            ii(0x100d_15e6, 5); mov(edx, 0x451);                        /* mov edx, 0x451 */
            ii(0x100d_15eb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_15ee, 3); mov(eax, memd_a32[ds, eax + 0x4a]);     /* mov eax, [eax+0x4a] */
            ii(0x100d_15f1, 5); calld(0x100d_5134, 0x3b3e);             /* call 0x100d5134 */
            ii(0x100d_15f6, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100d_15fb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_15fe, 3); mov(eax, memd_a32[ds, eax + 0x4a]);     /* mov eax, [eax+0x4a] */
            ii(0x100d_1601, 5); calld(0x100d_5194, 0x3b8e);             /* call 0x100d5194 */
            ii(0x100d_1606, 5); mov(edx, 0xd);                          /* mov edx, 0xd */
            ii(0x100d_160b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_160e, 3); mov(eax, memd_a32[ds, eax + 0x4e]);     /* mov eax, [eax+0x4e] */
            ii(0x100d_1611, 5); calld(0x100d_5134, 0x3b1e);             /* call 0x100d5134 */
            ii(0x100d_1616, 5); mov(edx, 0x44c);                        /* mov edx, 0x44c */
            ii(0x100d_161b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_161e, 3); mov(eax, memd_a32[ds, eax + 0x52]);     /* mov eax, [eax+0x52] */
            ii(0x100d_1621, 5); calld(0x100d_5134, 0x3b0e);             /* call 0x100d5134 */
            ii(0x100d_1626, 5); mov(edx, 0x1b);                         /* mov edx, 0x1b */
            ii(0x100d_162b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_162e, 3); mov(eax, memd_a32[ds, eax + 0x56]);     /* mov eax, [eax+0x56] */
            ii(0x100d_1631, 5); calld(0x100d_5134, 0x3afe);             /* call 0x100d5134 */
            ii(0x100d_1636, 5); mov(edx, 0x700d);                       /* mov edx, 0x700d */
            ii(0x100d_163b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_163e, 3); mov(eax, memd_a32[ds, eax + 0x4e]);     /* mov eax, [eax+0x4e] */
            ii(0x100d_1641, 5); calld(0x100d_5164, 0x3b1e);             /* call 0x100d5164 */
            ii(0x100d_1646, 5); mov(edx, 0x744c);                       /* mov edx, 0x744c */
            ii(0x100d_164b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_164e, 3); mov(eax, memd_a32[ds, eax + 0x52]);     /* mov eax, [eax+0x52] */
            ii(0x100d_1651, 5); calld(0x100d_5164, 0x3b0e);             /* call 0x100d5164 */
            ii(0x100d_1656, 5); mov(edx, 0x701b);                       /* mov edx, 0x701b */
            ii(0x100d_165b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_165e, 3); mov(eax, memd_a32[ds, eax + 0x56]);     /* mov eax, [eax+0x56] */
            ii(0x100d_1661, 5); calld(0x100d_5164, 0x3afe);             /* call 0x100d5164 */
            ii(0x100d_1666, 5); mov(edx, 0x44d);                        /* mov edx, 0x44d */
            ii(0x100d_166b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_166e, 3); mov(eax, memd_a32[ds, eax + 0x5e]);     /* mov eax, [eax+0x5e] */
            ii(0x100d_1671, 5); calld(0x100d_5164, 0x3aee);             /* call 0x100d5164 */
            ii(0x100d_1676, 5); mov(edx, 0x44e);                        /* mov edx, 0x44e */
            ii(0x100d_167b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_167e, 3); mov(eax, memd_a32[ds, eax + 0x62]);     /* mov eax, [eax+0x62] */
            ii(0x100d_1681, 5); calld(0x100d_5164, 0x3ade);             /* call 0x100d5164 */
            ii(0x100d_1686, 5); mov(edx, 0x44f);                        /* mov edx, 0x44f */
            ii(0x100d_168b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_168e, 3); mov(eax, memd_a32[ds, eax + 0x66]);     /* mov eax, [eax+0x66] */
            ii(0x100d_1691, 5); calld(0x100d_5164, 0x3ace);             /* call 0x100d5164 */
            ii(0x100d_1696, 5); mov(edx, 0x5);                          /* mov edx, 0x5 */
            ii(0x100d_169b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_169e, 3); mov(eax, memd_a32[ds, eax + 0x5e]);     /* mov eax, [eax+0x5e] */
            ii(0x100d_16a1, 5); calld(0x100d_5194, 0x3aee);             /* call 0x100d5194 */
            ii(0x100d_16a6, 5); mov(edx, 0x5);                          /* mov edx, 0x5 */
            ii(0x100d_16ab, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_16ae, 3); mov(eax, memd_a32[ds, eax + 0x62]);     /* mov eax, [eax+0x62] */
            ii(0x100d_16b1, 5); calld(0x100d_5194, 0x3ade);             /* call 0x100d5194 */
            ii(0x100d_16b6, 5); mov(edx, 0x5);                          /* mov edx, 0x5 */
            ii(0x100d_16bb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_16be, 3); mov(eax, memd_a32[ds, eax + 0x66]);     /* mov eax, [eax+0x66] */
            ii(0x100d_16c1, 5); calld(0x100d_5194, 0x3ace);             /* call 0x100d5194 */
            ii(0x100d_16c6, 5); mov(edx, 0x4dd);                        /* mov edx, 0x4dd */
            ii(0x100d_16cb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_16ce, 3); mov(eax, memd_a32[ds, eax + 0x5e]);     /* mov eax, [eax+0x5e] */
            ii(0x100d_16d1, 5); calld(0x100d_50d4, 0x39fe);             /* call 0x100d50d4 */
            ii(0x100d_16d6, 5); mov(edx, 0x4dd);                        /* mov edx, 0x4dd */
            ii(0x100d_16db, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_16de, 3); mov(eax, memd_a32[ds, eax + 0x62]);     /* mov eax, [eax+0x62] */
            ii(0x100d_16e1, 5); calld(0x100d_50d4, 0x39ee);             /* call 0x100d50d4 */
            ii(0x100d_16e6, 5); mov(edx, 0x4dd);                        /* mov edx, 0x4dd */
            ii(0x100d_16eb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_16ee, 3); mov(eax, memd_a32[ds, eax + 0x66]);     /* mov eax, [eax+0x66] */
            ii(0x100d_16f1, 5); calld(0x100d_50d4, 0x39de);             /* call 0x100d50d4 */
            ii(0x100d_16f6, 5); mov(edx, 0x4ff);                        /* mov edx, 0x4ff */
            ii(0x100d_16fb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_16fe, 3); mov(eax, memd_a32[ds, eax + 0x4a]);     /* mov eax, [eax+0x4a] */
            ii(0x100d_1701, 5); calld(0x100d_50d4, 0x39ce);             /* call 0x100d50d4 */
            ii(0x100d_1706, 5); mov(edx, 0x4e6);                        /* mov edx, 0x4e6 */
            ii(0x100d_170b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_170e, 3); mov(eax, memd_a32[ds, eax + 0x4e]);     /* mov eax, [eax+0x4e] */
            ii(0x100d_1711, 5); calld(0x100d_50d4, 0x39be);             /* call 0x100d50d4 */
            ii(0x100d_1716, 5); mov(edx, 0x4e5);                        /* mov edx, 0x4e5 */
            ii(0x100d_171b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_171e, 3); mov(eax, memd_a32[ds, eax + 0x52]);     /* mov eax, [eax+0x52] */
            ii(0x100d_1721, 5); calld(0x100d_50d4, 0x39ae);             /* call 0x100d50d4 */
            ii(0x100d_1726, 5); mov(edx, 0x4e4);                        /* mov edx, 0x4e4 */
            ii(0x100d_172b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_172e, 3); mov(eax, memd_a32[ds, eax + 0x56]);     /* mov eax, [eax+0x56] */
            ii(0x100d_1731, 5); calld(0x100d_50d4, 0x399e);             /* call 0x100d50d4 */
            ii(0x100d_1736, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_1739, 4); cmp(memd_a32[ds, eax + 0x5a], 0);       /* cmp dword [eax+0x5a], 0x0 */
            ii(0x100d_173d, 2); if(jzd(0x100d_176f, 0x30)) goto l_0x100d_176f; /* jz 0x100d176f */
            ii(0x100d_173f, 5); mov(edx, 0x452);                        /* mov edx, 0x452 */
            ii(0x100d_1744, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_1747, 3); mov(eax, memd_a32[ds, eax + 0x5a]);     /* mov eax, [eax+0x5a] */
            ii(0x100d_174a, 5); calld(0x100d_5134, 0x39e5);             /* call 0x100d5134 */
            ii(0x100d_174f, 5); mov(edx, 0x7452);                       /* mov edx, 0x7452 */
            ii(0x100d_1754, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_1757, 3); mov(eax, memd_a32[ds, eax + 0x5a]);     /* mov eax, [eax+0x5a] */
            ii(0x100d_175a, 5); calld(0x100d_5164, 0x3a05);             /* call 0x100d5164 */
            ii(0x100d_175f, 5); mov(edx, 0x4e6);                        /* mov edx, 0x4e6 */
            ii(0x100d_1764, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_1767, 3); mov(eax, memd_a32[ds, eax + 0x5a]);     /* mov eax, [eax+0x5a] */
            ii(0x100d_176a, 5); calld(0x100d_50d4, 0x3965);             /* call 0x100d50d4 */
        l_0x100d_176f:
            ii(0x100d_176f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_1772, 3); mov(edx, memd_a32[ds, eax + 0x29]);     /* mov edx, [eax+0x29] */
            ii(0x100d_1775, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_1778, 3); mov(eax, memd_a32[ds, eax + 0x4a]);     /* mov eax, [eax+0x4a] */
            ii(0x100d_177b, 5); calld(0x100c_f85c, -0x1f24);            /* call 0x100cf85c */
            ii(0x100d_1780, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_1783, 3); mov(edx, memd_a32[ds, eax + 0x29]);     /* mov edx, [eax+0x29] */
            ii(0x100d_1786, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_1789, 3); mov(eax, memd_a32[ds, eax + 0x4e]);     /* mov eax, [eax+0x4e] */
            ii(0x100d_178c, 5); calld(0x100c_f85c, -0x1f35);            /* call 0x100cf85c */
            ii(0x100d_1791, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_1794, 3); mov(edx, memd_a32[ds, eax + 0x29]);     /* mov edx, [eax+0x29] */
            ii(0x100d_1797, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_179a, 3); mov(eax, memd_a32[ds, eax + 0x52]);     /* mov eax, [eax+0x52] */
            ii(0x100d_179d, 5); calld(0x100c_f85c, -0x1f46);            /* call 0x100cf85c */
            ii(0x100d_17a2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_17a5, 3); mov(edx, memd_a32[ds, eax + 0x29]);     /* mov edx, [eax+0x29] */
            ii(0x100d_17a8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_17ab, 3); mov(eax, memd_a32[ds, eax + 0x56]);     /* mov eax, [eax+0x56] */
            ii(0x100d_17ae, 5); calld(0x100c_f85c, -0x1f57);            /* call 0x100cf85c */
            ii(0x100d_17b3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_17b6, 3); mov(edx, memd_a32[ds, eax + 0x29]);     /* mov edx, [eax+0x29] */
            ii(0x100d_17b9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_17bc, 3); mov(eax, memd_a32[ds, eax + 0x5e]);     /* mov eax, [eax+0x5e] */
            ii(0x100d_17bf, 5); calld(0x100c_f85c, -0x1f68);            /* call 0x100cf85c */
            ii(0x100d_17c4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_17c7, 3); mov(edx, memd_a32[ds, eax + 0x29]);     /* mov edx, [eax+0x29] */
            ii(0x100d_17ca, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_17cd, 3); mov(eax, memd_a32[ds, eax + 0x62]);     /* mov eax, [eax+0x62] */
            ii(0x100d_17d0, 5); calld(0x100c_f85c, -0x1f79);            /* call 0x100cf85c */
            ii(0x100d_17d5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_17d8, 3); mov(edx, memd_a32[ds, eax + 0x29]);     /* mov edx, [eax+0x29] */
            ii(0x100d_17db, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_17de, 3); mov(eax, memd_a32[ds, eax + 0x66]);     /* mov eax, [eax+0x66] */
            ii(0x100d_17e1, 5); calld(0x100c_f85c, -0x1f8a);            /* call 0x100cf85c */
            ii(0x100d_17e6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_17e9, 4); cmp(memd_a32[ds, eax + 0x5a], 0);       /* cmp dword [eax+0x5a], 0x0 */
            ii(0x100d_17ed, 2); if(jzd(0x100d_1800, 0x11)) goto l_0x100d_1800; /* jz 0x100d1800 */
            ii(0x100d_17ef, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_17f2, 3); mov(edx, memd_a32[ds, eax + 0x29]);     /* mov edx, [eax+0x29] */
            ii(0x100d_17f5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_17f8, 3); mov(eax, memd_a32[ds, eax + 0x5a]);     /* mov eax, [eax+0x5a] */
            ii(0x100d_17fb, 5); calld(0x100c_f85c, -0x1fa4);            /* call 0x100cf85c */
        l_0x100d_1800:
            ii(0x100d_1800, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_1803, 3); mov(eax, memd_a32[ds, eax + 0x5e]);     /* mov eax, [eax+0x5e] */
            ii(0x100d_1806, 5); calld(0x100d_5104, 0x38f9);             /* call 0x100d5104 */
            ii(0x100d_180b, 3); mov(memd_a32[ss, ebp - 0x68], eax);     /* mov [ebp-0x68], eax */
            ii(0x100d_180e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_1811, 3); mov(eax, memd_a32[ds, eax + 0x62]);     /* mov eax, [eax+0x62] */
            ii(0x100d_1814, 5); calld(0x100d_5104, 0x38eb);             /* call 0x100d5104 */
            ii(0x100d_1819, 3); mov(memd_a32[ss, ebp - 0x64], eax);     /* mov [ebp-0x64], eax */
            ii(0x100d_181c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_181f, 3); mov(eax, memd_a32[ds, eax + 0x66]);     /* mov eax, [eax+0x66] */
            ii(0x100d_1822, 5); calld(0x100d_5104, 0x38dd);             /* call 0x100d5104 */
            ii(0x100d_1827, 3); mov(memd_a32[ss, ebp - 0x60], eax);     /* mov [ebp-0x60], eax */
            ii(0x100d_182a, 3); lea(edx, ebp - 0x68);                   /* lea edx, [ebp-0x68] */
            ii(0x100d_182d, 5); mov(eax, 0x3);                          /* mov eax, 0x3 */
            ii(0x100d_1832, 5); calld(/* sys */ 0x1016_9a78, 0x9_8241); /* call 0x10169a78 */
            ii(0x100d_1837, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_183a, 4); mov(ax, memw_a32[ds, eax + 0x38]);      /* mov ax, [eax+0x38] */
            ii(0x100d_183e, 3); mov(memd_a32[ss, ebp - 0x5c], eax);     /* mov [ebp-0x5c], eax */
            ii(0x100d_1841, 2); jmpd(0x100d_187b, 0x38); goto l_0x100d_187b; /* jmp 0x100d187b */
        l_0x100d_1843:
            ii(0x100d_1843, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100d_1848, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_184b, 3); mov(eax, memd_a32[ds, eax + 0x5e]);     /* mov eax, [eax+0x5e] */
            ii(0x100d_184e, 5); calld(0x100c_fb73, -0x1ce0);            /* call 0x100cfb73 */
            ii(0x100d_1853, 2); jmpd(0x100d_18a1, 0x4c); goto l_0x100d_18a1; /* jmp 0x100d18a1 */
        l_0x100d_1855:
            ii(0x100d_1855, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100d_185a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_185d, 3); mov(eax, memd_a32[ds, eax + 0x62]);     /* mov eax, [eax+0x62] */
            ii(0x100d_1860, 5); calld(0x100c_fb73, -0x1cf2);            /* call 0x100cfb73 */
            ii(0x100d_1865, 2); jmpd(0x100d_18a1, 0x3a); goto l_0x100d_18a1; /* jmp 0x100d18a1 */
        l_0x100d_1867:
            ii(0x100d_1867, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100d_186c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_186f, 3); mov(eax, memd_a32[ds, eax + 0x66]);     /* mov eax, [eax+0x66] */
            ii(0x100d_1872, 5); calld(0x100c_fb73, -0x1d04);            /* call 0x100cfb73 */
            ii(0x100d_1877, 2); jmpd(0x100d_18a1, 0x28); goto l_0x100d_18a1; /* jmp 0x100d18a1 */
        l_0x100d_1879:
            ii(0x100d_1879, 2); jmpd(0x100d_18a1, 0x26); goto l_0x100d_18a1; /* jmp 0x100d18a1 */
        l_0x100d_187b:
            ii(0x100d_187b, 3); mov(eax, memd_a32[ss, ebp - 0x5c]);     /* mov eax, [ebp-0x5c] */
            ii(0x100d_187e, 3); mov(memd_a32[ss, ebp - 0x6c], eax);     /* mov [ebp-0x6c], eax */
            ii(0x100d_1881, 5); cmp(memw_a32[ss, ebp - 0x6c], 0x2);     /* cmp word [ebp-0x6c], 0x2 */
            ii(0x100d_1886, 2); if(jbd(0x100d_1898, 0x10)) goto l_0x100d_1898; /* jb 0x100d1898 */
            ii(0x100d_1888, 5); cmp(memw_a32[ss, ebp - 0x6c], 0x2);     /* cmp word [ebp-0x6c], 0x2 */
            ii(0x100d_188d, 2); if(jbed(0x100d_1855, -0x3a)) goto l_0x100d_1855; /* jbe 0x100d1855 */
            ii(0x100d_188f, 5); cmp(memw_a32[ss, ebp - 0x6c], 0x4);     /* cmp word [ebp-0x6c], 0x4 */
            ii(0x100d_1894, 2); if(jzd(0x100d_1867, -0x2f)) goto l_0x100d_1867; /* jz 0x100d1867 */
            ii(0x100d_1896, 2); jmpd(0x100d_1879, -0x1f); goto l_0x100d_1879; /* jmp 0x100d1879 */
        l_0x100d_1898:
            ii(0x100d_1898, 5); cmp(memw_a32[ss, ebp - 0x6c], 0x1);     /* cmp word [ebp-0x6c], 0x1 */
            ii(0x100d_189d, 2); if(jzd(0x100d_1843, -0x5c)) goto l_0x100d_1843; /* jz 0x100d1843 */
            ii(0x100d_189f, 2); jmpd(0x100d_1879, -0x28); goto l_0x100d_1879; /* jmp 0x100d1879 */
        l_0x100d_18a1:
            ii(0x100d_18a1, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_18a3, 6); mov(dl, memb_a32[ds, 0x101b_7ed0]);     /* mov dl, [0x101b7ed0] */
            ii(0x100d_18a9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_18ac, 3); mov(eax, memd_a32[ds, eax + 0x4a]);     /* mov eax, [eax+0x4a] */
            ii(0x100d_18af, 5); calld(0x100c_fb73, -0x1d41);            /* call 0x100cfb73 */
            ii(0x100d_18b4, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100d_18b7, 3); add(edx, 0x17);                         /* add edx, 0x17 */
            ii(0x100d_18ba, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_18bd, 3); mov(eax, memd_a32[ds, eax + 0x6a]);     /* mov eax, [eax+0x6a] */
            ii(0x100d_18c0, 5); calld(0x100d_7d74, 0x64af);             /* call 0x100d7d74 */
            ii(0x100d_18c5, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100d_18c8, 3); add(edx, 0x17);                         /* add edx, 0x17 */
            ii(0x100d_18cb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_18ce, 3); mov(eax, memd_a32[ds, eax + 0x6e]);     /* mov eax, [eax+0x6e] */
            ii(0x100d_18d1, 5); calld(0x100d_7d74, 0x649e);             /* call 0x100d7d74 */
            ii(0x100d_18d6, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100d_18d9, 3); add(edx, 0x17);                         /* add edx, 0x17 */
            ii(0x100d_18dc, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_18df, 3); mov(eax, memd_a32[ds, eax + 0x72]);     /* mov eax, [eax+0x72] */
            ii(0x100d_18e2, 5); calld(0x100d_7d74, 0x648d);             /* call 0x100d7d74 */
            ii(0x100d_18e7, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100d_18ea, 3); add(edx, 0x17);                         /* add edx, 0x17 */
            ii(0x100d_18ed, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_18f0, 3); mov(eax, memd_a32[ds, eax + 0x76]);     /* mov eax, [eax+0x76] */
            ii(0x100d_18f3, 5); calld(0x100d_7d74, 0x647c);             /* call 0x100d7d74 */
            ii(0x100d_18f8, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100d_18fb, 3); add(edx, 0x17);                         /* add edx, 0x17 */
            ii(0x100d_18fe, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_1901, 3); mov(eax, memd_a32[ds, eax + 0x7a]);     /* mov eax, [eax+0x7a] */
            ii(0x100d_1904, 5); calld(0x100d_7d74, 0x646b);             /* call 0x100d7d74 */
            ii(0x100d_1909, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100d_190c, 3); add(edx, 0x17);                         /* add edx, 0x17 */
            ii(0x100d_190f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_1912, 3); mov(eax, memd_a32[ds, eax + 0x7e]);     /* mov eax, [eax+0x7e] */
            ii(0x100d_1915, 5); calld(0x100d_7d74, 0x645a);             /* call 0x100d7d74 */
            ii(0x100d_191a, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100d_191d, 3); add(edx, 0x17);                         /* add edx, 0x17 */
            ii(0x100d_1920, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_1923, 6); mov(eax, memd_a32[ds, eax + 0x82]);     /* mov eax, [eax+0x82] */
            ii(0x100d_1929, 5); calld(0x100d_7d74, 0x6446);             /* call 0x100d7d74 */
            ii(0x100d_192e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_1931, 3); mov(eax, memd_a32[ds, eax + 0x3e]);     /* mov eax, [eax+0x3e] */
            ii(0x100d_1934, 3); mov(memd_a32[ss, ebp - 0x58], eax);     /* mov [ebp-0x58], eax */
            ii(0x100d_1937, 3); mov(edx, memd_a32[ss, ebp - 0x58]);     /* mov edx, [ebp-0x58] */
            ii(0x100d_193a, 3); mov(edx, memd_a32[ds, edx + 0x40]);     /* mov edx, [edx+0x40] */
            ii(0x100d_193d, 3); mov(eax, memd_a32[ss, ebp - 0x58]);     /* mov eax, [ebp-0x58] */
            ii(0x100d_1940, 3); calld_abs(memd_a32[ds, edx + 0x10]);    /* call dword [edx+0x10] */
            ii(0x100d_1943, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_1946, 3); mov(eax, memd_a32[ds, eax + 0x3e]);     /* mov eax, [eax+0x3e] */
            ii(0x100d_1949, 5); calld(0x100d_0149, -0x1805);            /* call 0x100d0149 */
            ii(0x100d_194e, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100d_1951, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_1954, 5); calld(0x100d_19a4, 0x4b);               /* call 0x100d19a4 */
            ii(0x100d_1959, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_195b, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_195c, 1); popd(edi);                              /* pop edi */
            ii(0x100d_195d, 1); popd(esi);                              /* pop esi */
            ii(0x100d_195e, 1); popd(edx);                              /* pop edx */
            ii(0x100d_195f, 1); popd(ecx);                              /* pop ecx */
            ii(0x100d_1960, 1); popd(ebx);                              /* pop ebx */
            ii(0x100d_1961, 1); retd(); return;                         /* ret */
        }
    }
}
