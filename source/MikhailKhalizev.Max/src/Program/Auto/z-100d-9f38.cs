using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_9f38-edbcd5a4")]
        public void Method_100d_9f38()
        {
            ii(0x100d_9f38, 5);  push(0x38);                           /* push 0x38 */
            ii(0x100d_9f3d, 5);  call(Definitions.sys_check_available_stack_size, 0x8_be10);/* call 0x10165d52 */
            ii(0x100d_9f42, 1);  push(ebx);                            /* push ebx */
            ii(0x100d_9f43, 1);  push(ecx);                            /* push ecx */
            ii(0x100d_9f44, 1);  push(esi);                            /* push esi */
            ii(0x100d_9f45, 1);  push(edi);                            /* push edi */
            ii(0x100d_9f46, 1);  push(ebp);                            /* push ebp */
            ii(0x100d_9f47, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100d_9f49, 6);  sub(esp, 0x18);                       /* sub esp, 0x18 */
            ii(0x100d_9f4f, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100d_9f52, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100d_9f55, 4);  movsx(edx, memw[ss, ebp - 4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x100d_9f59, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_9f5c, 3);  mov(eax, memd[ds, eax + 73]);         /* mov eax, [eax+0x49] */
            ii(0x100d_9f5f, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100d_9f62, 6);  imul(eax, eax, 0x247);                /* imul eax, eax, 0x247 */
            ii(0x100d_9f68, 6);  mov(eax, memd[ds, eax + 0x101c_a562]);/* mov eax, [eax+0x101ca562] */
            ii(0x100d_9f6e, 5);  call(0x100c_b6b0, -0xe8c3);           /* call 0x100cb6b0 */
            ii(0x100d_9f73, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100d_9f75, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x100d_9f78, 5);  call(0x1007_6800, -0x6_377d);         /* call 0x10076800 */
            ii(0x100d_9f7d, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x100d_9f80, 5);  call(0x1007_6730, -0x6_3855);         /* call 0x10076730 */
            ii(0x100d_9f85, 3);  mov(eax, memd[ds, eax + 12]);         /* mov eax, [eax+0xc] */
            ii(0x100d_9f88, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100d_9f8b, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100d_9f8d, 2);  if(jnz(0x100d_9f9e, 0xf)) goto l_0x100d_9f9e;/* jnz 0x100d9f9e */
            ii(0x100d_9f8f, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100d_9f91, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x100d_9f94, 5);  call(0x1007_5eec, -0x6_40ad);         /* call 0x10075eec */
            ii(0x100d_9f99, 5);  jmp(0x100d_a143, 0x1a5); goto l_0x100d_a143;/* jmp 0x100da143 */
        l_0x100d_9f9e:
            ii(0x100d_9f9e, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100d_9fa2, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x100d_9fa5, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x100d_9fa8, 3);  add(edx, 0x5b);                       /* add edx, 0x5b */
            ii(0x100d_9fab, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x100d_9fad, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100d_9fb0, 5);  call(0x1007_67bc, -0x6_37f9);         /* call 0x100767bc */
            ii(0x100d_9fb5, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100d_9fb9, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x100d_9fbc, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x100d_9fbf, 6);  add(edx, 0x1cf);                      /* add edx, 0x1cf */
            ii(0x100d_9fc5, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x100d_9fc7, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x100d_9fca, 5);  call(0x1007_67bc, -0x6_3813);         /* call 0x100767bc */
            ii(0x100d_9fcf, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_9fd2, 4);  mov(ax, memw[ds, eax + 81]);          /* mov ax, [eax+0x51] */
            ii(0x100d_9fd6, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100d_9fd9, 4);  movsx(ebx, memw[ss, ebp - 4]);        /* movsx ebx, word [ebp-0x4] */
            ii(0x100d_9fdd, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100d_9fdf, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_9fe2, 3);  mov(eax, memd[ds, eax + 73]);         /* mov eax, [eax+0x49] */
            ii(0x100d_9fe5, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100d_9fe8, 5);  call(0x1013_3743, 0x5_9756);          /* call 0x10133743 */
            ii(0x100d_9fed, 1);  cwde();                               /* cwde */
            ii(0x100d_9fee, 1);  push(eax);                            /* push eax */
            ii(0x100d_9fef, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x100d_9ff2, 5);  call(0x1007_6730, -0x6_38c7);         /* call 0x10076730 */
            ii(0x100d_9ff7, 3);  add(eax, 0xe);                        /* add eax, 0xe */
            ii(0x100d_9ffa, 1);  push(eax);                            /* push eax */
            ii(0x100d_9ffb, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100d_9ffe, 5);  call(0x1007_6730, -0x6_38d3);         /* call 0x10076730 */
            ii(0x100d_a003, 3);  mov(ecx, memd[ds, eax + 12]);         /* mov ecx, [eax+0xc] */
            ii(0x100d_a006, 3);  sar(ecx, 0x10);                       /* sar ecx, 0x10 */
            ii(0x100d_a009, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x100d_a00c, 5);  call(0x1007_6730, -0x6_38e1);         /* call 0x10076730 */
            ii(0x100d_a011, 3);  mov(ebx, memd[ds, eax + 12]);         /* mov ebx, [eax+0xc] */
            ii(0x100d_a014, 3);  sar(ebx, 0x10);                       /* sar ebx, 0x10 */
            ii(0x100d_a017, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x100d_a01c, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_a01f, 5);  call(0x100d_9e3f, -0x1e5);            /* call 0x100d9e3f */
            ii(0x100d_a024, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x100d_a027, 5);  call(0x1007_6730, -0x6_38fc);         /* call 0x10076730 */
            ii(0x100d_a02c, 5);  cmp(memw[ds, eax + 20], 0);           /* cmp word [eax+0x14], 0x0 */
            ii(0x100d_a031, 2);  if(jz(0x100d_a081, 0x4e)) goto l_0x100d_a081;/* jz 0x100da081 */
            ii(0x100d_a033, 4);  movsx(ebx, memw[ss, ebp - 4]);        /* movsx ebx, word [ebp-0x4] */
            ii(0x100d_a037, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x100d_a03c, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_a03f, 3);  mov(eax, memd[ds, eax + 73]);         /* mov eax, [eax+0x49] */
            ii(0x100d_a042, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100d_a045, 5);  call(0x1013_3743, 0x5_96f9);          /* call 0x10133743 */
            ii(0x100d_a04a, 1);  cwde();                               /* cwde */
            ii(0x100d_a04b, 1);  push(eax);                            /* push eax */
            ii(0x100d_a04c, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x100d_a04f, 5);  call(0x1007_6730, -0x6_3924);         /* call 0x10076730 */
            ii(0x100d_a054, 3);  add(eax, 0x14);                       /* add eax, 0x14 */
            ii(0x100d_a057, 1);  push(eax);                            /* push eax */
            ii(0x100d_a058, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100d_a05b, 5);  call(0x1007_6730, -0x6_3930);         /* call 0x10076730 */
            ii(0x100d_a060, 3);  mov(ecx, memd[ds, eax + 18]);         /* mov ecx, [eax+0x12] */
            ii(0x100d_a063, 3);  sar(ecx, 0x10);                       /* sar ecx, 0x10 */
            ii(0x100d_a066, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x100d_a069, 5);  call(0x1007_6730, -0x6_393e);         /* call 0x10076730 */
            ii(0x100d_a06e, 3);  mov(ebx, memd[ds, eax + 18]);         /* mov ebx, [eax+0x12] */
            ii(0x100d_a071, 3);  sar(ebx, 0x10);                       /* sar ebx, 0x10 */
            ii(0x100d_a074, 5);  mov(edx, 2);                          /* mov edx, 0x2 */
            ii(0x100d_a079, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_a07c, 5);  call(0x100d_9e3f, -0x242);            /* call 0x100d9e3f */
        l_0x100d_a081:
            ii(0x100d_a081, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x100d_a084, 5);  call(0x1007_6730, -0x6_3959);         /* call 0x10076730 */
            ii(0x100d_a089, 5);  cmp(memw[ds, eax + 18], 0);           /* cmp word [eax+0x12], 0x0 */
            ii(0x100d_a08e, 2);  if(jz(0x100d_a0de, 0x4e)) goto l_0x100d_a0de;/* jz 0x100da0de */
            ii(0x100d_a090, 4);  movsx(ebx, memw[ss, ebp - 4]);        /* movsx ebx, word [ebp-0x4] */
            ii(0x100d_a094, 5);  mov(edx, 2);                          /* mov edx, 0x2 */
            ii(0x100d_a099, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_a09c, 3);  mov(eax, memd[ds, eax + 73]);         /* mov eax, [eax+0x49] */
            ii(0x100d_a09f, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100d_a0a2, 5);  call(0x1013_3743, 0x5_969c);          /* call 0x10133743 */
            ii(0x100d_a0a7, 1);  cwde();                               /* cwde */
            ii(0x100d_a0a8, 1);  push(eax);                            /* push eax */
            ii(0x100d_a0a9, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x100d_a0ac, 5);  call(0x1007_6730, -0x6_3981);         /* call 0x10076730 */
            ii(0x100d_a0b1, 3);  add(eax, 0x12);                       /* add eax, 0x12 */
            ii(0x100d_a0b4, 1);  push(eax);                            /* push eax */
            ii(0x100d_a0b5, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100d_a0b8, 5);  call(0x1007_6730, -0x6_398d);         /* call 0x10076730 */
            ii(0x100d_a0bd, 3);  mov(ecx, memd[ds, eax + 16]);         /* mov ecx, [eax+0x10] */
            ii(0x100d_a0c0, 3);  sar(ecx, 0x10);                       /* sar ecx, 0x10 */
            ii(0x100d_a0c3, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x100d_a0c6, 5);  call(0x1007_6730, -0x6_399b);         /* call 0x10076730 */
            ii(0x100d_a0cb, 3);  mov(ebx, memd[ds, eax + 16]);         /* mov ebx, [eax+0x10] */
            ii(0x100d_a0ce, 3);  sar(ebx, 0x10);                       /* sar ebx, 0x10 */
            ii(0x100d_a0d1, 5);  mov(edx, 3);                          /* mov edx, 0x3 */
            ii(0x100d_a0d6, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_a0d9, 5);  call(0x100d_9e3f, -0x29f);            /* call 0x100d9e3f */
        l_0x100d_a0de:
            ii(0x100d_a0de, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x100d_a0e1, 5);  call(0x1007_6730, -0x6_39b6);         /* call 0x10076730 */
            ii(0x100d_a0e6, 5);  cmp(memw[ds, eax + 27], 0);           /* cmp word [eax+0x1b], 0x0 */
            ii(0x100d_a0eb, 2);  if(jz(0x100d_a125, 0x38)) goto l_0x100d_a125;/* jz 0x100da125 */
            ii(0x100d_a0ed, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x100d_a0ef, 1);  push(eax);                            /* push eax */
            ii(0x100d_a0f0, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x100d_a0f3, 5);  call(0x1007_6730, -0x6_39c8);         /* call 0x10076730 */
            ii(0x100d_a0f8, 3);  add(eax, 0x1b);                       /* add eax, 0x1b */
            ii(0x100d_a0fb, 1);  push(eax);                            /* push eax */
            ii(0x100d_a0fc, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100d_a0ff, 5);  call(0x1007_6730, -0x6_39d4);         /* call 0x10076730 */
            ii(0x100d_a104, 3);  mov(ecx, memd[ds, eax + 25]);         /* mov ecx, [eax+0x19] */
            ii(0x100d_a107, 3);  sar(ecx, 0x10);                       /* sar ecx, 0x10 */
            ii(0x100d_a10a, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x100d_a10d, 5);  call(0x1007_6730, -0x6_39e2);         /* call 0x10076730 */
            ii(0x100d_a112, 3);  mov(ebx, memd[ds, eax + 25]);         /* mov ebx, [eax+0x19] */
            ii(0x100d_a115, 3);  sar(ebx, 0x10);                       /* sar ebx, 0x10 */
            ii(0x100d_a118, 5);  mov(edx, 4);                          /* mov edx, 0x4 */
            ii(0x100d_a11d, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_a120, 5);  call(0x100d_9e3f, -0x2e6);            /* call 0x100d9e3f */
        l_0x100d_a125:
            ii(0x100d_a125, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100d_a127, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x100d_a12a, 5);  call(0x1007_5eec, -0x6_4243);         /* call 0x10075eec */
            ii(0x100d_a12f, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100d_a131, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100d_a134, 5);  call(0x1007_5eec, -0x6_424d);         /* call 0x10075eec */
            ii(0x100d_a139, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100d_a13b, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x100d_a13e, 5);  call(0x1007_5eec, -0x6_4257);         /* call 0x10075eec */
        l_0x100d_a143:
            ii(0x100d_a143, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100d_a145, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100d_a146, 1);  pop(edi);                             /* pop edi */
            ii(0x100d_a147, 1);  pop(esi);                             /* pop esi */
            ii(0x100d_a148, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100d_a149, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100d_a14a, 1);  ret();                                /* ret */
        }
    }
}
