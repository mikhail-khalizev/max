using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_14b4-6ea9ad88")]
        public void Method_100f_14b4()
        {
            ii(0x100f_14b4, 5);  push(0x80);                           /* push 0x80 */
            ii(0x100f_14b9, 5);  call(Definitions.sys_check_available_stack_size, 0x7_4894);/* call 0x10165d52 */
            ii(0x100f_14be, 1);  push(ebx);                            /* push ebx */
            ii(0x100f_14bf, 1);  push(ecx);                            /* push ecx */
            ii(0x100f_14c0, 1);  push(esi);                            /* push esi */
            ii(0x100f_14c1, 1);  push(edi);                            /* push edi */
            ii(0x100f_14c2, 1);  push(ebp);                            /* push ebp */
            ii(0x100f_14c3, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100f_14c5, 6);  sub(esp, 0x58);                       /* sub esp, 0x58 */
            ii(0x100f_14cb, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100f_14ce, 3);  mov(memb[ss, ebp - 4], dl);           /* mov [ebp-0x4], dl */
            ii(0x100f_14d1, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x100f_14d3, 5);  call(0x100f_0b1b, -0x9bd);            /* call 0x100f0b1b */
            ii(0x100f_14d8, 5);  call(0x100f_0fc5, -0x518);            /* call 0x100f0fc5 */
            ii(0x100f_14dd, 5);  mov(eax, 0xd);                        /* mov eax, 0xd */
            ii(0x100f_14e2, 5);  call(Definitions.sys_new, 0x7_4919);  /* call 0x10165e00 */
            ii(0x100f_14e7, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100f_14ea, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100f_14ed, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100f_14f0, 4);  cmp(memd[ss, ebp - 16], 0);           /* cmp dword [ebp-0x10], 0x0 */
            ii(0x100f_14f4, 2);  if(jz(0x100f_1537, 0x41)) goto l_0x100f_1537;/* jz 0x100f1537 */
            ii(0x100f_14f6, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_14f9, 2);  mov(ebx, memd[ds, eax]);              /* mov ebx, [eax] */
            ii(0x100f_14fb, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_14fe, 2);  mov(edx, memd[ds, eax]);              /* mov edx, [eax] */
            ii(0x100f_1500, 4);  mov(ax, memw[ds, ebx + 12]);          /* mov ax, [ebx+0xc] */
            ii(0x100f_1504, 4);  sub(ax, memw[ds, edx + 4]);           /* sub ax, [edx+0x4] */
            ii(0x100f_1508, 1);  inc(eax);                             /* inc eax */
            ii(0x100f_1509, 1);  cwde();                               /* cwde */
            ii(0x100f_150a, 1);  push(eax);                            /* push eax */
            ii(0x100f_150b, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_150e, 2);  mov(ebx, memd[ds, eax]);              /* mov ebx, [eax] */
            ii(0x100f_1510, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_1513, 2);  mov(edx, memd[ds, eax]);              /* mov edx, [eax] */
            ii(0x100f_1515, 4);  mov(ax, memw[ds, ebx + 8]);           /* mov ax, [ebx+0x8] */
            ii(0x100f_1519, 3);  sub(ax, memw[ds, edx]);               /* sub ax, [edx] */
            ii(0x100f_151c, 1);  inc(eax);                             /* inc eax */
            ii(0x100f_151d, 3);  movsx(ecx, ax);                       /* movsx ecx, ax */
            ii(0x100f_1520, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x100f_1522, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100f_1524, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100f_1527, 5);  call(0x100d_7bdc, -0x1_9950);         /* call 0x100d7bdc */
            ii(0x100f_152c, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x100f_152f, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x100f_1532, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x100f_1535, 2);  jmp(0x100f_153d, 6); goto l_0x100f_153d;/* jmp 0x100f153d */
        l_0x100f_1537:
            ii(0x100f_1537, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100f_153a, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
        l_0x100f_153d:
            ii(0x100f_153d, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x100f_1540, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x100f_1543, 3);  mov(memd[ds, edx + 8], eax);          /* mov [edx+0x8], eax */
            ii(0x100f_1546, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_1549, 2);  mov(edx, memd[ds, eax]);              /* mov edx, [eax] */
            ii(0x100f_154b, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_154e, 3);  mov(eax, memd[ds, eax + 8]);          /* mov eax, [eax+0x8] */
            ii(0x100f_1551, 5);  call(0x100d_7d74, -0x1_97e2);         /* call 0x100d7d74 */
            ii(0x100f_1556, 5);  mov(eax, 0xd);                        /* mov eax, 0xd */
            ii(0x100f_155b, 5);  call(Definitions.sys_new, 0x7_48a0);  /* call 0x10165e00 */
            ii(0x100f_1560, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100f_1563, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x100f_1566, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x100f_1569, 4);  cmp(memd[ss, ebp - 32], 0);           /* cmp dword [ebp-0x20], 0x0 */
            ii(0x100f_156d, 2);  if(jz(0x100f_15b4, 0x45)) goto l_0x100f_15b4;/* jz 0x100f15b4 */
            ii(0x100f_156f, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_1572, 3);  mov(ebx, memd[ds, eax + 4]);          /* mov ebx, [eax+0x4] */
            ii(0x100f_1575, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_1578, 3);  mov(edx, memd[ds, eax + 4]);          /* mov edx, [eax+0x4] */
            ii(0x100f_157b, 4);  mov(ax, memw[ds, ebx + 12]);          /* mov ax, [ebx+0xc] */
            ii(0x100f_157f, 4);  sub(ax, memw[ds, edx + 4]);           /* sub ax, [edx+0x4] */
            ii(0x100f_1583, 1);  inc(eax);                             /* inc eax */
            ii(0x100f_1584, 1);  cwde();                               /* cwde */
            ii(0x100f_1585, 1);  push(eax);                            /* push eax */
            ii(0x100f_1586, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_1589, 3);  mov(ebx, memd[ds, eax + 4]);          /* mov ebx, [eax+0x4] */
            ii(0x100f_158c, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_158f, 3);  mov(edx, memd[ds, eax + 4]);          /* mov edx, [eax+0x4] */
            ii(0x100f_1592, 4);  mov(ax, memw[ds, ebx + 8]);           /* mov ax, [ebx+0x8] */
            ii(0x100f_1596, 3);  sub(ax, memw[ds, edx]);               /* sub ax, [edx] */
            ii(0x100f_1599, 1);  inc(eax);                             /* inc eax */
            ii(0x100f_159a, 3);  movsx(ecx, ax);                       /* movsx ecx, ax */
            ii(0x100f_159d, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x100f_159f, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100f_15a1, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x100f_15a4, 5);  call(0x100d_7bdc, -0x1_99cd);         /* call 0x100d7bdc */
            ii(0x100f_15a9, 3);  mov(memd[ss, ebp - 36], eax);         /* mov [ebp-0x24], eax */
            ii(0x100f_15ac, 3);  mov(eax, memd[ss, ebp - 36]);         /* mov eax, [ebp-0x24] */
            ii(0x100f_15af, 3);  mov(memd[ss, ebp - 40], eax);         /* mov [ebp-0x28], eax */
            ii(0x100f_15b2, 2);  jmp(0x100f_15ba, 6); goto l_0x100f_15ba;/* jmp 0x100f15ba */
        l_0x100f_15b4:
            ii(0x100f_15b4, 3);  mov(eax, memd[ss, ebp - 32]);         /* mov eax, [ebp-0x20] */
            ii(0x100f_15b7, 3);  mov(memd[ss, ebp - 40], eax);         /* mov [ebp-0x28], eax */
        l_0x100f_15ba:
            ii(0x100f_15ba, 3);  mov(eax, memd[ss, ebp - 40]);         /* mov eax, [ebp-0x28] */
            ii(0x100f_15bd, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x100f_15c0, 3);  mov(memd[ds, edx + 12], eax);         /* mov [edx+0xc], eax */
            ii(0x100f_15c3, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_15c6, 3);  mov(edx, memd[ds, eax + 4]);          /* mov edx, [eax+0x4] */
            ii(0x100f_15c9, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_15cc, 3);  mov(eax, memd[ds, eax + 12]);         /* mov eax, [eax+0xc] */
            ii(0x100f_15cf, 5);  call(0x100d_7d74, -0x1_9860);         /* call 0x100d7d74 */
            ii(0x100f_15d4, 5);  call(0x1010_2b60, 0x1_1587);          /* call 0x10102b60 */
            ii(0x100f_15d9, 1);  push(eax);                            /* push eax */
            ii(0x100f_15da, 5);  mov(ecx, 1);                          /* mov ecx, 0x1 */
            ii(0x100f_15df, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_15e2, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x100f_15e4, 3);  mov(ebx, memd[ds, eax + 4]);          /* mov ebx, [eax+0x4] */
            ii(0x100f_15e7, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_15ea, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x100f_15ec, 2);  mov(edx, memd[ds, eax]);              /* mov edx, [eax] */
            ii(0x100f_15ee, 5);  mov(eax, 0x307);                      /* mov eax, 0x307 */
            ii(0x100f_15f3, 5);  call(0x100e_8ef1, -0x8707);           /* call 0x100e8ef1 */
            ii(0x100f_15f8, 5);  call(0x1010_2b60, 0x1_1563);          /* call 0x10102b60 */
            ii(0x100f_15fd, 1);  push(eax);                            /* push eax */
            ii(0x100f_15fe, 5);  mov(ecx, 1);                          /* mov ecx, 0x1 */
            ii(0x100f_1603, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_1606, 3);  mov(eax, memd[ds, eax + 4]);          /* mov eax, [eax+0x4] */
            ii(0x100f_1609, 3);  mov(ebx, memd[ds, eax + 4]);          /* mov ebx, [eax+0x4] */
            ii(0x100f_160c, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_160f, 3);  mov(eax, memd[ds, eax + 4]);          /* mov eax, [eax+0x4] */
            ii(0x100f_1612, 2);  mov(edx, memd[ds, eax]);              /* mov edx, [eax] */
            ii(0x100f_1614, 5);  mov(eax, 0x308);                      /* mov eax, 0x308 */
            ii(0x100f_1619, 5);  call(0x100e_8ef1, -0x872d);           /* call 0x100e8ef1 */
            ii(0x100f_161e, 4);  cmp(memb[ss, ebp - 4], 0);            /* cmp byte [ebp-0x4], 0x0 */
            ii(0x100f_1622, 6);  if(jz(0x100f_17d8, 0x1b0)) goto l_0x100f_17d8;/* jz 0x100f17d8 */
            ii(0x100f_1628, 5);  mov(eax, 0x38);                       /* mov eax, 0x38 */
            ii(0x100f_162d, 5);  call(Definitions.sys_new, 0x7_47ce);  /* call 0x10165e00 */
            ii(0x100f_1632, 3);  mov(memd[ss, ebp - 44], eax);         /* mov [ebp-0x2c], eax */
            ii(0x100f_1635, 3);  mov(eax, memd[ss, ebp - 44]);         /* mov eax, [ebp-0x2c] */
            ii(0x100f_1638, 3);  mov(memd[ss, ebp - 48], eax);         /* mov [ebp-0x30], eax */
            ii(0x100f_163b, 4);  cmp(memd[ss, ebp - 48], 0);           /* cmp dword [ebp-0x30], 0x0 */
            ii(0x100f_163f, 2);  if(jz(0x100f_1669, 0x28)) goto l_0x100f_1669;/* jz 0x100f1669 */
            ii(0x100f_1641, 5);  mov(eax, 0xfc);                       /* mov eax, 0xfc */
            ii(0x100f_1646, 1);  push(eax);                            /* push eax */
            ii(0x100f_1647, 5);  mov(ecx, 0x67);                       /* mov ecx, 0x67 */
            ii(0x100f_164c, 5);  mov(ebx, 0x169);                      /* mov ebx, 0x169 */
            ii(0x100f_1651, 5);  mov(edx, 0x168);                      /* mov edx, 0x168 */
            ii(0x100f_1656, 3);  mov(eax, memd[ss, ebp - 44]);         /* mov eax, [ebp-0x2c] */
            ii(0x100f_1659, 5);  call(Definitions.my_ctor_c17, -0x2_324f);/* call 0x100ce40f */
            ii(0x100f_165e, 3);  mov(memd[ss, ebp - 52], eax);         /* mov [ebp-0x34], eax */
            ii(0x100f_1661, 3);  mov(eax, memd[ss, ebp - 52]);         /* mov eax, [ebp-0x34] */
            ii(0x100f_1664, 3);  mov(memd[ss, ebp - 56], eax);         /* mov [ebp-0x38], eax */
            ii(0x100f_1667, 2);  jmp(0x100f_166f, 6); goto l_0x100f_166f;/* jmp 0x100f166f */
        l_0x100f_1669:
            ii(0x100f_1669, 3);  mov(eax, memd[ss, ebp - 48]);         /* mov eax, [ebp-0x30] */
            ii(0x100f_166c, 3);  mov(memd[ss, ebp - 56], eax);         /* mov [ebp-0x38], eax */
        l_0x100f_166f:
            ii(0x100f_166f, 3);  mov(eax, memd[ss, ebp - 56]);         /* mov eax, [ebp-0x38] */
            ii(0x100f_1672, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x100f_1675, 3);  mov(memd[ds, edx + 16], eax);         /* mov [edx+0x10], eax */
            ii(0x100f_1678, 5);  mov(edx, 0x3f);                       /* mov edx, 0x3f */
            ii(0x100f_167d, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_1680, 3);  mov(eax, memd[ds, eax + 16]);         /* mov eax, [eax+0x10] */
            ii(0x100f_1683, 5);  call(0x100d_5134, -0x1_c554);         /* call 0x100d5134 */
            ii(0x100f_1688, 5);  mov(edx, 0x703f);                     /* mov edx, 0x703f */
            ii(0x100f_168d, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_1690, 3);  mov(eax, memd[ds, eax + 16]);         /* mov eax, [eax+0x10] */
            ii(0x100f_1693, 5);  call(0x100d_5164, -0x1_c534);         /* call 0x100d5164 */
            ii(0x100f_1698, 5);  mov(edx, 0x4e5);                      /* mov edx, 0x4e5 */
            ii(0x100f_169d, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_16a0, 3);  mov(eax, memd[ds, eax + 16]);         /* mov eax, [eax+0x10] */
            ii(0x100f_16a3, 5);  call(0x100d_50d4, -0x1_c5d4);         /* call 0x100d50d4 */
            ii(0x100f_16a8, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_16ab, 3);  mov(eax, memd[ds, eax + 4]);          /* mov eax, [eax+0x4] */
            ii(0x100f_16ae, 3);  mov(edx, memd[ds, eax + 18]);         /* mov edx, [eax+0x12] */
            ii(0x100f_16b1, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_16b4, 3);  mov(eax, memd[ds, eax + 16]);         /* mov eax, [eax+0x10] */
            ii(0x100f_16b7, 5);  call(0x100c_f85c, -0x2_1e60);         /* call 0x100cf85c */
            ii(0x100f_16bc, 5);  call(0x100d_51e4, -0x1_c4dd);         /* call 0x100d51e4 */
            ii(0x100f_16c1, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x100f_16c3, 2);  mov(bl, al);                          /* mov bl, al */
            ii(0x100f_16c5, 5);  call(0x100d_5204, -0x1_c4c6);         /* call 0x100d5204 */
            ii(0x100f_16ca, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100f_16cc, 2);  mov(dl, al);                          /* mov dl, al */
            ii(0x100f_16ce, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_16d1, 3);  mov(eax, memd[ds, eax + 16]);         /* mov eax, [eax+0x10] */
            ii(0x100f_16d4, 5);  call(0x100c_fa7c, -0x2_1c5d);         /* call 0x100cfa7c */
            ii(0x100f_16d9, 5);  mov(eax, 5);                          /* mov eax, 0x5 */
            ii(0x100f_16de, 5);  call(/* sys */ 0x1016_a24c, 0x7_8b69);/* call 0x1016a24c */
            ii(0x100f_16e3, 5);  mov(eax, 0x38);                       /* mov eax, 0x38 */
            ii(0x100f_16e8, 5);  call(Definitions.sys_new, 0x7_4713);  /* call 0x10165e00 */
            ii(0x100f_16ed, 3);  mov(memd[ss, ebp - 60], eax);         /* mov [ebp-0x3c], eax */
            ii(0x100f_16f0, 3);  mov(eax, memd[ss, ebp - 60]);         /* mov eax, [ebp-0x3c] */
            ii(0x100f_16f3, 3);  mov(memd[ss, ebp - 64], eax);         /* mov [ebp-0x40], eax */
            ii(0x100f_16f6, 4);  cmp(memd[ss, ebp - 64], 0);           /* cmp dword [ebp-0x40], 0x0 */
            ii(0x100f_16fa, 2);  if(jz(0x100f_1724, 0x28)) goto l_0x100f_1724;/* jz 0x100f1724 */
            ii(0x100f_16fc, 5);  mov(eax, 0xfc);                       /* mov eax, 0xfc */
            ii(0x100f_1701, 1);  push(eax);                            /* push eax */
            ii(0x100f_1702, 5);  mov(ecx, 0x28);                       /* mov ecx, 0x28 */
            ii(0x100f_1707, 5);  mov(ebx, 0x16b);                      /* mov ebx, 0x16b */
            ii(0x100f_170c, 5);  mov(edx, 0x16a);                      /* mov edx, 0x16a */
            ii(0x100f_1711, 3);  mov(eax, memd[ss, ebp - 60]);         /* mov eax, [ebp-0x3c] */
            ii(0x100f_1714, 5);  call(Definitions.my_ctor_c17, -0x2_330a);/* call 0x100ce40f */
            ii(0x100f_1719, 3);  mov(memd[ss, ebp - 68], eax);         /* mov [ebp-0x44], eax */
            ii(0x100f_171c, 3);  mov(eax, memd[ss, ebp - 68]);         /* mov eax, [ebp-0x44] */
            ii(0x100f_171f, 3);  mov(memd[ss, ebp - 72], eax);         /* mov [ebp-0x48], eax */
            ii(0x100f_1722, 2);  jmp(0x100f_172a, 6); goto l_0x100f_172a;/* jmp 0x100f172a */
        l_0x100f_1724:
            ii(0x100f_1724, 3);  mov(eax, memd[ss, ebp - 64]);         /* mov eax, [ebp-0x40] */
            ii(0x100f_1727, 3);  mov(memd[ss, ebp - 72], eax);         /* mov [ebp-0x48], eax */
        l_0x100f_172a:
            ii(0x100f_172a, 3);  mov(eax, memd[ss, ebp - 72]);         /* mov eax, [ebp-0x48] */
            ii(0x100f_172d, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x100f_1730, 3);  mov(memd[ds, edx + 20], eax);         /* mov [edx+0x14], eax */
            ii(0x100f_1733, 5);  mov(edx, 0x1b);                       /* mov edx, 0x1b */
            ii(0x100f_1738, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_173b, 3);  mov(eax, memd[ds, eax + 20]);         /* mov eax, [eax+0x14] */
            ii(0x100f_173e, 5);  call(0x100d_5134, -0x1_c60f);         /* call 0x100d5134 */
            ii(0x100f_1743, 5);  mov(edx, 0x701b);                     /* mov edx, 0x701b */
            ii(0x100f_1748, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_174b, 3);  mov(eax, memd[ds, eax + 20]);         /* mov eax, [eax+0x14] */
            ii(0x100f_174e, 5);  call(0x100d_5164, -0x1_c5ef);         /* call 0x100d5164 */
            ii(0x100f_1753, 5);  mov(edx, 0x4e4);                      /* mov edx, 0x4e4 */
            ii(0x100f_1758, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_175b, 3);  mov(eax, memd[ds, eax + 20]);         /* mov eax, [eax+0x14] */
            ii(0x100f_175e, 5);  call(0x100d_50d4, -0x1_c68f);         /* call 0x100d50d4 */
            ii(0x100f_1763, 3);  lea(eax, memd[ss, ebp - 76]);         /* lea eax, [ebp-0x4c] */
            ii(0x100f_1766, 5);  call(0x100d_5224, -0x1_c547);         /* call 0x100d5224 */
            ii(0x100f_176b, 1);  push(eax);                            /* push eax */
            ii(0x100f_176c, 3);  lea(eax, memd[ss, ebp - 80]);         /* lea eax, [ebp-0x50] */
            ii(0x100f_176f, 5);  call(0x100d_5250, -0x1_c524);         /* call 0x100d5250 */
            ii(0x100f_1774, 1);  push(eax);                            /* push eax */
            ii(0x100f_1775, 3);  lea(eax, memd[ss, ebp - 84]);         /* lea eax, [ebp-0x54] */
            ii(0x100f_1778, 5);  call(0x100d_527c, -0x1_c501);         /* call 0x100d527c */
            ii(0x100f_177d, 1);  push(eax);                            /* push eax */
            ii(0x100f_177e, 3);  lea(eax, memd[ss, ebp - 88]);         /* lea eax, [ebp-0x58] */
            ii(0x100f_1781, 5);  call(0x100d_52a8, -0x1_c4de);         /* call 0x100d52a8 */
            ii(0x100f_1786, 1);  push(eax);                            /* push eax */
            ii(0x100f_1787, 5);  call(0x100d_52d4, -0x1_c4b8);         /* call 0x100d52d4 */
            ii(0x100f_178c, 3);  movsx(ecx, ax);                       /* movsx ecx, ax */
            ii(0x100f_178f, 5);  call(0x100d_52f8, -0x1_c49c);         /* call 0x100d52f8 */
            ii(0x100f_1794, 3);  movsx(ebx, ax);                       /* movsx ebx, ax */
            ii(0x100f_1797, 5);  mov(edx, StringDefinitions.Cancel4);  /* mov edx, 0x101a22f1 */
            ii(0x100f_179c, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_179f, 3);  mov(eax, memd[ds, eax + 20]);         /* mov eax, [eax+0x14] */
            ii(0x100f_17a2, 5);  call(0x100c_ef64, -0x2_2843);         /* call 0x100cef64 */
            ii(0x100f_17a7, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x100f_17aa, 3);  mov(edx, memd[ds, edx + 4]);          /* mov edx, [edx+0x4] */
            ii(0x100f_17ad, 3);  mov(edx, memd[ds, edx + 18]);         /* mov edx, [edx+0x12] */
            ii(0x100f_17b0, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_17b3, 3);  mov(eax, memd[ds, eax + 20]);         /* mov eax, [eax+0x14] */
            ii(0x100f_17b6, 5);  call(0x100c_f85c, -0x2_1f5f);         /* call 0x100cf85c */
            ii(0x100f_17bb, 5);  call(0x100d_51e4, -0x1_c5dc);         /* call 0x100d51e4 */
            ii(0x100f_17c0, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x100f_17c2, 2);  mov(bl, al);                          /* mov bl, al */
            ii(0x100f_17c4, 5);  call(0x100d_5204, -0x1_c5c5);         /* call 0x100d5204 */
            ii(0x100f_17c9, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100f_17cb, 2);  mov(dl, al);                          /* mov dl, al */
            ii(0x100f_17cd, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_17d0, 3);  mov(eax, memd[ds, eax + 20]);         /* mov eax, [eax+0x14] */
            ii(0x100f_17d3, 5);  call(0x100c_fa7c, -0x2_1d5c);         /* call 0x100cfa7c */
        l_0x100f_17d8:
            ii(0x100f_17d8, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100f_17da, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100f_17db, 1);  pop(edi);                             /* pop edi */
            ii(0x100f_17dc, 1);  pop(esi);                             /* pop esi */
            ii(0x100f_17dd, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100f_17de, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100f_17df, 1);  ret();                                /* ret */
        }
    }
}
