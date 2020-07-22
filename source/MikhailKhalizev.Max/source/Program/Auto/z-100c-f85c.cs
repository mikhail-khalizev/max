using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_f85c-61803c8b")]
        public void Method_100c_f85c()
        {
            ii(0x100c_f85c, 5);  push(0x90);                           /* push 0x90 */
            ii(0x100c_f861, 5);  call(Definitions.sys_check_available_stack_size, 0x9_64ec);/* call 0x10165d52 */
            ii(0x100c_f866, 1);  push(ebx);                            /* push ebx */
            ii(0x100c_f867, 1);  push(ecx);                            /* push ecx */
            ii(0x100c_f868, 1);  push(esi);                            /* push esi */
            ii(0x100c_f869, 1);  push(edi);                            /* push edi */
            ii(0x100c_f86a, 1);  push(ebp);                            /* push ebp */
            ii(0x100c_f86b, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100c_f86d, 6);  sub(esp, 0x54);                       /* sub esp, 0x54 */
            ii(0x100c_f873, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100c_f876, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100c_f879, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_f87c, 4);  cmp(memd[ds, eax + 16], 0);           /* cmp dword [eax+0x10], 0x0 */
            ii(0x100c_f880, 2);  if(jz(0x100c_f8b0, 0x2e)) goto l_0x100c_f8b0;/* jz 0x100cf8b0 */
            ii(0x100c_f882, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_f885, 3);  mov(eax, memd[ds, eax + 16]);         /* mov eax, [eax+0x10] */
            ii(0x100c_f888, 5);  call(0x100d_4f58, 0x56cb);            /* call 0x100d4f58 */
            ii(0x100c_f88d, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100c_f88f, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_f892, 4);  cmp(dx, memw[ds, eax + 8]);           /* cmp dx, [eax+0x8] */
            ii(0x100c_f896, 2);  if(jnz(0x100c_f8ae, 0x16)) goto l_0x100c_f8ae;/* jnz 0x100cf8ae */
            ii(0x100c_f898, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_f89b, 3);  mov(eax, memd[ds, eax + 16]);         /* mov eax, [eax+0x10] */
            ii(0x100c_f89e, 5);  call(0x100d_4f24, 0x5681);            /* call 0x100d4f24 */
            ii(0x100c_f8a3, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100c_f8a5, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_f8a8, 4);  cmp(dx, memw[ds, eax + 10]);          /* cmp dx, [eax+0xa] */
            ii(0x100c_f8ac, 2);  if(jz(0x100c_f8b0, 2)) goto l_0x100c_f8b0;/* jz 0x100cf8b0 */
        l_0x100c_f8ae:
            ii(0x100c_f8ae, 2);  jmp(0x100c_f8b5, 5); goto l_0x100c_f8b5;/* jmp 0x100cf8b5 */
        l_0x100c_f8b0:
            ii(0x100c_f8b0, 5);  jmp(0x100c_f97b, 0xc6); goto l_0x100c_f97b;/* jmp 0x100cf97b */
        l_0x100c_f8b5:
            ii(0x100c_f8b5, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_f8b8, 3);  mov(memd[ss, ebp - 38], eax);         /* mov [ebp-0x26], eax */
            ii(0x100c_f8bb, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_f8be, 5);  call(/* sys */ 0x1016_7dd4, 0x9_8511);/* call 0x10167dd4 */
            ii(0x100c_f8c3, 3);  mov(memd[ss, ebp - 34], eax);         /* mov [ebp-0x22], eax */
            ii(0x100c_f8c6, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_f8c9, 5);  call(/* sys */ 0x1016_7e3c, 0x9_856e);/* call 0x10167e3c */
            ii(0x100c_f8ce, 4);  mov(memw[ss, ebp - 40], ax);          /* mov [ebp-0x28], ax */
            ii(0x100c_f8d2, 5);  mov(eax, 0xd);                        /* mov eax, 0xd */
            ii(0x100c_f8d7, 5);  call(Definitions.sys_new, 0x9_6524);  /* call 0x10165e00 */
            ii(0x100c_f8dc, 3);  mov(memd[ss, ebp - 60], eax);         /* mov [ebp-0x3c], eax */
            ii(0x100c_f8df, 3);  mov(eax, memd[ss, ebp - 60]);         /* mov eax, [ebp-0x3c] */
            ii(0x100c_f8e2, 3);  mov(memd[ss, ebp - 64], eax);         /* mov [ebp-0x40], eax */
            ii(0x100c_f8e5, 4);  cmp(memd[ss, ebp - 64], 0);           /* cmp dword [ebp-0x40], 0x0 */
            ii(0x100c_f8e9, 2);  if(jz(0x100c_f923, 0x38)) goto l_0x100c_f923;/* jz 0x100cf923 */
            ii(0x100c_f8eb, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_f8ee, 3);  mov(eax, memd[ds, eax + 8]);          /* mov eax, [eax+0x8] */
            ii(0x100c_f8f1, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100c_f8f4, 1);  push(eax);                            /* push eax */
            ii(0x100c_f8f5, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_f8f8, 3);  mov(ecx, memd[ds, eax + 6]);          /* mov ecx, [eax+0x6] */
            ii(0x100c_f8fb, 3);  sar(ecx, 0x10);                       /* sar ecx, 0x10 */
            ii(0x100c_f8fe, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_f901, 3);  mov(ebx, memd[ds, eax + 4]);          /* mov ebx, [eax+0x4] */
            ii(0x100c_f904, 3);  sar(ebx, 0x10);                       /* sar ebx, 0x10 */
            ii(0x100c_f907, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_f90a, 3);  mov(edx, memd[ds, eax + 2]);          /* mov edx, [eax+0x2] */
            ii(0x100c_f90d, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x100c_f910, 3);  mov(eax, memd[ss, ebp - 60]);         /* mov eax, [ebp-0x3c] */
            ii(0x100c_f913, 5);  call(0x100d_7bdc, 0x82c4);            /* call 0x100d7bdc */
            ii(0x100c_f918, 3);  mov(memd[ss, ebp - 68], eax);         /* mov [ebp-0x44], eax */
            ii(0x100c_f91b, 3);  mov(eax, memd[ss, ebp - 68]);         /* mov eax, [ebp-0x44] */
            ii(0x100c_f91e, 3);  mov(memd[ss, ebp - 72], eax);         /* mov [ebp-0x48], eax */
            ii(0x100c_f921, 2);  jmp(0x100c_f929, 6); goto l_0x100c_f929;/* jmp 0x100cf929 */
        l_0x100c_f923:
            ii(0x100c_f923, 3);  mov(eax, memd[ss, ebp - 64]);         /* mov eax, [ebp-0x40] */
            ii(0x100c_f926, 3);  mov(memd[ss, ebp - 72], eax);         /* mov [ebp-0x48], eax */
        l_0x100c_f929:
            ii(0x100c_f929, 3);  mov(eax, memd[ss, ebp - 72]);         /* mov eax, [ebp-0x48] */
            ii(0x100c_f92c, 3);  mov(memd[ss, ebp - 76], eax);         /* mov [ebp-0x4c], eax */
            ii(0x100c_f92f, 3);  lea(edx, memd[ss, ebp - 56]);         /* lea edx, [ebp-0x38] */
            ii(0x100c_f932, 3);  mov(eax, memd[ss, ebp - 76]);         /* mov eax, [ebp-0x4c] */
            ii(0x100c_f935, 5);  call(0x100d_7d74, 0x843a);            /* call 0x100d7d74 */
            ii(0x100c_f93a, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_f93d, 3);  mov(edx, memd[ds, eax + 16]);         /* mov edx, [eax+0x10] */
            ii(0x100c_f940, 3);  mov(eax, memd[ss, ebp - 76]);         /* mov eax, [ebp-0x4c] */
            ii(0x100c_f943, 5);  call(0x100d_7e01, 0x84b9);            /* call 0x100d7e01 */
            ii(0x100c_f948, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_f94b, 3);  mov(eax, memd[ds, eax + 16]);         /* mov eax, [eax+0x10] */
            ii(0x100c_f94e, 3);  mov(memd[ss, ebp - 80], eax);         /* mov [ebp-0x50], eax */
            ii(0x100c_f951, 4);  cmp(memd[ss, ebp - 80], 0);           /* cmp dword [ebp-0x50], 0x0 */
            ii(0x100c_f955, 2);  if(jz(0x100c_f96b, 0x14)) goto l_0x100c_f96b;/* jz 0x100cf96b */
            ii(0x100c_f957, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100c_f959, 3);  mov(eax, memd[ss, ebp - 80]);         /* mov eax, [ebp-0x50] */
            ii(0x100c_f95c, 5);  call(Definitions.my_dtor_d3, 0x83d2); /* call 0x100d7d33 */
            ii(0x100c_f961, 5);  call(Definitions.sys_delete, 0x9_65fe);/* call 0x10165f64 */
            ii(0x100c_f966, 3);  mov(memd[ss, ebp - 84], eax);         /* mov [ebp-0x54], eax */
            ii(0x100c_f969, 2);  jmp(0x100c_f972, 7); goto l_0x100c_f972;/* jmp 0x100cf972 */
        l_0x100c_f96b:
            ii(0x100c_f96b, 7);  mov(memd[ss, ebp - 84], 0);           /* mov dword [ebp-0x54], 0x0 */
        l_0x100c_f972:
            ii(0x100c_f972, 3);  mov(eax, memd[ss, ebp - 76]);         /* mov eax, [ebp-0x4c] */
            ii(0x100c_f975, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x100c_f978, 3);  mov(memd[ds, edx + 16], eax);         /* mov [edx+0x10], eax */
        l_0x100c_f97b:
            ii(0x100c_f97b, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_f97e, 3);  mov(eax, memd[ds, eax + 36]);         /* mov eax, [eax+0x24] */
            ii(0x100c_f981, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x100c_f984, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_f987, 4);  cmp(memb[ds, eax + 40], 0);           /* cmp byte [eax+0x28], 0x0 */
            ii(0x100c_f98b, 2);  if(jz(0x100c_f9a5, 0x18)) goto l_0x100c_f9a5;/* jz 0x100cf9a5 */
            ii(0x100c_f98d, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_f990, 5);  call(0x100c_e809, -0x118c);           /* call 0x100ce809 */
            ii(0x100c_f995, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100c_f998, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_f99b, 5);  call(0x100c_e850, -0x1150);           /* call 0x100ce850 */
            ii(0x100c_f9a0, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x100c_f9a3, 2);  jmp(0x100c_f9c2, 0x1d); goto l_0x100c_f9c2;/* jmp 0x100cf9c2 */
        l_0x100c_f9a5:
            ii(0x100c_f9a5, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_f9a8, 5);  call(0x100c_e897, -0x1116);           /* call 0x100ce897 */
            ii(0x100c_f9ad, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100c_f9b0, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_f9b3, 5);  call(0x100c_e8e2, -0x10d6);           /* call 0x100ce8e2 */
            ii(0x100c_f9b8, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x100c_f9bb, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_f9be, 4);  or(memb[ds, eax + 36], 8);            /* or byte [eax+0x24], 0x8 */
        l_0x100c_f9c2:
            ii(0x100c_f9c2, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_f9c5, 3);  mov(eax, memd[ds, eax + 28]);         /* mov eax, [eax+0x1c] */
            ii(0x100c_f9c8, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100c_f9cb, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_f9ce, 3);  mov(eax, memd[ds, eax + 32]);         /* mov eax, [eax+0x20] */
            ii(0x100c_f9d1, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100c_f9d4, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_f9d7, 4);  cmp(memd[ds, eax + 41], 0);           /* cmp dword [eax+0x29], 0x0 */
            ii(0x100c_f9db, 2);  if(jnz(0x100c_f9e6, 9)) goto l_0x100c_f9e6;/* jnz 0x100cf9e6 */
            ii(0x100c_f9dd, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_f9e0, 4);  cmp(memd[ds, eax + 45], 0);           /* cmp dword [eax+0x2d], 0x0 */
            ii(0x100c_f9e4, 2);  if(jz(0x100c_f9f2, 0xc)) goto l_0x100c_f9f2;/* jz 0x100cf9f2 */
        l_0x100c_f9e6:
            ii(0x100c_f9e6, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_f9e9, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100c_f9ec, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_f9ef, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
        l_0x100c_f9f2:
            ii(0x100c_f9f2, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x100c_f9f5, 1);  push(eax);                            /* push eax */
            ii(0x100c_f9f6, 2);  push(0);                              /* push 0x0 */
            ii(0x100c_f9f8, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x100c_f9fb, 1);  push(eax);                            /* push eax */
            ii(0x100c_f9fc, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x100c_f9ff, 1);  push(eax);                            /* push eax */
            ii(0x100c_fa00, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100c_fa03, 1);  push(eax);                            /* push eax */
            ii(0x100c_fa04, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100c_fa07, 1);  push(eax);                            /* push eax */
            ii(0x100c_fa08, 2);  push(-1 /* 0xff */);                  /* push 0xffffffff */
            ii(0x100c_fa0a, 2);  push(-1 /* 0xff */);                  /* push 0xffffffff */
            ii(0x100c_fa0c, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_fa0f, 3);  mov(eax, memd[ds, eax + 8]);          /* mov eax, [eax+0x8] */
            ii(0x100c_fa12, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100c_fa15, 1);  push(eax);                            /* push eax */
            ii(0x100c_fa16, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_fa19, 3);  mov(ecx, memd[ds, eax + 6]);          /* mov ecx, [eax+0x6] */
            ii(0x100c_fa1c, 3);  sar(ecx, 0x10);                       /* sar ecx, 0x10 */
            ii(0x100c_fa1f, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_fa22, 3);  mov(ebx, memd[ds, eax + 4]);          /* mov ebx, [eax+0x4] */
            ii(0x100c_fa25, 3);  sar(ebx, 0x10);                       /* sar ebx, 0x10 */
            ii(0x100c_fa28, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_fa2b, 3);  mov(edx, memd[ds, eax + 2]);          /* mov edx, [eax+0x2] */
            ii(0x100c_fa2e, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x100c_fa31, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_fa34, 5);  call(/* sys */ 0x1016_86b0, 0x9_8c77);/* call 0x101686b0 */
            ii(0x100c_fa39, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100c_fa3b, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_fa3e, 2);  mov(memd[ds, eax], edx);              /* mov [eax], edx */
            ii(0x100c_fa40, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_fa43, 4);  cmp(memd[ds, eax + 41], 0);           /* cmp dword [eax+0x29], 0x0 */
            ii(0x100c_fa47, 2);  if(jnz(0x100c_fa52, 9)) goto l_0x100c_fa52;/* jnz 0x100cfa52 */
            ii(0x100c_fa49, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_fa4c, 4);  cmp(memd[ds, eax + 45], 0);           /* cmp dword [eax+0x2d], 0x0 */
            ii(0x100c_fa50, 2);  if(jz(0x100c_fa6b, 0x19)) goto l_0x100c_fa6b;/* jz 0x100cfa6b */
        l_0x100c_fa52:
            ii(0x100c_fa52, 5);  mov(eax, 0x100c_fc5e);                /* mov eax, 0x100cfc5e */
            ii(0x100c_fa57, 1);  push(eax);                            /* push eax */
            ii(0x100c_fa58, 5);  mov(ecx, 0x100c_fbf5);                /* mov ecx, 0x100cfbf5 */
            ii(0x100c_fa5d, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x100c_fa5f, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100c_fa61, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_fa64, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x100c_fa66, 5);  call(/* sys */ 0x1016_8b98, 0x9_912d);/* call 0x10168b98 */
        l_0x100c_fa6b:
            ii(0x100c_fa6b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_fa6e, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x100c_fa71, 3);  mov(memd[ds, edx + 49], eax);         /* mov [edx+0x31], eax */
            ii(0x100c_fa74, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100c_fa76, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100c_fa77, 1);  pop(edi);                             /* pop edi */
            ii(0x100c_fa78, 1);  pop(esi);                             /* pop esi */
            ii(0x100c_fa79, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100c_fa7a, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100c_fa7b, 1);  ret();                                /* ret */
        }
    }
}
