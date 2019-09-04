using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_1575-c57812db")]
        public void Method_1008_1575()
        {
            ii(0x1008_1575, 5);  push(0xb8);                           /* push 0xb8 */
            ii(0x1008_157a, 5);  call(Definitions.sys_check_available_stack_size, 0xe_47d3);/* call 0x10165d52 */
            ii(0x1008_157f, 1);  push(ebx);                            /* push ebx */
            ii(0x1008_1580, 1);  push(ecx);                            /* push ecx */
            ii(0x1008_1581, 1);  push(esi);                            /* push esi */
            ii(0x1008_1582, 1);  push(edi);                            /* push edi */
            ii(0x1008_1583, 1);  push(ebp);                            /* push ebp */
            ii(0x1008_1584, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1008_1586, 6);  sub(esp, 0x88);                       /* sub esp, 0x88 */
            ii(0x1008_158c, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1008_158f, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1008_1592, 7);  mov(memd[ss, ebp - 12], 0);           /* mov dword [ebp-0xc], 0x0 */
            ii(0x1008_1599, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_159c, 3);  add(eax, 0x2a);                       /* add eax, 0x2a */
            ii(0x1008_159f, 5);  call(0x1008_9dd8, 0x8834);            /* call 0x10089dd8 */
            ii(0x1008_15a4, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1008_15a7, 4);  cmp(memd[ss, ebp - 12], 0);           /* cmp dword [ebp-0xc], 0x0 */
            ii(0x1008_15ab, 2);  if(jz(0x1008_15b9, 0xc)) goto l_0x1008_15b9;/* jz 0x100815b9 */
            ii(0x1008_15ad, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1008_15b0, 5);  call(0x1008_9f70, 0x89bb);            /* call 0x10089f70 */
            ii(0x1008_15b5, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1008_15b7, 2);  if(jz(0x1008_15bb, 2)) goto l_0x1008_15bb;/* jz 0x100815bb */
        l_0x1008_15b9:
            ii(0x1008_15b9, 2);  jmp(0x1008_15c2, 7); goto l_0x1008_15c2;/* jmp 0x100815c2 */
        l_0x1008_15bb:
            ii(0x1008_15bb, 7);  mov(memd[ss, ebp - 12], 0);           /* mov dword [ebp-0xc], 0x0 */
        l_0x1008_15c2:
            ii(0x1008_15c2, 4);  cmp(memd[ss, ebp - 12], 0);           /* cmp dword [ebp-0xc], 0x0 */
            ii(0x1008_15c6, 2);  if(jnz(0x1008_15d8, 0x10)) goto l_0x1008_15d8;/* jnz 0x100815d8 */
            ii(0x1008_15c8, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_15cb, 3);  add(eax, 0x20);                       /* add eax, 0x20 */
            ii(0x1008_15ce, 5);  call(0x1007_6b90, -0xaa43);           /* call 0x10076b90 */
            ii(0x1008_15d3, 1);  cwde();                               /* cwde */
            ii(0x1008_15d4, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1008_15d6, 2);  if(jg(0x1008_15da, 2)) goto l_0x1008_15da;/* jg 0x100815da */
        l_0x1008_15d8:
            ii(0x1008_15d8, 2);  jmp(0x1008_15ea, 0x10); goto l_0x1008_15ea;/* jmp 0x100815ea */
        l_0x1008_15da:
            ii(0x1008_15da, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1008_15dc, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_15df, 3);  add(eax, 0x20);                       /* add eax, 0x20 */
            ii(0x1008_15e2, 5);  call(0x1008_9c68, 0x8681);            /* call 0x10089c68 */
            ii(0x1008_15e7, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
        l_0x1008_15ea:
            ii(0x1008_15ea, 4);  cmp(memd[ss, ebp - 12], 0);           /* cmp dword [ebp-0xc], 0x0 */
            ii(0x1008_15ee, 2);  if(jz(0x1008_15fc, 0xc)) goto l_0x1008_15fc;/* jz 0x100815fc */
            ii(0x1008_15f0, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1008_15f3, 5);  call(0x1008_9f70, 0x8978);            /* call 0x10089f70 */
            ii(0x1008_15f8, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1008_15fa, 2);  if(jz(0x1008_15fe, 2)) goto l_0x1008_15fe;/* jz 0x100815fe */
        l_0x1008_15fc:
            ii(0x1008_15fc, 2);  jmp(0x1008_1605, 7); goto l_0x1008_1605;/* jmp 0x10081605 */
        l_0x1008_15fe:
            ii(0x1008_15fe, 7);  mov(memd[ss, ebp - 12], 0);           /* mov dword [ebp-0xc], 0x0 */
        l_0x1008_1605:
            ii(0x1008_1605, 4);  cmp(memd[ss, ebp - 12], 0);           /* cmp dword [ebp-0xc], 0x0 */
            ii(0x1008_1609, 2);  if(jnz(0x1008_161d, 0x12)) goto l_0x1008_161d;/* jnz 0x1008161d */
            ii(0x1008_160b, 5);  mov(edx, StringDefinitions.CompletedAttackTask);/* mov edx, 0x101a0211 */
            ii(0x1008_1610, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_1613, 5);  call(Definitions.sys_strcpy, 0xe_48b7);/* call 0x10165ecf */
            ii(0x1008_1618, 5);  jmp(0x1008_179b, 0x17e); goto l_0x1008_179b;/* jmp 0x1008179b */
        l_0x1008_161d:
            ii(0x1008_161d, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1008_1620, 5);  call(Definitions.my_ctor_0x101b_4184, -0xab35);/* call 0x10076af0 */
            ii(0x1008_1625, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_1628, 3);  mov(al, memb[ds, eax + 21]);          /* mov al, [eax+0x15] */
            ii(0x1008_162b, 3);  mov(memb[ss, ebp - 20], al);          /* mov [ebp-0x14], al */
            ii(0x1008_162e, 5);  jmp(0x1008_16a8, 0x75); goto l_0x1008_16a8;/* jmp 0x100816a8 */
        l_0x1008_1633:
            ii(0x1008_1633, 7);  mov(memd[ss, ebp - 28], StringDefinitions.InitAttackOn);/* mov dword [ebp-0x1c], 0x101a0228 */
            ii(0x1008_163a, 5);  jmp(0x1008_16c3, 0x84); goto l_0x1008_16c3;/* jmp 0x100816c3 */
        l_0x1008_163f:
            ii(0x1008_163f, 7);  mov(memd[ss, ebp - 28], StringDefinitions.WaitToAttack);/* mov dword [ebp-0x1c], 0x101a0239 */
            ii(0x1008_1646, 5);  jmp(0x1008_16c3, 0x78); goto l_0x1008_16c3;/* jmp 0x100816c3 */
        l_0x1008_164b:
            ii(0x1008_164b, 7);  mov(memd[ss, ebp - 28], StringDefinitions.GatherAttackOn);/* mov dword [ebp-0x1c], 0x101a0249 */
            ii(0x1008_1652, 5);  jmp(0x1008_16c3, 0x6c); goto l_0x1008_16c3;/* jmp 0x100816c3 */
        l_0x1008_1657:
            ii(0x1008_1657, 7);  mov(memd[ss, ebp - 28], StringDefinitions.AdvOn);/* mov dword [ebp-0x1c], 0x101a025a */
            ii(0x1008_165e, 2);  jmp(0x1008_16c3, 0x63); goto l_0x1008_16c3;/* jmp 0x100816c3 */
        l_0x1008_1660:
            ii(0x1008_1660, 7);  mov(memd[ss, ebp - 28], StringDefinitions.AdvWTransOn);/* mov dword [ebp-0x1c], 0x101a0263 */
            ii(0x1008_1667, 2);  jmp(0x1008_16c3, 0x5a); goto l_0x1008_16c3;/* jmp 0x100816c3 */
        l_0x1008_1669:
            ii(0x1008_1669, 7);  mov(memd[ss, ebp - 28], StringDefinitions.SearchFor);/* mov dword [ebp-0x1c], 0x101a0273 */
            ii(0x1008_1670, 2);  jmp(0x1008_16c3, 0x51); goto l_0x1008_16c3;/* jmp 0x100816c3 */
        l_0x1008_1672:
            ii(0x1008_1672, 7);  mov(memd[ss, ebp - 28], StringDefinitions.BoldSearchFor);/* mov dword [ebp-0x1c], 0x101a027f */
            ii(0x1008_1679, 2);  jmp(0x1008_16c3, 0x48); goto l_0x1008_16c3;/* jmp 0x100816c3 */
        l_0x1008_167b:
            ii(0x1008_167b, 7);  mov(memd[ss, ebp - 28], StringDefinitions.Attack6);/* mov dword [ebp-0x1c], 0x101a0290 */
            ii(0x1008_1682, 2);  jmp(0x1008_16c3, 0x3f); goto l_0x1008_16c3;/* jmp 0x100816c3 */
        l_0x1008_1684:
            ii(0x1008_1684, 2);  jmp(0x1008_16c3, 0x3d); goto l_0x1008_16c3;/* jmp 0x100816c3 */
        //  ii(0x1008_1686, 2);  mov(eax, eax);                        /* mov eax, eax */
        //  ii(0x1008_1688, 32);  /* Служебная область с абсолютными адресами переходов. (0x1008_1633, 0x1008_163f, 0x1008_164b, 0x1008_1657, 0x1008_1660, 0x1008_1669, 0x1008_1672, 0x1008_167b). */
        l_0x1008_16a8:
            ii(0x1008_16a8, 3);  mov(al, memb[ss, ebp - 20]);          /* mov al, [ebp-0x14] */
            ii(0x1008_16ab, 3);  mov(memb[ss, ebp - 32], al);          /* mov [ebp-0x20], al */
            ii(0x1008_16ae, 4);  cmp(memb[ss, ebp - 32], 7);           /* cmp byte [ebp-0x20], 0x7 */
            ii(0x1008_16b2, 2);  if(ja(0x1008_1684, -0x30)) goto l_0x1008_1684;/* ja 0x10081684 */
            ii(0x1008_16b4, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1008_16b6, 3);  mov(al, memb[ss, ebp - 32]);          /* mov al, [ebp-0x20] */
            ii(0x1008_16b9, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1008_16bc, 7);  
            switch (jmp_abs_switch(memd[cs, eax + 0x1008_1688]))
            {
                case 0x1008_1633:
                    goto l_0x1008_1633;
                case 0x1008_163f:
                    goto l_0x1008_163f;
                case 0x1008_164b:
                    goto l_0x1008_164b;
                case 0x1008_1657:
                    goto l_0x1008_1657;
                case 0x1008_1660:
                    goto l_0x1008_1660;
                case 0x1008_1669:
                    goto l_0x1008_1669;
                case 0x1008_1672:
                    goto l_0x1008_1672;
                case 0x1008_167b:
                    goto l_0x1008_167b;
                default:
                    throw new NotImplementedException();
            }/* jmp dword [cs:eax+0x10081688] */
        l_0x1008_16c3:
            ii(0x1008_16c3, 3);  lea(edx, memd[ss, ebp - 36]);         /* lea edx, [ebp-0x24] */
            ii(0x1008_16c6, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1008_16c9, 5);  call(0x100a_2d3d, 0x2_166f);          /* call 0x100a2d3d */
            ii(0x1008_16ce, 3);  lea(ebx, memd[ss, ebp - 24]);         /* lea ebx, [ebp-0x18] */
            ii(0x1008_16d1, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1008_16d3, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x1008_16d5, 5);  call(0x1008_8b44, 0x746a);            /* call 0x10088b44 */
            ii(0x1008_16da, 4);  movsx(eax, memw[ss, ebp - 22]);       /* movsx eax, word [ebp-0x16] */
            ii(0x1008_16de, 1);  inc(eax);                             /* inc eax */
            ii(0x1008_16df, 1);  push(eax);                            /* push eax */
            ii(0x1008_16e0, 4);  movsx(eax, memw[ss, ebp - 24]);       /* movsx eax, word [ebp-0x18] */
            ii(0x1008_16e4, 1);  inc(eax);                             /* inc eax */
            ii(0x1008_16e5, 1);  push(eax);                            /* push eax */
            ii(0x1008_16e6, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1008_16e9, 5);  call(0x1008_9f70, 0x8882);            /* call 0x10089f70 */
            ii(0x1008_16ee, 3);  mov(eax, memd[ds, eax + 6]);          /* mov eax, [eax+0x6] */
            ii(0x1008_16f1, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1008_16f4, 3);  imul(eax, eax, 0x33);                 /* imul eax, eax, 0x33 */
            ii(0x1008_16f7, 6);  push(memd[ds, eax + 0x101c_81d7]);    /* push dword [eax+0x101c81d7] */
            ii(0x1008_16fd, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x1008_1700, 1);  push(eax);                            /* push eax */
            ii(0x1008_1701, 5);  mov(eax, StringDefinitions.SSAtII);   /* mov eax, 0x101a0298 */
            ii(0x1008_1706, 1);  push(eax);                            /* push eax */
            ii(0x1008_1707, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_170a, 1);  push(eax);                            /* push eax */
            ii(0x1008_170b, 5);  call(Definitions.sys_sprintf, 0xe_47f1);/* call 0x10165f01 */
            ii(0x1008_1710, 3);  add(esp, 0x18);                       /* add esp, 0x18 */
            ii(0x1008_1713, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1008_1715, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_1718, 3);  add(eax, 0x32);                       /* add eax, 0x32 */
            ii(0x1008_171b, 5);  call(0x1013_ad71, 0xb_9651);          /* call 0x1013ad71 */
            ii(0x1008_1720, 2);  test(al, al);                         /* test al, al */
            ii(0x1008_1722, 2);  if(jz(0x1008_179b, 0x77)) goto l_0x1008_179b;/* jz 0x1008179b */
            ii(0x1008_1724, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_1727, 3);  add(eax, 0x32);                       /* add eax, 0x32 */
            ii(0x1008_172a, 5);  call(0x1007_6574, -0xb1bb);           /* call 0x10076574 */
            ii(0x1008_172f, 3);  mov(eax, memd[ds, eax + 26]);         /* mov eax, [eax+0x1a] */
            ii(0x1008_1732, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1008_1735, 1);  inc(eax);                             /* inc eax */
            ii(0x1008_1736, 1);  push(eax);                            /* push eax */
            ii(0x1008_1737, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_173a, 3);  add(eax, 0x32);                       /* add eax, 0x32 */
            ii(0x1008_173d, 5);  call(0x1007_6574, -0xb1ce);           /* call 0x10076574 */
            ii(0x1008_1742, 3);  mov(eax, memd[ds, eax + 24]);         /* mov eax, [eax+0x18] */
            ii(0x1008_1745, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1008_1748, 1);  inc(eax);                             /* inc eax */
            ii(0x1008_1749, 1);  push(eax);                            /* push eax */
            ii(0x1008_174a, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_174d, 3);  add(eax, 0x32);                       /* add eax, 0x32 */
            ii(0x1008_1750, 5);  call(0x1007_6574, -0xb1e1);           /* call 0x10076574 */
            ii(0x1008_1755, 3);  mov(al, memb[ds, eax + 39]);          /* mov al, [eax+0x27] */
            ii(0x1008_1758, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1008_175d, 1);  push(eax);                            /* push eax */
            ii(0x1008_175e, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_1761, 3);  add(eax, 0x32);                       /* add eax, 0x32 */
            ii(0x1008_1764, 5);  call(0x1007_6574, -0xb1f5);           /* call 0x10076574 */
            ii(0x1008_1769, 3);  mov(eax, memd[ds, eax + 6]);          /* mov eax, [eax+0x6] */
            ii(0x1008_176c, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1008_176f, 3);  imul(eax, eax, 0x33);                 /* imul eax, eax, 0x33 */
            ii(0x1008_1772, 6);  push(memd[ds, eax + 0x101c_81d7]);    /* push dword [eax+0x101c81d7] */
            ii(0x1008_1778, 5);  mov(eax, StringDefinitions.LeaderSIAtII);/* mov eax, 0x101a02a9 */
            ii(0x1008_177d, 1);  push(eax);                            /* push eax */
            ii(0x1008_177e, 6);  lea(eax, memd[ss, ebp - 136]);        /* lea eax, [ebp-0x88] */
            ii(0x1008_1784, 1);  push(eax);                            /* push eax */
            ii(0x1008_1785, 5);  call(Definitions.sys_sprintf, 0xe_4777);/* call 0x10165f01 */
            ii(0x1008_178a, 3);  add(esp, 0x18);                       /* add esp, 0x18 */
            ii(0x1008_178d, 6);  lea(edx, memd[ss, ebp - 136]);        /* lea edx, [ebp-0x88] */
            ii(0x1008_1793, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_1796, 5);  call(Definitions.sys_strcat, 0xe_4796);/* call 0x10165f31 */
        l_0x1008_179b:
            ii(0x1008_179b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_179e, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1008_17a1, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1008_17a4, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1008_17a6, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1008_17a7, 1);  pop(edi);                             /* pop edi */
            ii(0x1008_17a8, 1);  pop(esi);                             /* pop esi */
            ii(0x1008_17a9, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1008_17aa, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1008_17ab, 1);  ret();                                /* ret */
        }
    }
}
