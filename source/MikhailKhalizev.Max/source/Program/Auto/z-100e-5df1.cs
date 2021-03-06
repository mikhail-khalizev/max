using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_5df1-5cc85439")]
        public void Method_100e_5df1()
        {
            ii(0x100e_5df1, 5);  push(0x28);                           /* push 0x28 */
            ii(0x100e_5df6, 5);  call(Definitions.sys_check_available_stack_size, 0x7_ff57);/* call 0x10165d52 */
            ii(0x100e_5dfb, 1);  push(ebx);                            /* push ebx */
            ii(0x100e_5dfc, 1);  push(ecx);                            /* push ecx */
            ii(0x100e_5dfd, 1);  push(edx);                            /* push edx */
            ii(0x100e_5dfe, 1);  push(esi);                            /* push esi */
            ii(0x100e_5dff, 1);  push(edi);                            /* push edi */
            ii(0x100e_5e00, 1);  push(ebp);                            /* push ebp */
            ii(0x100e_5e01, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100e_5e03, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x100e_5e09, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100e_5e0c, 5);  mov(edx, 0x101c_8178);                /* mov edx, 0x101c8178 */
            ii(0x100e_5e11, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_5e14, 5);  call(0x100e_5d67, -0xb2);             /* call 0x100e5d67 */
            ii(0x100e_5e19, 5);  mov(edx, 0x101c_8184);                /* mov edx, 0x101c8184 */
            ii(0x100e_5e1e, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_5e21, 5);  call(0x100e_5d67, -0xbf);             /* call 0x100e5d67 */
            ii(0x100e_5e26, 5);  mov(edx, 0x101c_819c);                /* mov edx, 0x101c819c */
            ii(0x100e_5e2b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_5e2e, 5);  call(0x100e_5d67, -0xcc);             /* call 0x100e5d67 */
            ii(0x100e_5e33, 5);  mov(eax, 0x101c_81a8);                /* mov eax, 0x101c81a8 */
            ii(0x100e_5e38, 5);  call(0x1007_6338, -0x6_fb05);         /* call 0x10076338 */
            ii(0x100e_5e3d, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100e_5e3f, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x100e_5e42, 5);  call(0x1007_64b8, -0x6_f98f);         /* call 0x100764b8 */
            ii(0x100e_5e47, 2);  jmp(0x100e_5e51, 8); goto l_0x100e_5e51;/* jmp 0x100e5e51 */
        l_0x100e_5e49:
            ii(0x100e_5e49, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x100e_5e4c, 5);  call(0x1007_6bf8, -0x6_f259);         /* call 0x10076bf8 */
        l_0x100e_5e51:
            ii(0x100e_5e51, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100e_5e53, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x100e_5e56, 5);  call(0x1013_ad71, 0x5_4f16);          /* call 0x1013ad71 */
            ii(0x100e_5e5b, 2);  test(al, al);                         /* test al, al */
            ii(0x100e_5e5d, 2);  if(jz(0x100e_5ea9, 0x4a)) goto l_0x100e_5ea9;/* jz 0x100e5ea9 */
            ii(0x100e_5e5f, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100e_5e62, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x100e_5e65, 5);  call(0x1007_63d4, -0x6_fa96);         /* call 0x100763d4 */
            ii(0x100e_5e6a, 5);  call(0x100e_5408, -0xa67);            /* call 0x100e5408 */
            ii(0x100e_5e6f, 2);  test(al, al);                         /* test al, al */
            ii(0x100e_5e71, 2);  if(jz(0x100e_5ea7, 0x34)) goto l_0x100e_5ea7;/* jz 0x100e5ea7 */
            ii(0x100e_5e73, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x100e_5e76, 5);  call(0x1007_63d4, -0x6_faa7);         /* call 0x100763d4 */
            ii(0x100e_5e7b, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100e_5e7d, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_5e80, 5);  call(0x100e_718a, 0x1305);            /* call 0x100e718a */
            ii(0x100e_5e85, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x100e_5e88, 5);  call(0x1007_63a0, -0x6_faed);         /* call 0x100763a0 */
            ii(0x100e_5e8d, 4);  test(memb[ds, eax + 20], 1);          /* test byte [eax+0x14], 0x1 */
            ii(0x100e_5e91, 2);  if(jnz(0x100e_5ea7, 0x14)) goto l_0x100e_5ea7;/* jnz 0x100e5ea7 */
            ii(0x100e_5e93, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x100e_5e95, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x100e_5e98, 5);  call(0x1007_63d4, -0x6_fac9);         /* call 0x100763d4 */
            ii(0x100e_5e9d, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100e_5e9f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_5ea2, 5);  call(0x100e_71bd, 0x1316);            /* call 0x100e71bd */
        l_0x100e_5ea7:
            ii(0x100e_5ea7, 2);  jmp(0x100e_5e49, -0x60); goto l_0x100e_5e49;/* jmp 0x100e5e49 */
        l_0x100e_5ea9:
            ii(0x100e_5ea9, 5);  mov(eax, 0x101c_8190);                /* mov eax, 0x101c8190 */
            ii(0x100e_5eae, 5);  call(0x1007_6338, -0x6_fb7b);         /* call 0x10076338 */
            ii(0x100e_5eb3, 3);  lea(ebx, memd[ss, ebp - 8]);          /* lea ebx, [ebp-0x8] */
            ii(0x100e_5eb6, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100e_5eb8, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x100e_5eba, 5);  call(0x1007_64b8, -0x6_fa07);         /* call 0x100764b8 */
            ii(0x100e_5ebf, 2);  jmp(0x100e_5ec9, 8); goto l_0x100e_5ec9;/* jmp 0x100e5ec9 */
        l_0x100e_5ec1:
            ii(0x100e_5ec1, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x100e_5ec4, 5);  call(0x1007_6bf8, -0x6_f2d1);         /* call 0x10076bf8 */
        l_0x100e_5ec9:
            ii(0x100e_5ec9, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100e_5ecb, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x100e_5ece, 5);  call(0x1013_ad71, 0x5_4e9e);          /* call 0x1013ad71 */
            ii(0x100e_5ed3, 2);  test(al, al);                         /* test al, al */
            ii(0x100e_5ed5, 2);  if(jz(0x100e_5ef6, 0x1f)) goto l_0x100e_5ef6;/* jz 0x100e5ef6 */
            ii(0x100e_5ed7, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x100e_5eda, 5);  call(0x1007_63a0, -0x6_fb3f);         /* call 0x100763a0 */
            ii(0x100e_5edf, 4);  test(memb[ds, eax + 18], 2);          /* test byte [eax+0x12], 0x2 */
            ii(0x100e_5ee3, 2);  if(jz(0x100e_5ef4, 0xf)) goto l_0x100e_5ef4;/* jz 0x100e5ef4 */
            ii(0x100e_5ee5, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x100e_5ee8, 5);  call(0x1007_63a0, -0x6_fb4d);         /* call 0x100763a0 */
            ii(0x100e_5eed, 5);  cmp(memw[ds, eax + 8], 0x59);         /* cmp word [eax+0x8], 0x59 */
            ii(0x100e_5ef2, 2);  if(jnz(0x100e_5ef6, 2)) goto l_0x100e_5ef6;/* jnz 0x100e5ef6 */
        l_0x100e_5ef4:
            ii(0x100e_5ef4, 2);  jmp(0x100e_5ef8, 2); goto l_0x100e_5ef8;/* jmp 0x100e5ef8 */
        l_0x100e_5ef6:
            ii(0x100e_5ef6, 2);  jmp(0x100e_5f22, 0x2a); goto l_0x100e_5f22;/* jmp 0x100e5f22 */
        l_0x100e_5ef8:
            ii(0x100e_5ef8, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100e_5efb, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x100e_5efe, 5);  call(0x1007_63d4, -0x6_fb2f);         /* call 0x100763d4 */
            ii(0x100e_5f03, 5);  call(0x100e_5408, -0xb00);            /* call 0x100e5408 */
            ii(0x100e_5f08, 2);  test(al, al);                         /* test al, al */
            ii(0x100e_5f0a, 2);  if(jz(0x100e_5f20, 0x14)) goto l_0x100e_5f20;/* jz 0x100e5f20 */
            ii(0x100e_5f0c, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x100e_5f0e, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x100e_5f11, 5);  call(0x1007_63d4, -0x6_fb42);         /* call 0x100763d4 */
            ii(0x100e_5f16, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100e_5f18, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_5f1b, 5);  call(0x100e_71bd, 0x129d);            /* call 0x100e71bd */
        l_0x100e_5f20:
            ii(0x100e_5f20, 2);  jmp(0x100e_5ec1, -0x61); goto l_0x100e_5ec1;/* jmp 0x100e5ec1 */
        l_0x100e_5f22:
            ii(0x100e_5f22, 5);  mov(eax, 0x101c_81a8);                /* mov eax, 0x101c81a8 */
            ii(0x100e_5f27, 5);  call(0x1007_6338, -0x6_fbf4);         /* call 0x10076338 */
            ii(0x100e_5f2c, 3);  lea(ebx, memd[ss, ebp - 12]);         /* lea ebx, [ebp-0xc] */
            ii(0x100e_5f2f, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100e_5f31, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x100e_5f33, 5);  call(0x1007_643c, -0x6_fafc);         /* call 0x1007643c */
            ii(0x100e_5f38, 2);  jmp(0x100e_5f42, 8); goto l_0x100e_5f42;/* jmp 0x100e5f42 */
        l_0x100e_5f3a:
            ii(0x100e_5f3a, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x100e_5f3d, 5);  call(0x1007_6bf8, -0x6_f34a);         /* call 0x10076bf8 */
        l_0x100e_5f42:
            ii(0x100e_5f42, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100e_5f44, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x100e_5f47, 5);  call(0x1013_ad71, 0x5_4e25);          /* call 0x1013ad71 */
            ii(0x100e_5f4c, 2);  test(al, al);                         /* test al, al */
            ii(0x100e_5f4e, 2);  if(jz(0x100e_5f88, 0x38)) goto l_0x100e_5f88;/* jz 0x100e5f88 */
            ii(0x100e_5f50, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x100e_5f53, 5);  call(0x1007_63a0, -0x6_fbb8);         /* call 0x100763a0 */
            ii(0x100e_5f58, 4);  test(memb[ds, eax + 20], 1);          /* test byte [eax+0x14], 0x1 */
            ii(0x100e_5f5c, 2);  if(jz(0x100e_5f86, 0x28)) goto l_0x100e_5f86;/* jz 0x100e5f86 */
            ii(0x100e_5f5e, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100e_5f61, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x100e_5f64, 5);  call(0x1007_63d4, -0x6_fb95);         /* call 0x100763d4 */
            ii(0x100e_5f69, 5);  call(0x100e_5408, -0xb66);            /* call 0x100e5408 */
            ii(0x100e_5f6e, 2);  test(al, al);                         /* test al, al */
            ii(0x100e_5f70, 2);  if(jz(0x100e_5f86, 0x14)) goto l_0x100e_5f86;/* jz 0x100e5f86 */
            ii(0x100e_5f72, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x100e_5f74, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x100e_5f77, 5);  call(0x1007_63d4, -0x6_fba8);         /* call 0x100763d4 */
            ii(0x100e_5f7c, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100e_5f7e, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_5f81, 5);  call(0x100e_71bd, 0x1237);            /* call 0x100e71bd */
        l_0x100e_5f86:
            ii(0x100e_5f86, 2);  jmp(0x100e_5f3a, -0x4e); goto l_0x100e_5f3a;/* jmp 0x100e5f3a */
        l_0x100e_5f88:
            ii(0x100e_5f88, 2);  jmp(0x100e_5f92, 8); goto l_0x100e_5f92;/* jmp 0x100e5f92 */
        l_0x100e_5f8a:
            ii(0x100e_5f8a, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x100e_5f8d, 5);  call(0x1007_6bf8, -0x6_f39a);         /* call 0x10076bf8 */
        l_0x100e_5f92:
            ii(0x100e_5f92, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100e_5f94, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x100e_5f97, 5);  call(0x1013_ad71, 0x5_4dd5);          /* call 0x1013ad71 */
            ii(0x100e_5f9c, 2);  test(al, al);                         /* test al, al */
            ii(0x100e_5f9e, 2);  if(jz(0x100e_5fca, 0x2a)) goto l_0x100e_5fca;/* jz 0x100e5fca */
            ii(0x100e_5fa0, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100e_5fa3, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x100e_5fa6, 5);  call(0x1007_63d4, -0x6_fbd7);         /* call 0x100763d4 */
            ii(0x100e_5fab, 5);  call(0x100e_5408, -0xba8);            /* call 0x100e5408 */
            ii(0x100e_5fb0, 2);  test(al, al);                         /* test al, al */
            ii(0x100e_5fb2, 2);  if(jz(0x100e_5fc8, 0x14)) goto l_0x100e_5fc8;/* jz 0x100e5fc8 */
            ii(0x100e_5fb4, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x100e_5fb6, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x100e_5fb9, 5);  call(0x1007_63d4, -0x6_fbea);         /* call 0x100763d4 */
            ii(0x100e_5fbe, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100e_5fc0, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_5fc3, 5);  call(0x100e_71bd, 0x11f5);            /* call 0x100e71bd */
        l_0x100e_5fc8:
            ii(0x100e_5fc8, 2);  jmp(0x100e_5f8a, -0x40); goto l_0x100e_5f8a;/* jmp 0x100e5f8a */
        l_0x100e_5fca:
            ii(0x100e_5fca, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100e_5fcc, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x100e_5fcf, 5);  call(0x1007_5f6c, -0x7_0068);         /* call 0x10075f6c */
            ii(0x100e_5fd4, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100e_5fd6, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x100e_5fd9, 5);  call(0x1007_5f6c, -0x7_0072);         /* call 0x10075f6c */
            ii(0x100e_5fde, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100e_5fe0, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100e_5fe1, 1);  pop(edi);                             /* pop edi */
            ii(0x100e_5fe2, 1);  pop(esi);                             /* pop esi */
            ii(0x100e_5fe3, 1);  pop(edx);                             /* pop edx */
            ii(0x100e_5fe4, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100e_5fe5, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100e_5fe6, 1);  ret();                                /* ret */
        }
    }
}
