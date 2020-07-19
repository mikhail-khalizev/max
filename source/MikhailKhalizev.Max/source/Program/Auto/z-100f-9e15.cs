using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_9e15-b2408f3b")]
        public void Method_100f_9e15()
        {
            ii(0x100f_9e15, 7);  test(memb[ds, 0x101c_38d4], 3);       /* test byte [0x101c38d4], 0x3 */
            ii(0x100f_9e1c, 6);  if(jnz_func(0x100f_a7df, 0x9bd)) return;/* jnz 0x100fa7df */
            ii(0x100f_9e22, 5);  mov(edx, 0x4ff);                      /* mov edx, 0x4ff */
            ii(0x100f_9e27, 5);  mov(eax, 0x101c_7278);                /* mov eax, 0x101c7278 */
            ii(0x100f_9e2c, 5);  call(0x1013_dc59, 0x4_3e28);          /* call 0x1013dc59 */
            ii(0x100f_9e31, 7);  cmp(memb[ds, 0x101c_391d], 0);        /* cmp byte [0x101c391d], 0x0 */
            ii(0x100f_9e38, 2);  if(jz(0x100f_9e3f, 5)) goto l_0x100f_9e3f;/* jz 0x100f9e3f */
            ii(0x100f_9e3a, 5);  call(0x1011_606c, 0x1_c22d);          /* call 0x1011606c */
        l_0x100f_9e3f:
            ii(0x100f_9e3f, 7);  cmp(memb[ds, 0x101c_391e], 7);        /* cmp byte [0x101c391e], 0x7 */
            ii(0x100f_9e46, 6);  if(jnz(0x100f_9efd, 0xb1)) goto l_0x100f_9efd;/* jnz 0x100f9efd */
            ii(0x100f_9e4c, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x100f_9e4e, 5);  mov(al, memb[ds, 0x101c_37c8]);       /* mov al, [0x101c37c8] */
            ii(0x100f_9e53, 3);  imul(eax, eax, 0x13);                 /* imul eax, eax, 0x13 */
            ii(0x100f_9e56, 7);  mov(dx, memw[ds, 0x101c_3908]);       /* mov dx, [0x101c3908] */
            ii(0x100f_9e5d, 7);  mov(memw[ds, eax + 0x101c_35bc], dx); /* mov [eax+0x101c35bc], dx */
            ii(0x100f_9e64, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x100f_9e66, 5);  mov(al, memb[ds, 0x101c_37c8]);       /* mov al, [0x101c37c8] */
            ii(0x100f_9e6b, 3);  imul(eax, eax, 0x13);                 /* imul eax, eax, 0x13 */
            ii(0x100f_9e6e, 7);  mov(dx, memw[ds, 0x101c_390a]);       /* mov dx, [0x101c390a] */
            ii(0x100f_9e75, 7);  mov(memw[ds, eax + 0x101c_35be], dx); /* mov [eax+0x101c35be], dx */
            ii(0x100f_9e7c, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x100f_9e7e, 5);  mov(al, memb[ds, 0x101c_37c8]);       /* mov al, [0x101c37c8] */
            ii(0x100f_9e83, 6);  imul(eax, eax, 0x247);                /* imul eax, eax, 0x247 */
            ii(0x100f_9e89, 7);  mov(dx, memw[ds, 0x101c_3908]);       /* mov dx, [0x101c3908] */
            ii(0x100f_9e90, 7);  mov(memw[ds, eax + 0x101c_a56c], dx); /* mov [eax+0x101ca56c], dx */
            ii(0x100f_9e97, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x100f_9e99, 5);  mov(al, memb[ds, 0x101c_37c8]);       /* mov al, [0x101c37c8] */
            ii(0x100f_9e9e, 6);  imul(eax, eax, 0x247);                /* imul eax, eax, 0x247 */
            ii(0x100f_9ea4, 7);  mov(dx, memw[ds, 0x101c_390a]);       /* mov dx, [0x101c390a] */
            ii(0x100f_9eab, 7);  mov(memw[ds, eax + 0x101c_a56e], dx); /* mov [eax+0x101ca56e], dx */
            ii(0x100f_9eb2, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x100f_9eb4, 5);  mov(al, memb[ds, 0x101c_37c8]);       /* mov al, [0x101c37c8] */
            ii(0x100f_9eb9, 6);  imul(eax, eax, 0x247);                /* imul eax, eax, 0x247 */
            ii(0x100f_9ebf, 9);  mov(memw[ds, eax + 0x101c_a56a], 0x40);/* mov word [eax+0x101ca56a], 0x40 */
            ii(0x100f_9ec8, 5);  call(0x1012_11ea, 0x2_731d);          /* call 0x101211ea */
            ii(0x100f_9ecd, 2);  cmp(al, 0x14);                        /* cmp al, 0x14 */
            ii(0x100f_9ecf, 2);  if(jnz(0x100f_9ee9, 0x18)) goto l_0x100f_9ee9;/* jnz 0x100f9ee9 */
            ii(0x100f_9ed1, 7);  mov(memb[ds, 0x101c_391e], 0xd);      /* mov byte [0x101c391e], 0xd */
            ii(0x100f_9ed8, 5);  mov(edx, 0x4e6);                      /* mov edx, 0x4e6 */
            ii(0x100f_9edd, 5);  mov(eax, 0x101c_7278);                /* mov eax, 0x101c7278 */
            ii(0x100f_9ee2, 5);  call(0x1013_dc59, 0x4_3d72);          /* call 0x1013dc59 */
            ii(0x100f_9ee7, 2);  jmp(0x100f_9ef8, 0xf); goto l_0x100f_9ef8;/* jmp 0x100f9ef8 */
        l_0x100f_9ee9:
            ii(0x100f_9ee9, 5);  mov(edx, 0x4e4);                      /* mov edx, 0x4e4 */
            ii(0x100f_9eee, 5);  mov(eax, 0x101c_7278);                /* mov eax, 0x101c7278 */
            ii(0x100f_9ef3, 5);  call(0x1013_dc59, 0x4_3d61);          /* call 0x1013dc59 */
        l_0x100f_9ef8:
            ii(0x100f_9ef8, 5);  if(jmp_func(0x100f_a7df, 0x8e2)) return;/* jmp 0x100fa7df */
        l_0x100f_9efd:
            ii(0x100f_9efd, 5);  mov(ecx, 0x40_0000);                  /* mov ecx, 0x400000 */
            ii(0x100f_9f02, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x100f_9f04, 5);  mov(al, memb[ds, 0x101c_37da]);       /* mov al, [0x101c37da] */
            ii(0x100f_9f09, 3);  movsx(ebx, ax);                       /* movsx ebx, ax */
            ii(0x100f_9f0c, 6);  mov(edx, memd[ds, 0x101c_3908]);      /* mov edx, [0x101c3908] */
            ii(0x100f_9f12, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x100f_9f15, 5);  mov(eax, memd[ds, 0x101c_3906]);      /* mov eax, [0x101c3906] */
            ii(0x100f_9f1a, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100f_9f1d, 5);  call(0x1007_388b, -0x8_6697);         /* call 0x1007388b */
            ii(0x100f_9f22, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100f_9f25, 7);  cmp(memb[ds, 0x101c_37d4], 0);        /* cmp byte [0x101c37d4], 0x0 */
            ii(0x100f_9f2c, 6);  if(jz(0x100f_9ffe, 0xcc)) goto l_0x100f_9ffe;/* jz 0x100f9ffe */
            ii(0x100f_9f32, 7);  test(memb[ds, 0x101c_38d4], 0x20);    /* test byte [0x101c38d4], 0x20 */
            ii(0x100f_9f39, 2);  if(jz(0x100f_9f77, 0x3c)) goto l_0x100f_9f77;/* jz 0x100f9f77 */
            ii(0x100f_9f3b, 4);  cmp(memd[ss, ebp - 16], 0);           /* cmp dword [ebp-0x10], 0x0 */
            ii(0x100f_9f3f, 2);  if(jnz(0x100f_9f5a, 0x19)) goto l_0x100f_9f5a;/* jnz 0x100f9f5a */
            ii(0x100f_9f41, 6);  mov(edx, memd[ds, 0x101c_3908]);      /* mov edx, [0x101c3908] */
            ii(0x100f_9f47, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x100f_9f4a, 5);  mov(eax, memd[ds, 0x101c_3906]);      /* mov eax, [0x101c3906] */
            ii(0x100f_9f4f, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100f_9f52, 5);  call(0x1007_3c18, -0x8_633f);         /* call 0x10073c18 */
            ii(0x100f_9f57, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
        l_0x100f_9f5a:
            ii(0x100f_9f5a, 4);  cmp(memd[ss, ebp - 16], 0);           /* cmp dword [ebp-0x10], 0x0 */
            ii(0x100f_9f5e, 2);  if(jz(0x100f_9f72, 0x12)) goto l_0x100f_9f72;/* jz 0x100f9f72 */
            ii(0x100f_9f60, 5);  mov(ebx, 0x1a);                       /* mov ebx, 0x1a */
            ii(0x100f_9f65, 5);  mov(edx, 4);                          /* mov edx, 0x4 */
            ii(0x100f_9f6a, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100f_9f6d, 5);  call(0x1016_3053, 0x6_90e1);          /* call 0x10163053 */
        l_0x100f_9f72:
            ii(0x100f_9f72, 5);  if(jmp_func(0x100f_a7df, 0x868)) return;/* jmp 0x100fa7df */
        l_0x100f_9f77:
            ii(0x100f_9f77, 6);  mov(ebx, memd[ds, 0x101c_3908]);      /* mov ebx, [0x101c3908] */
            ii(0x100f_9f7d, 3);  sar(ebx, 0x10);                       /* sar ebx, 0x10 */
            ii(0x100f_9f80, 6);  mov(edx, memd[ds, 0x101c_3906]);      /* mov edx, [0x101c3906] */
            ii(0x100f_9f86, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x100f_9f89, 5);  mov(eax, 0x101c_37c4);                /* mov eax, 0x101c37c4 */
            ii(0x100f_9f8e, 5);  call(0x1008_abbc, -0x6_f3d7);         /* call 0x1008abbc */
            ii(0x100f_9f93, 5);  call(0x1016_30fa, 0x6_9162);          /* call 0x101630fa */
            ii(0x100f_9f98, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100f_9f9a, 6);  if(jz_func(0x100f_a7df, 0x83f)) return;/* jz 0x100fa7df */
            ii(0x100f_9fa0, 7);  cmp(memd[ds, 0x101c_5624], 0);        /* cmp dword [0x101c5624], 0x0 */
            ii(0x100f_9fa7, 2);  if(jz(0x100f_9fd1, 0x28)) goto l_0x100f_9fd1;/* jz 0x100f9fd1 */
            ii(0x100f_9fa9, 6);  mov(ecx, memd[ds, 0x101c_3908]);      /* mov ecx, [0x101c3908] */
            ii(0x100f_9faf, 3);  sar(ecx, 0x10);                       /* sar ecx, 0x10 */
            ii(0x100f_9fb2, 6);  mov(ebx, memd[ds, 0x101c_3906]);      /* mov ebx, [0x101c3906] */
            ii(0x100f_9fb8, 3);  sar(ebx, 0x10);                       /* sar ebx, 0x10 */
            ii(0x100f_9fbb, 6);  mov(edx, memd[ds, 0x101c_37d4]);      /* mov edx, [0x101c37d4] */
            ii(0x100f_9fc1, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x100f_9fc4, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x100f_9fc6, 5);  mov(al, memb[ds, 0x101c_37da]);       /* mov al, [0x101c37da] */
            ii(0x100f_9fcb, 1);  cwde();                               /* cwde */
            ii(0x100f_9fcc, 5);  call(0x1012_90e7, 0x2_f116);          /* call 0x101290e7 */
        l_0x100f_9fd1:
            ii(0x100f_9fd1, 6);  mov(ecx, memd[ds, 0x101c_3908]);      /* mov ecx, [0x101c3908] */
            ii(0x100f_9fd7, 3);  sar(ecx, 0x10);                       /* sar ecx, 0x10 */
            ii(0x100f_9fda, 6);  mov(ebx, memd[ds, 0x101c_3906]);      /* mov ebx, [0x101c3906] */
            ii(0x100f_9fe0, 3);  sar(ebx, 0x10);                       /* sar ebx, 0x10 */
            ii(0x100f_9fe3, 6);  mov(edx, memd[ds, 0x101c_37d4]);      /* mov edx, [0x101c37d4] */
            ii(0x100f_9fe9, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x100f_9fec, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x100f_9fee, 5);  mov(al, memb[ds, 0x101c_37da]);       /* mov al, [0x101c37da] */
            ii(0x100f_9ff3, 1);  cwde();                               /* cwde */
            ii(0x100f_9ff4, 5);  call(0x1010_2119, 0x8120);            /* call 0x10102119 */
            ii(0x100f_9ff9, 5);  if(jmp_func(0x100f_a7df, 0x7e1)) return;/* jmp 0x100fa7df */
        l_0x100f_9ffe:
            ii(0x100f_9ffe, 5);  mov(ecx, 0x40_0000);                  /* mov ecx, 0x400000 */
            ii(0x100f_a003, 6);  mov(ebx, memd[ds, 0x101c_3908]);      /* mov ebx, [0x101c3908] */
            ii(0x100f_a009, 3);  sar(ebx, 0x10);                       /* sar ebx, 0x10 */
            ii(0x100f_a00c, 6);  mov(edx, memd[ds, 0x101c_3906]);      /* mov edx, [0x101c3906] */
            ii(0x100f_a012, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x100f_a015, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x100f_a017, 5);  mov(al, memb[ds, 0x101c_37da]);       /* mov al, [0x101c37da] */
            ii(0x100f_a01c, 1);  cwde();                               /* cwde */
            ii(0x100f_a01d, 5);  call(0x1007_459a, -0x8_5a88);         /* call 0x1007459a */
            ii(0x100f_a022, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x100f_a025, 7);  test(memb[ds, 0x101c_38d4], 0x20);    /* test byte [0x101c38d4], 0x20 */
            ii(0x100f_a02c, 6);  if(jz(0x100f_a13a, 0x108)) goto l_0x100f_a13a;/* jz 0x100fa13a */
            ii(0x100f_a032, 5);  call(0x100f_40a6, -0x5f91);           /* call 0x100f40a6 */
            ii(0x100f_a037, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100f_a039, 5);  mov(eax, 0x101c_37bc);                /* mov eax, 0x101c37bc */
            ii(0x100f_a03e, 5);  call(0x1013_ad71, 0x4_0d2e);          /* call 0x1013ad71 */
            ii(0x100f_a043, 2);  test(al, al);                         /* test al, al */
            ii(0x100f_a045, 2);  if(jz(0x100f_a06b, 0x24)) goto l_0x100f_a06b;/* jz 0x100fa06b */
            ii(0x100f_a047, 3);  mov(edx, memd[ss, ebp - 16]);         /* mov edx, [ebp-0x10] */
            ii(0x100f_a04a, 5);  mov(eax, 0x101c_37bc);                /* mov eax, 0x101c37bc */
            ii(0x100f_a04f, 5);  call(0x1007_6e00, -0x8_3254);         /* call 0x10076e00 */
            ii(0x100f_a054, 2);  test(al, al);                         /* test al, al */
            ii(0x100f_a056, 2);  if(jnz(0x100f_a069, 0x11)) goto l_0x100f_a069;/* jnz 0x100fa069 */
            ii(0x100f_a058, 3);  mov(edx, memd[ss, ebp - 24]);         /* mov edx, [ebp-0x18] */
            ii(0x100f_a05b, 5);  mov(eax, 0x101c_37bc);                /* mov eax, 0x101c37bc */
            ii(0x100f_a060, 5);  call(0x1007_6e00, -0x8_3265);         /* call 0x10076e00 */
            ii(0x100f_a065, 2);  test(al, al);                         /* test al, al */
            ii(0x100f_a067, 2);  if(jz(0x100f_a06b, 2)) goto l_0x100f_a06b;/* jz 0x100fa06b */
        l_0x100f_a069:
            ii(0x100f_a069, 2);  jmp(0x100f_a06d, 2); goto l_0x100f_a06d;/* jmp 0x100fa06d */
        l_0x100f_a06b:
            ii(0x100f_a06b, 2);  jmp(0x100f_a081, 0x14); goto l_0x100f_a081;/* jmp 0x100fa081 */
        l_0x100f_a06d:
            ii(0x100f_a06d, 5);  mov(eax, 0x101c_37bc);                /* mov eax, 0x101c37bc */
            ii(0x100f_a072, 5);  call(0x1008_abbc, -0x6_f4bb);         /* call 0x1008abbc */
            ii(0x100f_a077, 5);  call(0x1014_0d43, 0x4_6cc7);          /* call 0x10140d43 */
            ii(0x100f_a07c, 5);  jmp(0x100f_a135, 0xb4); goto l_0x100f_a135;/* jmp 0x100fa135 */
        l_0x100f_a081:
            ii(0x100f_a081, 4);  cmp(memd[ss, ebp - 16], 0);           /* cmp dword [ebp-0x10], 0x0 */
            ii(0x100f_a085, 2);  if(jz(0x100f_a094, 0xd)) goto l_0x100f_a094;/* jz 0x100fa094 */
            ii(0x100f_a087, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100f_a08a, 5);  call(0x100f_92fe, -0xd91);            /* call 0x100f92fe */
            ii(0x100f_a08f, 5);  jmp(0x100f_a135, 0xa1); goto l_0x100f_a135;/* jmp 0x100fa135 */
        l_0x100f_a094:
            ii(0x100f_a094, 4);  cmp(memd[ss, ebp - 24], 0);           /* cmp dword [ebp-0x18], 0x0 */
            ii(0x100f_a098, 2);  if(jz(0x100f_a0ec, 0x52)) goto l_0x100f_a0ec;/* jz 0x100fa0ec */
            ii(0x100f_a09a, 7);  cmp(memb[ds, 0x101c_388c], 0);        /* cmp byte [0x101c388c], 0x0 */
            ii(0x100f_a0a1, 2);  if(jz(0x100f_a0c6, 0x23)) goto l_0x100f_a0c6;/* jz 0x100fa0c6 */
            ii(0x100f_a0a3, 3);  mov(edx, memd[ss, ebp - 24]);         /* mov edx, [ebp-0x18] */
            ii(0x100f_a0a6, 5);  mov(eax, 0x101c_3924);                /* mov eax, 0x101c3924 */
            ii(0x100f_a0ab, 5);  call(0x1008_aab4, -0x6_f5fc);         /* call 0x1008aab4 */
            ii(0x100f_a0b0, 2);  test(al, al);                         /* test al, al */
            ii(0x100f_a0b2, 2);  if(jz(0x100f_a0b9, 5)) goto l_0x100f_a0b9;/* jz 0x100fa0b9 */
            ii(0x100f_a0b4, 5);  call(0x100f_f5c1, 0x5508);            /* call 0x100ff5c1 */
        l_0x100f_a0b9:
            ii(0x100f_a0b9, 3);  mov(edx, memd[ss, ebp - 24]);         /* mov edx, [ebp-0x18] */
            ii(0x100f_a0bc, 5);  mov(eax, 0x101c_3924);                /* mov eax, 0x101c3924 */
            ii(0x100f_a0c1, 5);  call(0x1008_ab1c, -0x6_f5aa);         /* call 0x1008ab1c */
        l_0x100f_a0c6:
            ii(0x100f_a0c6, 6);  mov(ecx, memd[ds, 0x101c_3908]);      /* mov ecx, [0x101c3908] */
            ii(0x100f_a0cc, 3);  sar(ecx, 0x10);                       /* sar ecx, 0x10 */
            ii(0x100f_a0cf, 6);  mov(ebx, memd[ds, 0x101c_3906]);      /* mov ebx, [0x101c3906] */
            ii(0x100f_a0d5, 3);  sar(ebx, 0x10);                       /* sar ebx, 0x10 */
            ii(0x100f_a0d8, 3);  mov(edx, memd[ss, ebp - 24]);         /* mov edx, [ebp-0x18] */
            ii(0x100f_a0db, 5);  mov(eax, 0x101c_37bc);                /* mov eax, 0x101c37bc */
            ii(0x100f_a0e0, 5);  call(0x1007_65d0, -0x8_3b15);         /* call 0x100765d0 */
            ii(0x100f_a0e5, 5);  call(0x100f_927b, -0xe6f);            /* call 0x100f927b */
            ii(0x100f_a0ea, 2);  jmp(0x100f_a135, 0x49); goto l_0x100f_a135;/* jmp 0x100fa135 */
        l_0x100f_a0ec:
            ii(0x100f_a0ec, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100f_a0ee, 5);  mov(eax, 0x101c_37bc);                /* mov eax, 0x101c37bc */
            ii(0x100f_a0f3, 5);  call(0x1013_ad71, 0x4_0c79);          /* call 0x1013ad71 */
            ii(0x100f_a0f8, 2);  test(al, al);                         /* test al, al */
            ii(0x100f_a0fa, 2);  if(jz(0x100f_a135, 0x39)) goto l_0x100f_a135;/* jz 0x100fa135 */
            ii(0x100f_a0fc, 5);  mov(eax, 0x101c_37bc);                /* mov eax, 0x101c37bc */
            ii(0x100f_a101, 5);  call(0x1007_6574, -0x8_3b92);         /* call 0x10076574 */
            ii(0x100f_a106, 4);  mov(memb[ds, eax + 85], 0);           /* mov byte [eax+0x55], 0x0 */
            ii(0x100f_a10a, 5);  mov(eax, 0x101c_37bc);                /* mov eax, 0x101c37bc */
            ii(0x100f_a10f, 5);  call(0x1007_6574, -0x8_3ba0);         /* call 0x10076574 */
            ii(0x100f_a114, 4);  mov(memb[ds, eax + 86], 0);           /* mov byte [eax+0x56], 0x0 */
            ii(0x100f_a118, 5);  mov(eax, 0x101c_37bc);                /* mov eax, 0x101c37bc */
            ii(0x100f_a11d, 5);  call(0x1007_6574, -0x8_3bae);         /* call 0x10076574 */
            ii(0x100f_a122, 4);  mov(memb[ds, eax + 87], 0);           /* mov byte [eax+0x57], 0x0 */
            ii(0x100f_a126, 5);  mov(eax, 0x101c_37bc);                /* mov eax, 0x101c37bc */
            ii(0x100f_a12b, 5);  call(0x1007_65d0, -0x8_3b60);         /* call 0x100765d0 */
            ii(0x100f_a130, 5);  call(0x1010_094d, 0x6818);            /* call 0x1010094d */
        l_0x100f_a135:
            ii(0x100f_a135, 5);  if(jmp_func(0x100f_a7df, 0x6a5)) return;/* jmp 0x100fa7df */
        l_0x100f_a13a:
            ii(0x100f_a13a, 5);  call(0x1012_11ea, 0x2_70ab);          /* call 0x101211ea */
            ii(0x100f_a13f, 3);  mov(memb[ss, ebp - 100], al);         /* mov [ebp-0x64], al */
            ii(0x100f_a142, 5);  jmp_func(0x100f_a740, 0x5f9);         /* jmp 0x100fa740 */
        }
    }
}
