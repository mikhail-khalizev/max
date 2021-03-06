using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_1f13-ec85e107")]
        public void Method_1009_1f13()
        {
            ii(0x1009_1f13, 5);  push(0x5c);                           /* push 0x5c */
            ii(0x1009_1f18, 5);  call(Definitions.sys_check_available_stack_size, 0xd_3e35);/* call 0x10165d52 */
            ii(0x1009_1f1d, 1);  push(ecx);                            /* push ecx */
            ii(0x1009_1f1e, 1);  push(esi);                            /* push esi */
            ii(0x1009_1f1f, 1);  push(edi);                            /* push edi */
            ii(0x1009_1f20, 1);  push(ebp);                            /* push ebp */
            ii(0x1009_1f21, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1009_1f23, 6);  sub(esp, 0x40);                       /* sub esp, 0x40 */
            ii(0x1009_1f29, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1009_1f2c, 3);  mov(memd[ss, ebp - 12], edx);         /* mov [ebp-0xc], edx */
            ii(0x1009_1f2f, 3);  mov(memd[ss, ebp - 8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x1009_1f32, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1009_1f35, 5);  call(Definitions.my_ctor_0x101b_4184, -0x1_b44a);/* call 0x10076af0 */
            ii(0x1009_1f3a, 4);  mov(memb[ss, ebp - 16], 1);           /* mov byte [ebp-0x10], 0x1 */
            ii(0x1009_1f3e, 4);  movsx(edx, memw[ss, ebp + 40]);       /* movsx edx, word [ebp+0x28] */
            ii(0x1009_1f42, 3);  mov(eax, memd[ss, ebp + 20]);         /* mov eax, [ebp+0x14] */
            ii(0x1009_1f45, 2);  sub(eax, edx);                        /* sub eax, edx */
            ii(0x1009_1f47, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1009_1f49, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1009_1f4b, 5);  call(0x1007_6e7c, -0x1_b0d4);         /* call 0x10076e7c */
            ii(0x1009_1f50, 3);  mov(memd[ss, ebp - 36], eax);         /* mov [ebp-0x24], eax */
            ii(0x1009_1f53, 4);  movsx(edx, memw[ss, ebp + 40]);       /* movsx edx, word [ebp+0x28] */
            ii(0x1009_1f57, 3);  mov(eax, memd[ss, ebp + 24]);         /* mov eax, [ebp+0x18] */
            ii(0x1009_1f5a, 2);  sub(eax, edx);                        /* sub eax, edx */
            ii(0x1009_1f5c, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1009_1f5e, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1009_1f60, 5);  call(0x1007_6e7c, -0x1_b0e9);         /* call 0x10076e7c */
            ii(0x1009_1f65, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x1009_1f68, 6);  mov(edx, memd[ds, 0x101c_8170]);      /* mov edx, [0x101c8170] */
            ii(0x1009_1f6e, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1009_1f71, 3);  mov(eax, memd[ss, ebp + 28]);         /* mov eax, [ebp+0x1c] */
            ii(0x1009_1f74, 1);  inc(eax);                             /* inc eax */
            ii(0x1009_1f75, 5);  call(Definitions.my_min, -0x87f6);    /* call 0x10089784 */
            ii(0x1009_1f7a, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1009_1f7d, 6);  mov(edx, memd[ds, 0x101c_8172]);      /* mov edx, [0x101c8172] */
            ii(0x1009_1f83, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1009_1f86, 3);  mov(eax, memd[ss, ebp + 32]);         /* mov eax, [ebp+0x20] */
            ii(0x1009_1f89, 1);  inc(eax);                             /* inc eax */
            ii(0x1009_1f8a, 5);  call(Definitions.my_min, -0x880b);    /* call 0x10089784 */
            ii(0x1009_1f8f, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x1009_1f92, 3);  mov(eax, memd[ss, ebp - 36]);         /* mov eax, [ebp-0x24] */
            ii(0x1009_1f95, 3);  mov(memd[ss, ebp - 40], eax);         /* mov [ebp-0x28], eax */
            ii(0x1009_1f98, 2);  jmp(0x1009_1fa0, 6); goto l_0x1009_1fa0;/* jmp 0x10091fa0 */
        l_0x1009_1f9a:
            ii(0x1009_1f9a, 3);  mov(eax, memd[ss, ebp - 40]);         /* mov eax, [ebp-0x28] */
            ii(0x1009_1f9d, 3);  inc(memd[ss, ebp - 40]);              /* inc dword [ebp-0x28] */
        l_0x1009_1fa0:
            ii(0x1009_1fa0, 4);  movsx(eax, memw[ss, ebp - 40]);       /* movsx eax, word [ebp-0x28] */
            ii(0x1009_1fa4, 3);  cmp(eax, memd[ss, ebp - 28]);         /* cmp eax, [ebp-0x1c] */
            ii(0x1009_1fa7, 6);  if(jge(0x1009_2130, 0x183)) goto l_0x1009_2130;/* jge 0x10092130 */
            ii(0x1009_1fad, 3);  mov(eax, memd[ss, ebp - 32]);         /* mov eax, [ebp-0x20] */
            ii(0x1009_1fb0, 3);  mov(memd[ss, ebp - 44], eax);         /* mov [ebp-0x2c], eax */
            ii(0x1009_1fb3, 2);  jmp(0x1009_1fbb, 6); goto l_0x1009_1fbb;/* jmp 0x10091fbb */
        l_0x1009_1fb5:
            ii(0x1009_1fb5, 3);  mov(eax, memd[ss, ebp - 44]);         /* mov eax, [ebp-0x2c] */
            ii(0x1009_1fb8, 3);  inc(memd[ss, ebp - 44]);              /* inc dword [ebp-0x2c] */
        l_0x1009_1fbb:
            ii(0x1009_1fbb, 4);  movsx(eax, memw[ss, ebp - 44]);       /* movsx eax, word [ebp-0x2c] */
            ii(0x1009_1fbf, 3);  cmp(eax, memd[ss, ebp - 24]);         /* cmp eax, [ebp-0x18] */
            ii(0x1009_1fc2, 6);  if(jge(0x1009_212b, 0x163)) goto l_0x1009_212b;/* jge 0x1009212b */
            ii(0x1009_1fc8, 4);  movsx(eax, memw[ss, ebp - 40]);       /* movsx eax, word [ebp-0x28] */
            ii(0x1009_1fcc, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1009_1fcf, 3);  add(eax, memd[ss, ebp - 12]);         /* add eax, [ebp-0xc] */
            ii(0x1009_1fd2, 4);  movsx(edx, memw[ss, ebp - 44]);       /* movsx edx, word [ebp-0x2c] */
            ii(0x1009_1fd6, 2);  add(edx, edx);                        /* add edx, edx */
            ii(0x1009_1fd8, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1009_1fda, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1009_1fdc, 3);  movsx(eax, memw[ds, eax]);            /* movsx eax, word [eax] */
            ii(0x1009_1fdf, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1009_1fe1, 6);  if(jnz(0x1009_2126, 0x13f)) goto l_0x1009_2126;/* jnz 0x10092126 */
            ii(0x1009_1fe7, 4);  movsx(edx, memw[ss, ebp - 40]);       /* movsx edx, word [ebp-0x28] */
            ii(0x1009_1feb, 1);  dec(edx);                             /* dec edx */
            ii(0x1009_1fec, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1009_1fee, 5);  call(0x1007_6e7c, -0x1_b177);         /* call 0x10076e7c */
            ii(0x1009_1ff3, 3);  mov(memd[ss, ebp - 60], eax);         /* mov [ebp-0x3c], eax */
            ii(0x1009_1ff6, 4);  movsx(edx, memw[ss, ebp - 44]);       /* movsx edx, word [ebp-0x2c] */
            ii(0x1009_1ffa, 1);  dec(edx);                             /* dec edx */
            ii(0x1009_1ffb, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1009_1ffd, 5);  call(0x1007_6e7c, -0x1_b186);         /* call 0x10076e7c */
            ii(0x1009_2002, 3);  mov(memd[ss, ebp - 56], eax);         /* mov [ebp-0x38], eax */
            ii(0x1009_2005, 6);  mov(edx, memd[ds, 0x101c_8170]);      /* mov edx, [0x101c8170] */
            ii(0x1009_200b, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1009_200e, 4);  movsx(ebx, memw[ss, ebp - 40]);       /* movsx ebx, word [ebp-0x28] */
            ii(0x1009_2012, 4);  movsx(eax, memw[ss, ebp + 40]);       /* movsx eax, word [ebp+0x28] */
            ii(0x1009_2016, 2);  add(eax, ebx);                        /* add eax, ebx */
            ii(0x1009_2018, 1);  inc(eax);                             /* inc eax */
            ii(0x1009_2019, 5);  call(Definitions.my_min, -0x889a);    /* call 0x10089784 */
            ii(0x1009_201e, 3);  mov(memd[ss, ebp - 52], eax);         /* mov [ebp-0x34], eax */
            ii(0x1009_2021, 6);  mov(edx, memd[ds, 0x101c_8172]);      /* mov edx, [0x101c8172] */
            ii(0x1009_2027, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1009_202a, 4);  movsx(ebx, memw[ss, ebp - 44]);       /* movsx ebx, word [ebp-0x2c] */
            ii(0x1009_202e, 4);  movsx(eax, memw[ss, ebp + 40]);       /* movsx eax, word [ebp+0x28] */
            ii(0x1009_2032, 2);  add(eax, ebx);                        /* add eax, ebx */
            ii(0x1009_2034, 1);  inc(eax);                             /* inc eax */
            ii(0x1009_2035, 5);  call(Definitions.my_min, -0x88b6);    /* call 0x10089784 */
            ii(0x1009_203a, 3);  mov(memd[ss, ebp - 48], eax);         /* mov [ebp-0x30], eax */
            ii(0x1009_203d, 4);  mov(memb[ss, ebp - 16], 0);           /* mov byte [ebp-0x10], 0x0 */
            ii(0x1009_2041, 3);  mov(eax, memd[ss, ebp - 60]);         /* mov eax, [ebp-0x3c] */
            ii(0x1009_2044, 4);  mov(memw[ss, ebp - 20], ax);          /* mov [ebp-0x14], ax */
            ii(0x1009_2048, 2);  jmp(0x1009_2051, 7); goto l_0x1009_2051;/* jmp 0x10092051 */
        l_0x1009_204a:
            ii(0x1009_204a, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1009_204d, 4);  inc(memw[ss, ebp - 20]);              /* inc word [ebp-0x14] */
        l_0x1009_2051:
            ii(0x1009_2051, 4);  movsx(eax, memw[ss, ebp - 20]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1009_2055, 3);  cmp(eax, memd[ss, ebp - 52]);         /* cmp eax, [ebp-0x34] */
            ii(0x1009_2058, 2);  if(jge(0x1009_2098, 0x3e)) goto l_0x1009_2098;/* jge 0x10092098 */
            ii(0x1009_205a, 3);  mov(eax, memd[ss, ebp - 56]);         /* mov eax, [ebp-0x38] */
            ii(0x1009_205d, 4);  mov(memw[ss, ebp - 18], ax);          /* mov [ebp-0x12], ax */
            ii(0x1009_2061, 2);  jmp(0x1009_206a, 7); goto l_0x1009_206a;/* jmp 0x1009206a */
        l_0x1009_2063:
            ii(0x1009_2063, 3);  mov(eax, memd[ss, ebp - 18]);         /* mov eax, [ebp-0x12] */
            ii(0x1009_2066, 4);  inc(memw[ss, ebp - 18]);              /* inc word [ebp-0x12] */
        l_0x1009_206a:
            ii(0x1009_206a, 4);  movsx(eax, memw[ss, ebp - 18]);       /* movsx eax, word [ebp-0x12] */
            ii(0x1009_206e, 3);  cmp(eax, memd[ss, ebp - 48]);         /* cmp eax, [ebp-0x30] */
            ii(0x1009_2071, 2);  if(jge(0x1009_2096, 0x23)) goto l_0x1009_2096;/* jge 0x10092096 */
            ii(0x1009_2073, 4);  movsx(eax, memw[ss, ebp - 20]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1009_2077, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1009_207a, 3);  add(eax, memd[ss, ebp - 12]);         /* add eax, [ebp-0xc] */
            ii(0x1009_207d, 4);  movsx(edx, memw[ss, ebp - 18]);       /* movsx edx, word [ebp-0x12] */
            ii(0x1009_2081, 2);  add(edx, edx);                        /* add edx, edx */
            ii(0x1009_2083, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1009_2085, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1009_2087, 3);  mov(ax, memw[ds, eax]);               /* mov ax, [eax] */
            ii(0x1009_208a, 4);  cmp(ax, memw[ss, ebp + 36]);          /* cmp ax, [ebp+0x24] */
            ii(0x1009_208e, 2);  if(jnz(0x1009_2094, 4)) goto l_0x1009_2094;/* jnz 0x10092094 */
            ii(0x1009_2090, 4);  mov(memb[ss, ebp - 16], 1);           /* mov byte [ebp-0x10], 0x1 */
        l_0x1009_2094:
            ii(0x1009_2094, 2);  jmp(0x1009_2063, -0x33); goto l_0x1009_2063;/* jmp 0x10092063 */
        l_0x1009_2096:
            ii(0x1009_2096, 2);  jmp(0x1009_204a, -0x4e); goto l_0x1009_204a;/* jmp 0x1009204a */
        l_0x1009_2098:
            ii(0x1009_2098, 4);  cmp(memb[ss, ebp - 16], 0);           /* cmp byte [ebp-0x10], 0x0 */
            ii(0x1009_209c, 6);  if(jz(0x1009_2126, 0x84)) goto l_0x1009_2126;/* jz 0x10092126 */
            ii(0x1009_20a2, 4);  movsx(eax, memw[ss, ebp - 40]);       /* movsx eax, word [ebp-0x28] */
            ii(0x1009_20a6, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1009_20a9, 3);  add(eax, memd[ss, ebp - 8]);          /* add eax, [ebp-0x8] */
            ii(0x1009_20ac, 4);  movsx(edx, memw[ss, ebp - 44]);       /* movsx edx, word [ebp-0x2c] */
            ii(0x1009_20b0, 3);  shl(edx, 2);                          /* shl edx, 0x2 */
            ii(0x1009_20b3, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1009_20b5, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1009_20b7, 3);  mov(memd[ss, ebp - 64], eax);         /* mov [ebp-0x40], eax */
            ii(0x1009_20ba, 3);  mov(eax, memd[ss, ebp - 64]);         /* mov eax, [ebp-0x40] */
            ii(0x1009_20bd, 1);  inc(eax);                             /* inc eax */
            ii(0x1009_20be, 1);  push(eax);                            /* push eax */
            ii(0x1009_20bf, 3);  mov(eax, memd[ss, ebp - 64]);         /* mov eax, [ebp-0x40] */
            ii(0x1009_20c2, 1);  push(eax);                            /* push eax */
            ii(0x1009_20c3, 4);  movsx(ecx, memw[ss, ebp + 28]);       /* movsx ecx, word [ebp+0x1c] */
            ii(0x1009_20c7, 4);  movsx(ebx, memw[ss, ebp + 20]);       /* movsx ebx, word [ebp+0x14] */
            ii(0x1009_20cb, 3);  mov(eax, memd[ss, ebp - 40]);         /* mov eax, [ebp-0x28] */
            ii(0x1009_20ce, 3);  add(eax, memd[ss, ebp + 40]);         /* add eax, [ebp+0x28] */
            ii(0x1009_20d1, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x1009_20d4, 4);  movsx(eax, memw[ss, ebp - 40]);       /* movsx eax, word [ebp-0x28] */
            ii(0x1009_20d8, 5);  call(0x1009_1e5a, -0x283);            /* call 0x10091e5a */
            ii(0x1009_20dd, 2);  test(al, al);                         /* test al, al */
            ii(0x1009_20df, 2);  if(jz(0x1009_210d, 0x2c)) goto l_0x1009_210d;/* jz 0x1009210d */
            ii(0x1009_20e1, 3);  mov(eax, memd[ss, ebp - 64]);         /* mov eax, [ebp-0x40] */
            ii(0x1009_20e4, 3);  add(eax, 3);                          /* add eax, 0x3 */
            ii(0x1009_20e7, 1);  push(eax);                            /* push eax */
            ii(0x1009_20e8, 3);  mov(eax, memd[ss, ebp - 64]);         /* mov eax, [ebp-0x40] */
            ii(0x1009_20eb, 3);  add(eax, 2);                          /* add eax, 0x2 */
            ii(0x1009_20ee, 1);  push(eax);                            /* push eax */
            ii(0x1009_20ef, 4);  movsx(ecx, memw[ss, ebp + 32]);       /* movsx ecx, word [ebp+0x20] */
            ii(0x1009_20f3, 4);  movsx(ebx, memw[ss, ebp + 24]);       /* movsx ebx, word [ebp+0x18] */
            ii(0x1009_20f7, 3);  mov(eax, memd[ss, ebp - 44]);         /* mov eax, [ebp-0x2c] */
            ii(0x1009_20fa, 3);  add(eax, memd[ss, ebp + 40]);         /* add eax, [ebp+0x28] */
            ii(0x1009_20fd, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x1009_2100, 4);  movsx(eax, memw[ss, ebp - 44]);       /* movsx eax, word [ebp-0x2c] */
            ii(0x1009_2104, 5);  call(0x1009_1e5a, -0x2af);            /* call 0x10091e5a */
            ii(0x1009_2109, 2);  test(al, al);                         /* test al, al */
            ii(0x1009_210b, 2);  if(jnz(0x1009_2126, 0x19)) goto l_0x1009_2126;/* jnz 0x10092126 */
        l_0x1009_210d:
            ii(0x1009_210d, 4);  movsx(eax, memw[ss, ebp - 40]);       /* movsx eax, word [ebp-0x28] */
            ii(0x1009_2111, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1009_2114, 3);  add(eax, memd[ss, ebp - 12]);         /* add eax, [ebp-0xc] */
            ii(0x1009_2117, 4);  movsx(edx, memw[ss, ebp - 44]);       /* movsx edx, word [ebp-0x2c] */
            ii(0x1009_211b, 2);  add(edx, edx);                        /* add edx, edx */
            ii(0x1009_211d, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1009_211f, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1009_2121, 5);  mov(memw[ds, eax], 5);                /* mov word [eax], 0x5 */
        l_0x1009_2126:
            ii(0x1009_2126, 5);  jmp(0x1009_1fb5, -0x176); goto l_0x1009_1fb5;/* jmp 0x10091fb5 */
        l_0x1009_212b:
            ii(0x1009_212b, 5);  jmp(0x1009_1f9a, -0x196); goto l_0x1009_1f9a;/* jmp 0x10091f9a */
        l_0x1009_2130:
            ii(0x1009_2130, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1009_2132, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1009_2133, 1);  pop(edi);                             /* pop edi */
            ii(0x1009_2134, 1);  pop(esi);                             /* pop esi */
            ii(0x1009_2135, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1009_2136, 3);  ret(0x18);                            /* ret 0x18 */
        }
    }
}
