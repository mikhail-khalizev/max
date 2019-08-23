using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_49cc-8da95219")]
        public void /* sys */ Method_1017_49cc()
        {
            ii(0x1017_49cc, 1); push(ebx);                              /* push ebx */
            ii(0x1017_49cd, 1); push(ecx);                              /* push ecx */
            ii(0x1017_49ce, 1); push(edx);                              /* push edx */
            ii(0x1017_49cf, 1); push(esi);                              /* push esi */
            ii(0x1017_49d0, 1); push(edi);                              /* push edi */
            ii(0x1017_49d1, 1); push(ebp);                              /* push ebp */
            ii(0x1017_49d2, 5); mov(ebx, 0xa00);                        /* mov ebx, 0xa00 */
            ii(0x1017_49d7, 5); mov(edx, 0xffff_ffff);                  /* mov edx, 0xffffffff */
            ii(0x1017_49dc, 5); mov(eax, 0x1020_8a40);                  /* mov eax, 0x10208a40 */
            ii(0x1017_49e1, 5); mov(esi, 0x15e);                        /* mov esi, 0x15e */
            ii(0x1017_49e6, 5); mov(edi, 0x13c);                        /* mov edi, 0x13c */
            ii(0x1017_49eb, 5); mov(ecx, 0x15f);                        /* mov ecx, 0x15f */
            ii(0x1017_49f0, 5); call(Definitions.sys_memset, -0xec15);  /* call 0x10165de0 */
            ii(0x1017_49f5, 5); mov(edx, 0x1b);                         /* mov edx, 0x1b */
            ii(0x1017_49fa, 5); mov(eax, 0x13b);                        /* mov eax, 0x13b */
            ii(0x1017_49ff, 5); mov(ebx, 0x168);                        /* mov ebx, 0x168 */
            ii(0x1017_4a04, 7); mov(memw[ds, 0x1020_8c96], si);         /* mov [0x10208c96], si */
            ii(0x1017_4a0b, 7); mov(memw[ds, 0x1020_8c98], di);         /* mov [0x10208c98], di */
            ii(0x1017_4a12, 7); mov(memw[ds, 0x1020_8ca0], cx);         /* mov [0x10208ca0], cx */
            ii(0x1017_4a19, 5); mov(esi, 0x13d);                        /* mov esi, 0x13d */
            ii(0x1017_4a1e, 5); mov(edi, 0x156);                        /* mov edi, 0x156 */
            ii(0x1017_4a23, 5); mov(ecx, 0x13e);                        /* mov ecx, 0x13e */
            ii(0x1017_4a28, 7); mov(memw[ds, 0x1020_8a4a], dx);         /* mov [0x10208a4a], dx */
            ii(0x1017_4a2f, 7); mov(memw[ds, 0x1020_8a4c], dx);         /* mov [0x10208a4c], dx */
            ii(0x1017_4a36, 7); mov(memw[ds, 0x1020_8a4e], dx);         /* mov [0x10208a4e], dx */
            ii(0x1017_4a3d, 7); mov(memw[ds, 0x1020_8a50], dx);         /* mov [0x10208a50], dx */
            ii(0x1017_4a44, 7); mov(memw[ds, 0x1020_8a52], dx);         /* mov [0x10208a52], dx */
            ii(0x1017_4a4b, 6); mov(memw[ds, 0x1020_8c8e], ax);         /* mov [0x10208c8e], ax */
            ii(0x1017_4a51, 7); mov(memw[ds, 0x1020_8c92], bx);         /* mov [0x10208c92], bx */
            ii(0x1017_4a58, 7); mov(memw[ds, 0x1020_8c94], bx);         /* mov [0x10208c94], bx */
            ii(0x1017_4a5f, 5); mov(edx, 0x154);                        /* mov edx, 0x154 */
            ii(0x1017_4a64, 5); mov(eax, 0x155);                        /* mov eax, 0x155 */
            ii(0x1017_4a69, 5); mov(ebx, 0x160);                        /* mov ebx, 0x160 */
            ii(0x1017_4a6e, 7); mov(memw[ds, 0x1020_8ca2], si);         /* mov [0x10208ca2], si */
            ii(0x1017_4a75, 7); mov(memw[ds, 0x1020_8ca4], di);         /* mov [0x10208ca4], di */
            ii(0x1017_4a7c, 7); mov(memw[ds, 0x1020_8cac], cx);         /* mov [0x10208cac], cx */
            ii(0x1017_4a83, 5); mov(esi, 0x157);                        /* mov esi, 0x157 */
            ii(0x1017_4a88, 5); mov(edi, 0x16b);                        /* mov edi, 0x16b */
            ii(0x1017_4a8d, 5); mov(ecx, 0x158);                        /* mov ecx, 0x158 */
            ii(0x1017_4a92, 7); mov(memw[ds, 0x1020_8c90], dx);         /* mov [0x10208c90], dx */
            ii(0x1017_4a99, 6); mov(memw[ds, 0x1020_8c9a], ax);         /* mov [0x10208c9a], ax */
            ii(0x1017_4a9f, 7); mov(memw[ds, 0x1020_8caa], bx);         /* mov [0x10208caa], bx */
            ii(0x1017_4aa6, 5); mov(edx, 0x169);                        /* mov edx, 0x169 */
            ii(0x1017_4aab, 5); mov(eax, 0x16a);                        /* mov eax, 0x16a */
            ii(0x1017_4ab0, 5); mov(ebx, 0x13f);                        /* mov ebx, 0x13f */
            ii(0x1017_4ab5, 7); mov(memw[ds, 0x1020_8cae], si);         /* mov [0x10208cae], si */
            ii(0x1017_4abc, 7); mov(memw[ds, 0x1020_8cb0], di);         /* mov [0x10208cb0], di */
            ii(0x1017_4ac3, 7); mov(memw[ds, 0x1020_8cb2], di);         /* mov [0x10208cb2], di */
            ii(0x1017_4aca, 7); mov(memw[ds, 0x1020_8cb8], cx);         /* mov [0x10208cb8], cx */
            ii(0x1017_4ad1, 5); mov(esi, 0x16c);                        /* mov esi, 0x16c */
            ii(0x1017_4ad6, 5); mov(ecx, 0x16d);                        /* mov ecx, 0x16d */
            ii(0x1017_4adb, 5); mov(edi, 0x163);                        /* mov edi, 0x163 */
            ii(0x1017_4ae0, 7); mov(memw[ds, 0x1020_8c9c], dx);         /* mov [0x10208c9c], dx */
            ii(0x1017_4ae7, 7); mov(memw[ds, 0x1020_8c9e], dx);         /* mov [0x10208c9e], dx */
            ii(0x1017_4aee, 6); mov(memw[ds, 0x1020_8ca6], ax);         /* mov [0x10208ca6], ax */
            ii(0x1017_4af4, 6); mov(memw[ds, 0x1020_8ca8], ax);         /* mov [0x10208ca8], ax */
            ii(0x1017_4afa, 7); mov(memw[ds, 0x1020_8cb6], bx);         /* mov [0x10208cb6], bx */
            ii(0x1017_4b01, 5); mov(edx, 0x161);                        /* mov edx, 0x161 */
            ii(0x1017_4b06, 5); mov(eax, 0x162);                        /* mov eax, 0x162 */
            ii(0x1017_4b0b, 5); mov(ebx, 0x159);                        /* mov ebx, 0x159 */
            ii(0x1017_4b10, 7); mov(memw[ds, 0x1020_8cba], si);         /* mov [0x10208cba], si */
            ii(0x1017_4b17, 7); mov(memw[ds, 0x1020_8cbc], si);         /* mov [0x10208cbc], si */
            ii(0x1017_4b1e, 7); mov(memw[ds, 0x1020_8cc4], cx);         /* mov [0x10208cc4], cx */
            ii(0x1017_4b25, 7); mov(memw[ds, 0x1020_8cc6], cx);         /* mov [0x10208cc6], cx */
            ii(0x1017_4b2c, 7); mov(memw[ds, 0x1020_8cc8], di);         /* mov [0x10208cc8], di */
            ii(0x1017_4b33, 5); mov(esi, 0x164);                        /* mov esi, 0x164 */
            ii(0x1017_4b38, 5); mov(edi, 0x142);                        /* mov edi, 0x142 */
            ii(0x1017_4b3d, 5); mov(ecx, 0x165);                        /* mov ecx, 0x165 */
            ii(0x1017_4b42, 7); mov(memw[ds, 0x1020_8cb4], dx);         /* mov [0x10208cb4], dx */
            ii(0x1017_4b49, 6); mov(memw[ds, 0x1020_8cbe], ax);         /* mov [0x10208cbe], ax */
            ii(0x1017_4b4f, 7); mov(memw[ds, 0x1020_8cc2], bx);         /* mov [0x10208cc2], bx */
            ii(0x1017_4b56, 5); mov(edx, 0x140);                        /* mov edx, 0x140 */
            ii(0x1017_4b5b, 5); mov(eax, 0x141);                        /* mov eax, 0x141 */
            ii(0x1017_4b60, 5); mov(ebx, 0x16e);                        /* mov ebx, 0x16e */
            ii(0x1017_4b65, 7); mov(memw[ds, 0x1020_8cd2], si);         /* mov [0x10208cd2], si */
            ii(0x1017_4b6c, 7); mov(memw[ds, 0x1020_8cd4], di);         /* mov [0x10208cd4], di */
            ii(0x1017_4b73, 7); mov(memw[ds, 0x1020_8cdc], cx);         /* mov [0x10208cdc], cx */
            ii(0x1017_4b7a, 5); mov(esi, 0x143);                        /* mov esi, 0x143 */
            ii(0x1017_4b7f, 5); mov(edi, 0x15c);                        /* mov edi, 0x15c */
            ii(0x1017_4b84, 5); mov(ecx, 0x144);                        /* mov ecx, 0x144 */
            ii(0x1017_4b89, 7); mov(memw[ds, 0x1020_8cc0], dx);         /* mov [0x10208cc0], dx */
            ii(0x1017_4b90, 6); mov(memw[ds, 0x1020_8cca], ax);         /* mov [0x10208cca], ax */
            ii(0x1017_4b96, 7); mov(memw[ds, 0x1020_8cce], bx);         /* mov [0x10208cce], bx */
            ii(0x1017_4b9d, 7); mov(memw[ds, 0x1020_8cd0], bx);         /* mov [0x10208cd0], bx */
            ii(0x1017_4ba4, 5); mov(edx, 0x15a);                        /* mov edx, 0x15a */
            ii(0x1017_4ba9, 5); mov(eax, 0x15b);                        /* mov eax, 0x15b */
            ii(0x1017_4bae, 5); mov(ebx, 0x166);                        /* mov ebx, 0x166 */
            ii(0x1017_4bb3, 7); mov(memw[ds, 0x1020_8cde], si);         /* mov [0x10208cde], si */
            ii(0x1017_4bba, 7); mov(memw[ds, 0x1020_8ce0], di);         /* mov [0x10208ce0], di */
            ii(0x1017_4bc1, 7); mov(memw[ds, 0x1020_8ce8], cx);         /* mov [0x10208ce8], cx */
            ii(0x1017_4bc8, 5); mov(esi, 0x15d);                        /* mov esi, 0x15d */
            ii(0x1017_4bcd, 5); mov(edi, 0x171);                        /* mov edi, 0x171 */
            ii(0x1017_4bd2, 5); mov(ecx, 0x187);                        /* mov ecx, 0x187 */
            ii(0x1017_4bd7, 7); mov(memw[ds, 0x1020_8ccc], dx);         /* mov [0x10208ccc], dx */
            ii(0x1017_4bde, 6); mov(memw[ds, 0x1020_8cd6], ax);         /* mov [0x10208cd6], ax */
            ii(0x1017_4be4, 7); mov(memw[ds, 0x1020_8ce6], bx);         /* mov [0x10208ce6], bx */
            ii(0x1017_4beb, 5); mov(edx, 0x16f);                        /* mov edx, 0x16f */
            ii(0x1017_4bf0, 5); mov(eax, 0x170);                        /* mov eax, 0x170 */
            ii(0x1017_4bf5, 5); mov(ebx, 0x185);                        /* mov ebx, 0x185 */
            ii(0x1017_4bfa, 7); mov(memw[ds, 0x1020_8cea], si);         /* mov [0x10208cea], si */
            ii(0x1017_4c01, 7); mov(memw[ds, 0x1020_8cec], di);         /* mov [0x10208cec], di */
            ii(0x1017_4c08, 7); mov(memw[ds, 0x1020_8cee], di);         /* mov [0x10208cee], di */
            ii(0x1017_4c0f, 7); mov(memw[ds, 0x1020_8da8], cx);         /* mov [0x10208da8], cx */
            ii(0x1017_4c16, 5); mov(esi, 0x18b);                        /* mov esi, 0x18b */
            ii(0x1017_4c1b, 5); mov(ecx, 0x18c);                        /* mov ecx, 0x18c */
            ii(0x1017_4c20, 5); mov(edi, 0x18a);                        /* mov edi, 0x18a */
            ii(0x1017_4c25, 7); mov(memw[ds, 0x1020_8cd8], dx);         /* mov [0x10208cd8], dx */
            ii(0x1017_4c2c, 7); mov(memw[ds, 0x1020_8cda], dx);         /* mov [0x10208cda], dx */
            ii(0x1017_4c33, 6); mov(memw[ds, 0x1020_8ce2], ax);         /* mov [0x10208ce2], ax */
            ii(0x1017_4c39, 6); mov(memw[ds, 0x1020_8ce4], ax);         /* mov [0x10208ce4], ax */
            ii(0x1017_4c3f, 7); mov(memw[ds, 0x1020_8da6], bx);         /* mov [0x10208da6], bx */
            ii(0x1017_4c46, 5); mov(edx, 0x167);                        /* mov edx, 0x167 */
            ii(0x1017_4c4b, 5); mov(eax, 0x189);                        /* mov eax, 0x189 */
            ii(0x1017_4c50, 5); mov(ebx, 0x188);                        /* mov ebx, 0x188 */
            ii(0x1017_4c55, 7); mov(memw[ds, 0x1020_8daa], si);         /* mov [0x10208daa], si */
            ii(0x1017_4c5c, 7); mov(memw[ds, 0x1020_8dac], si);         /* mov [0x10208dac], si */
            ii(0x1017_4c63, 7); mov(memw[ds, 0x1020_8db4], cx);         /* mov [0x10208db4], cx */
            ii(0x1017_4c6a, 7); mov(memw[ds, 0x1020_8db6], cx);         /* mov [0x10208db6], cx */
            ii(0x1017_4c71, 7); mov(memw[ds, 0x1020_8db8], di);         /* mov [0x10208db8], di */
            ii(0x1017_4c78, 7); mov(memw[ds, 0x1020_8cf0], dx);         /* mov [0x10208cf0], dx */
            ii(0x1017_4c7f, 5); mov(edx, 0x186);                        /* mov edx, 0x186 */
            ii(0x1017_4c84, 6); mov(memw[ds, 0x1020_8dae], ax);         /* mov [0x10208dae], ax */
            ii(0x1017_4c8a, 7); mov(memw[ds, 0x1020_8db0], dx);         /* mov [0x10208db0], dx */
            ii(0x1017_4c91, 6); mov(edx, memd[ds, 0x1020_9540]);        /* mov edx, [0x10209540] */
            ii(0x1017_4c97, 7); mov(memw[ds, 0x1020_8db2], bx);         /* mov [0x10208db2], bx */
            ii(0x1017_4c9e, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1017_4ca0, 2); if(jnz(0x1017_4ca9, 0x7)) goto l_0x1017_4ca9; /* jnz 0x10174ca9 */
            ii(0x1017_4ca2, 5); mov(edx, 0x29);                         /* mov edx, 0x29 */
            ii(0x1017_4ca7, 2); jmp(0x1017_4cce, 0x25); goto l_0x1017_4cce; /* jmp 0x10174cce */
        l_0x1017_4ca9:
            ii(0x1017_4ca9, 3); cmp(edx, 0x1);                          /* cmp edx, 0x1 */
            ii(0x1017_4cac, 2); if(jnz(0x1017_4cb5, 0x7)) goto l_0x1017_4cb5; /* jnz 0x10174cb5 */
            ii(0x1017_4cae, 5); mov(edx, 0x3);                          /* mov edx, 0x3 */
            ii(0x1017_4cb3, 2); jmp(0x1017_4cce, 0x19); goto l_0x1017_4cce; /* jmp 0x10174cce */
        l_0x1017_4cb5:
            ii(0x1017_4cb5, 3); cmp(edx, 0x4);                          /* cmp edx, 0x4 */
            ii(0x1017_4cb8, 2); if(jnz(0x1017_4cbe, 0x4)) goto l_0x1017_4cbe; /* jnz 0x10174cbe */
            ii(0x1017_4cba, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_4cbc, 2); jmp(0x1017_4ccc, 0xe); goto l_0x1017_4ccc; /* jmp 0x10174ccc */
        l_0x1017_4cbe:
            ii(0x1017_4cbe, 3); cmp(edx, 0x3);                          /* cmp edx, 0x3 */
            ii(0x1017_4cc1, 2); if(jnz(0x1017_4cc7, 0x4)) goto l_0x1017_4cc7; /* jnz 0x10174cc7 */
            ii(0x1017_4cc3, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_4cc5, 2); jmp(0x1017_4ccc, 0x5); goto l_0x1017_4ccc; /* jmp 0x10174ccc */
        l_0x1017_4cc7:
            ii(0x1017_4cc7, 5); mov(eax, 0x1b);                         /* mov eax, 0x1b */
        l_0x1017_4ccc:
            ii(0x1017_4ccc, 2); mov(edx, eax);                          /* mov edx, eax */
        l_0x1017_4cce:
            ii(0x1017_4cce, 7); lea(eax, edx * 4 + 0);                  /* lea eax, [edx*4] */
            ii(0x1017_4cd5, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_4cd7, 5); mov(edx, 0x60);                         /* mov edx, 0x60 */
            ii(0x1017_4cdc, 6); mov(edi, memd[ds, 0x1020_9540]);        /* mov edi, [0x10209540] */
            ii(0x1017_4ce2, 8); mov(memw[ds, eax * 2 + 0x1020_8a40], dx); /* mov [eax*2+0x10208a40], dx */
            ii(0x1017_4cea, 2); test(edi, edi);                         /* test edi, edi */
            ii(0x1017_4cec, 2); if(jnz(0x1017_4cf5, 0x7)) goto l_0x1017_4cf5; /* jnz 0x10174cf5 */
            ii(0x1017_4cee, 5); mov(edx, 0x29);                         /* mov edx, 0x29 */
            ii(0x1017_4cf3, 2); jmp(0x1017_4d1a, 0x25); goto l_0x1017_4d1a; /* jmp 0x10174d1a */
        l_0x1017_4cf5:
            ii(0x1017_4cf5, 3); cmp(edi, 0x1);                          /* cmp edi, 0x1 */
            ii(0x1017_4cf8, 2); if(jnz(0x1017_4d01, 0x7)) goto l_0x1017_4d01; /* jnz 0x10174d01 */
            ii(0x1017_4cfa, 5); mov(edx, 0x3);                          /* mov edx, 0x3 */
            ii(0x1017_4cff, 2); jmp(0x1017_4d1a, 0x19); goto l_0x1017_4d1a; /* jmp 0x10174d1a */
        l_0x1017_4d01:
            ii(0x1017_4d01, 3); cmp(edi, 0x4);                          /* cmp edi, 0x4 */
            ii(0x1017_4d04, 2); if(jnz(0x1017_4d0a, 0x4)) goto l_0x1017_4d0a; /* jnz 0x10174d0a */
            ii(0x1017_4d06, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_4d08, 2); jmp(0x1017_4d18, 0xe); goto l_0x1017_4d18; /* jmp 0x10174d18 */
        l_0x1017_4d0a:
            ii(0x1017_4d0a, 3); cmp(edi, 0x3);                          /* cmp edi, 0x3 */
            ii(0x1017_4d0d, 2); if(jnz(0x1017_4d13, 0x4)) goto l_0x1017_4d13; /* jnz 0x10174d13 */
            ii(0x1017_4d0f, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_4d11, 2); jmp(0x1017_4d18, 0x5); goto l_0x1017_4d18; /* jmp 0x10174d18 */
        l_0x1017_4d13:
            ii(0x1017_4d13, 5); mov(eax, 0x1b);                         /* mov eax, 0x1b */
        l_0x1017_4d18:
            ii(0x1017_4d18, 2); mov(edx, eax);                          /* mov edx, eax */
        l_0x1017_4d1a:
            ii(0x1017_4d1a, 7); lea(eax, edx * 4 + 0);                  /* lea eax, [edx*4] */
            ii(0x1017_4d21, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_4d23, 10); mov(memw[ds, eax * 2 + 0x1020_8a42], 0x7e); /* mov word [eax*2+0x10208a42], 0x7e */
            ii(0x1017_4d2d, 6); mov(ebx, memd[ds, 0x1020_9540]);        /* mov ebx, [0x10209540] */
            ii(0x1017_4d33, 2); test(ebx, ebx);                         /* test ebx, ebx */
            ii(0x1017_4d35, 2); if(jnz(0x1017_4d3e, 0x7)) goto l_0x1017_4d3e; /* jnz 0x10174d3e */
            ii(0x1017_4d37, 5); mov(edx, 0x29);                         /* mov edx, 0x29 */
            ii(0x1017_4d3c, 2); jmp(0x1017_4d63, 0x25); goto l_0x1017_4d63; /* jmp 0x10174d63 */
        l_0x1017_4d3e:
            ii(0x1017_4d3e, 3); cmp(ebx, 0x1);                          /* cmp ebx, 0x1 */
            ii(0x1017_4d41, 2); if(jnz(0x1017_4d4a, 0x7)) goto l_0x1017_4d4a; /* jnz 0x10174d4a */
            ii(0x1017_4d43, 5); mov(eax, 0x3);                          /* mov eax, 0x3 */
            ii(0x1017_4d48, 2); jmp(0x1017_4d61, 0x17); goto l_0x1017_4d61; /* jmp 0x10174d61 */
        l_0x1017_4d4a:
            ii(0x1017_4d4a, 3); cmp(ebx, 0x4);                          /* cmp ebx, 0x4 */
            ii(0x1017_4d4d, 2); if(jnz(0x1017_4d53, 0x4)) goto l_0x1017_4d53; /* jnz 0x10174d53 */
            ii(0x1017_4d4f, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_4d51, 2); jmp(0x1017_4d61, 0xe); goto l_0x1017_4d61; /* jmp 0x10174d61 */
        l_0x1017_4d53:
            ii(0x1017_4d53, 3); cmp(ebx, 0x3);                          /* cmp ebx, 0x3 */
            ii(0x1017_4d56, 2); if(jnz(0x1017_4d5c, 0x4)) goto l_0x1017_4d5c; /* jnz 0x10174d5c */
            ii(0x1017_4d58, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_4d5a, 2); jmp(0x1017_4d61, 0x5); goto l_0x1017_4d61; /* jmp 0x10174d61 */
        l_0x1017_4d5c:
            ii(0x1017_4d5c, 5); mov(eax, 0x1b);                         /* mov eax, 0x1b */
        l_0x1017_4d61:
            ii(0x1017_4d61, 2); mov(edx, eax);                          /* mov edx, eax */
        l_0x1017_4d63:
            ii(0x1017_4d63, 7); lea(eax, edx * 4 + 0);                  /* lea eax, [edx*4] */
            ii(0x1017_4d6a, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_4d6c, 5); mov(ecx, 0xffff_ffff);                  /* mov ecx, 0xffffffff */
            ii(0x1017_4d71, 6); mov(ebp, memd[ds, 0x1020_9540]);        /* mov ebp, [0x10209540] */
            ii(0x1017_4d77, 8); mov(memw[ds, eax * 2 + 0x1020_8a44], cx); /* mov [eax*2+0x10208a44], cx */
            ii(0x1017_4d7f, 2); test(ebp, ebp);                         /* test ebp, ebp */
            ii(0x1017_4d81, 2); if(jnz(0x1017_4d8a, 0x7)) goto l_0x1017_4d8a; /* jnz 0x10174d8a */
            ii(0x1017_4d83, 5); mov(eax, 0x29);                         /* mov eax, 0x29 */
            ii(0x1017_4d88, 2); jmp(0x1017_4dad, 0x23); goto l_0x1017_4dad; /* jmp 0x10174dad */
        l_0x1017_4d8a:
            ii(0x1017_4d8a, 3); cmp(ebp, 0x1);                          /* cmp ebp, 0x1 */
            ii(0x1017_4d8d, 2); if(jnz(0x1017_4d96, 0x7)) goto l_0x1017_4d96; /* jnz 0x10174d96 */
            ii(0x1017_4d8f, 5); mov(eax, 0x3);                          /* mov eax, 0x3 */
            ii(0x1017_4d94, 2); jmp(0x1017_4dad, 0x17); goto l_0x1017_4dad; /* jmp 0x10174dad */
        l_0x1017_4d96:
            ii(0x1017_4d96, 3); cmp(ebp, 0x4);                          /* cmp ebp, 0x4 */
            ii(0x1017_4d99, 2); if(jnz(0x1017_4d9f, 0x4)) goto l_0x1017_4d9f; /* jnz 0x10174d9f */
            ii(0x1017_4d9b, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_4d9d, 2); jmp(0x1017_4dad, 0xe); goto l_0x1017_4dad; /* jmp 0x10174dad */
        l_0x1017_4d9f:
            ii(0x1017_4d9f, 3); cmp(ebp, 0x3);                          /* cmp ebp, 0x3 */
            ii(0x1017_4da2, 2); if(jnz(0x1017_4da8, 0x4)) goto l_0x1017_4da8; /* jnz 0x10174da8 */
            ii(0x1017_4da4, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_4da6, 2); jmp(0x1017_4dad, 0x5); goto l_0x1017_4dad; /* jmp 0x10174dad */
        l_0x1017_4da8:
            ii(0x1017_4da8, 5); mov(eax, 0x1b);                         /* mov eax, 0x1b */
        l_0x1017_4dad:
            ii(0x1017_4dad, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1017_4daf, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1017_4db2, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_4db4, 5); mov(esi, 0xffff_ffff);                  /* mov esi, 0xffffffff */
            ii(0x1017_4db9, 6); mov(ecx, memd[ds, 0x1020_9540]);        /* mov ecx, [0x10209540] */
            ii(0x1017_4dbf, 8); mov(memw[ds, eax * 2 + 0x1020_8a46], si); /* mov [eax*2+0x10208a46], si */
            ii(0x1017_4dc7, 2); test(ecx, ecx);                         /* test ecx, ecx */
            ii(0x1017_4dc9, 2); if(jnz(0x1017_4dd2, 0x7)) goto l_0x1017_4dd2; /* jnz 0x10174dd2 */
            ii(0x1017_4dcb, 5); mov(eax, 0x29);                         /* mov eax, 0x29 */
            ii(0x1017_4dd0, 2); jmp(0x1017_4df5, 0x23); goto l_0x1017_4df5; /* jmp 0x10174df5 */
        l_0x1017_4dd2:
            ii(0x1017_4dd2, 3); cmp(ecx, 0x1);                          /* cmp ecx, 0x1 */
            ii(0x1017_4dd5, 2); if(jnz(0x1017_4dde, 0x7)) goto l_0x1017_4dde; /* jnz 0x10174dde */
            ii(0x1017_4dd7, 5); mov(eax, 0x3);                          /* mov eax, 0x3 */
            ii(0x1017_4ddc, 2); jmp(0x1017_4df5, 0x17); goto l_0x1017_4df5; /* jmp 0x10174df5 */
        l_0x1017_4dde:
            ii(0x1017_4dde, 3); cmp(ecx, 0x4);                          /* cmp ecx, 0x4 */
            ii(0x1017_4de1, 2); if(jnz(0x1017_4de7, 0x4)) goto l_0x1017_4de7; /* jnz 0x10174de7 */
            ii(0x1017_4de3, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_4de5, 2); jmp(0x1017_4df5, 0xe); goto l_0x1017_4df5; /* jmp 0x10174df5 */
        l_0x1017_4de7:
            ii(0x1017_4de7, 3); cmp(ecx, 0x3);                          /* cmp ecx, 0x3 */
            ii(0x1017_4dea, 2); if(jnz(0x1017_4df0, 0x4)) goto l_0x1017_4df0; /* jnz 0x10174df0 */
            ii(0x1017_4dec, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_4dee, 2); jmp(0x1017_4df5, 0x5); goto l_0x1017_4df5; /* jmp 0x10174df5 */
        l_0x1017_4df0:
            ii(0x1017_4df0, 5); mov(eax, 0x1b);                         /* mov eax, 0x1b */
        l_0x1017_4df5:
            ii(0x1017_4df5, 5); mov(edi, 0xffff_ffff);                  /* mov edi, 0xffffffff */
            ii(0x1017_4dfa, 5); mov(esi, 0x33);                         /* mov esi, 0x33 */
            ii(0x1017_4dff, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1017_4e01, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1017_4e04, 5); mov(ecx, 0x34);                         /* mov ecx, 0x34 */
            ii(0x1017_4e09, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_4e0b, 2); mov(ebx, edi);                          /* mov ebx, edi */
            ii(0x1017_4e0d, 5); mov(edx, 0x21);                         /* mov edx, 0x21 */
            ii(0x1017_4e12, 8); mov(memw[ds, eax * 2 + 0x1020_8a48], di); /* mov [eax*2+0x10208a48], di */
            ii(0x1017_4e1a, 5); mov(eax, 0x31);                         /* mov eax, 0x31 */
            ii(0x1017_4e1f, 7); mov(memw[ds, 0x1020_8a56], dx);         /* mov [0x10208a56], dx */
            ii(0x1017_4e26, 7); mov(memw[ds, 0x1020_8a58], di);         /* mov [0x10208a58], di */
            ii(0x1017_4e2d, 7); mov(memw[ds, 0x1020_8a5a], di);         /* mov [0x10208a5a], di */
            ii(0x1017_4e34, 7); mov(memw[ds, 0x1020_8a5c], di);         /* mov [0x10208a5c], di */
            ii(0x1017_4e3b, 7); mov(memw[ds, 0x1020_8a62], bx);         /* mov [0x10208a62], bx */
            ii(0x1017_4e42, 7); mov(memw[ds, 0x1020_8a64], bx);         /* mov [0x10208a64], bx */
            ii(0x1017_4e49, 7); mov(memw[ds, 0x1020_8a66], bx);         /* mov [0x10208a66], bx */
            ii(0x1017_4e50, 7); mov(memw[ds, 0x1020_8a68], si);         /* mov [0x10208a68], si */
            ii(0x1017_4e57, 7); mov(memw[ds, 0x1020_8a6c], bx);         /* mov [0x10208a6c], bx */
            ii(0x1017_4e5e, 7); mov(memw[ds, 0x1020_8a6e], bx);         /* mov [0x10208a6e], bx */
            ii(0x1017_4e65, 7); mov(memw[ds, 0x1020_8a70], bx);         /* mov [0x10208a70], bx */
            ii(0x1017_4e6c, 7); mov(memw[ds, 0x1020_8a72], cx);         /* mov [0x10208a72], cx */
            ii(0x1017_4e73, 7); mov(memw[ds, 0x1020_8a76], bx);         /* mov [0x10208a76], bx */
            ii(0x1017_4e7a, 7); mov(memw[ds, 0x1020_8a78], bx);         /* mov [0x10208a78], bx */
            ii(0x1017_4e81, 7); mov(memw[ds, 0x1020_8a7a], bx);         /* mov [0x10208a7a], bx */
            ii(0x1017_4e88, 5); mov(edi, 0x32);                         /* mov edi, 0x32 */
            ii(0x1017_4e8d, 5); mov(esi, 0x24);                         /* mov esi, 0x24 */
            ii(0x1017_4e92, 5); mov(ecx, 0x25);                         /* mov ecx, 0x25 */
            ii(0x1017_4e97, 6); mov(memw[ds, 0x1020_8a54], ax);         /* mov [0x10208a54], ax */
            ii(0x1017_4e9d, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x1017_4e9f, 5); mov(eax, 0x40);                         /* mov eax, 0x40 */
            ii(0x1017_4ea4, 5); mov(ebx, 0x35);                         /* mov ebx, 0x35 */
            ii(0x1017_4ea9, 7); mov(memw[ds, 0x1020_8a5e], di);         /* mov [0x10208a5e], di */
            ii(0x1017_4eb0, 7); mov(memw[ds, 0x1020_8a74], si);         /* mov [0x10208a74], si */
            ii(0x1017_4eb7, 7); mov(memw[ds, 0x1020_8a7e], cx);         /* mov [0x10208a7e], cx */
            ii(0x1017_4ebe, 7); mov(memw[ds, 0x1020_8a80], dx);         /* mov [0x10208a80], dx */
            ii(0x1017_4ec5, 7); mov(memw[ds, 0x1020_8a82], dx);         /* mov [0x10208a82], dx */
            ii(0x1017_4ecc, 7); mov(memw[ds, 0x1020_8a84], dx);         /* mov [0x10208a84], dx */
            ii(0x1017_4ed3, 5); mov(edi, 0x23);                         /* mov edi, 0x23 */
            ii(0x1017_4ed8, 6); mov(memw[ds, 0x1020_8a60], ax);         /* mov [0x10208a60], ax */
            ii(0x1017_4ede, 7); mov(memw[ds, 0x1020_8a7c], bx);         /* mov [0x10208a7c], bx */
            ii(0x1017_4ee5, 2); mov(esi, edx);                          /* mov esi, edx */
            ii(0x1017_4ee7, 5); mov(ebx, 0x5e);                         /* mov ebx, 0x5e */
            ii(0x1017_4eec, 7); mov(memw[ds, 0x1020_8a6a], di);         /* mov [0x10208a6a], di */
            ii(0x1017_4ef3, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1017_4ef5, 7); mov(memw[ds, 0x1020_8a98], si);         /* mov [0x10208a98], si */
            ii(0x1017_4efc, 5); mov(edx, 0x36);                         /* mov edx, 0x36 */
            ii(0x1017_4f01, 5); mov(edi, 0x38);                         /* mov edi, 0x38 */
            ii(0x1017_4f06, 5); mov(esi, 0x39);                         /* mov esi, 0x39 */
            ii(0x1017_4f0b, 7); mov(memw[ds, 0x1020_8a88], bx);         /* mov [0x10208a88], bx */
            ii(0x1017_4f12, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1017_4f14, 6); mov(memw[ds, 0x1020_8a8a], ax);         /* mov [0x10208a8a], ax */
            ii(0x1017_4f1a, 6); mov(memw[ds, 0x1020_8a8c], ax);         /* mov [0x10208a8c], ax */
            ii(0x1017_4f20, 6); mov(memw[ds, 0x1020_8a8e], ax);         /* mov [0x10208a8e], ax */
            ii(0x1017_4f26, 5); mov(eax, 0x37);                         /* mov eax, 0x37 */
            ii(0x1017_4f2b, 7); mov(memw[ds, 0x1020_8a86], dx);         /* mov [0x10208a86], dx */
            ii(0x1017_4f32, 2); mov(ebx, ecx);                          /* mov ebx, ecx */
            ii(0x1017_4f34, 7); mov(memw[ds, 0x1020_8a96], cx);         /* mov [0x10208a96], cx */
            ii(0x1017_4f3b, 7); mov(memw[ds, 0x1020_8a9a], di);         /* mov [0x10208a9a], di */
            ii(0x1017_4f42, 7); mov(memw[ds, 0x1020_8aa2], cx);         /* mov [0x10208aa2], cx */
            ii(0x1017_4f49, 7); mov(memw[ds, 0x1020_8aa4], si);         /* mov [0x10208aa4], si */
            ii(0x1017_4f50, 5); mov(edx, 0x26);                         /* mov edx, 0x26 */
            ii(0x1017_4f55, 5); mov(edi, 0x28);                         /* mov edi, 0x28 */
            ii(0x1017_4f5a, 5); mov(ecx, 0x30);                         /* mov ecx, 0x30 */
            ii(0x1017_4f5f, 5); mov(esi, 0x29);                         /* mov esi, 0x29 */
            ii(0x1017_4f64, 6); mov(memw[ds, 0x1020_8a90], ax);         /* mov [0x10208a90], ax */
            ii(0x1017_4f6a, 7); mov(memw[ds, 0x1020_8a94], bx);         /* mov [0x10208a94], bx */
            ii(0x1017_4f71, 7); mov(memw[ds, 0x1020_8a9e], bx);         /* mov [0x10208a9e], bx */
            ii(0x1017_4f78, 7); mov(memw[ds, 0x1020_8aa0], bx);         /* mov [0x10208aa0], bx */
            ii(0x1017_4f7f, 7); mov(memw[ds, 0x1020_8aa8], bx);         /* mov [0x10208aa8], bx */
            ii(0x1017_4f86, 7); mov(memw[ds, 0x1020_8aaa], bx);         /* mov [0x10208aaa], bx */
            ii(0x1017_4f8d, 7); mov(memw[ds, 0x1020_8aac], bx);         /* mov [0x10208aac], bx */
            ii(0x1017_4f94, 7); mov(memw[ds, 0x1020_8ab2], bx);         /* mov [0x10208ab2], bx */
            ii(0x1017_4f9b, 7); mov(memw[ds, 0x1020_8ab4], bx);         /* mov [0x10208ab4], bx */
            ii(0x1017_4fa2, 7); mov(memw[ds, 0x1020_8ab6], bx);         /* mov [0x10208ab6], bx */
            ii(0x1017_4fa9, 5); mov(eax, 0x2a);                         /* mov eax, 0x2a */
            ii(0x1017_4fae, 7); mov(memw[ds, 0x1020_8a92], dx);         /* mov [0x10208a92], dx */
            ii(0x1017_4fb5, 7); mov(memw[ds, 0x1020_8aa6], di);         /* mov [0x10208aa6], di */
            ii(0x1017_4fbc, 7); mov(memw[ds, 0x1020_8aae], cx);         /* mov [0x10208aae], cx */
            ii(0x1017_4fc3, 6); mov(memw[ds, 0x1020_8a9c], ax);         /* mov [0x10208a9c], ax */
            ii(0x1017_4fc9, 5); mov(eax, memd[ds, 0x1020_9540]);        /* mov eax, [0x10209540] */
            ii(0x1017_4fce, 7); mov(memw[ds, 0x1020_8ab0], si);         /* mov [0x10208ab0], si */
            ii(0x1017_4fd5, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_4fd7, 2); if(jnz(0x1017_4fe0, 0x7)) goto l_0x1017_4fe0; /* jnz 0x10174fe0 */
            ii(0x1017_4fd9, 5); mov(eax, 0xc);                          /* mov eax, 0xc */
            ii(0x1017_4fde, 2); jmp(0x1017_4ff9, 0x19); goto l_0x1017_4ff9; /* jmp 0x10174ff9 */
        l_0x1017_4fe0:
            ii(0x1017_4fe0, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1017_4fe3, 2); if(jnz(0x1017_4fec, 0x7)) goto l_0x1017_4fec; /* jnz 0x10174fec */
            ii(0x1017_4fe5, 5); mov(eax, 0x7);                          /* mov eax, 0x7 */
            ii(0x1017_4fea, 2); jmp(0x1017_4ff9, 0xd); goto l_0x1017_4ff9; /* jmp 0x10174ff9 */
        l_0x1017_4fec:
            ii(0x1017_4fec, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x1017_4fef, 2); if(jz(0x1017_4ff4, 0x3)) goto l_0x1017_4ff4; /* jz 0x10174ff4 */
            ii(0x1017_4ff1, 3); cmp(eax, 0x3);                          /* cmp eax, 0x3 */
        l_0x1017_4ff4:
            ii(0x1017_4ff4, 5); mov(eax, 0x35);                         /* mov eax, 0x35 */
        l_0x1017_4ff9:
            ii(0x1017_4ff9, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1017_4ffb, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1017_4ffe, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_5000, 5); mov(ebx, 0x2d);                         /* mov ebx, 0x2d */
            ii(0x1017_5005, 6); mov(esi, memd[ds, 0x1020_9540]);        /* mov esi, [0x10209540] */
            ii(0x1017_500b, 8); mov(memw[ds, eax * 2 + 0x1020_8a40], bx); /* mov [eax*2+0x10208a40], bx */
            ii(0x1017_5013, 2); test(esi, esi);                         /* test esi, esi */
            ii(0x1017_5015, 2); if(jnz(0x1017_501e, 0x7)) goto l_0x1017_501e; /* jnz 0x1017501e */
            ii(0x1017_5017, 5); mov(eax, 0xc);                          /* mov eax, 0xc */
            ii(0x1017_501c, 2); jmp(0x1017_5037, 0x19); goto l_0x1017_5037; /* jmp 0x10175037 */
        l_0x1017_501e:
            ii(0x1017_501e, 3); cmp(esi, 0x1);                          /* cmp esi, 0x1 */
            ii(0x1017_5021, 2); if(jnz(0x1017_502a, 0x7)) goto l_0x1017_502a; /* jnz 0x1017502a */
            ii(0x1017_5023, 5); mov(eax, 0x7);                          /* mov eax, 0x7 */
            ii(0x1017_5028, 2); jmp(0x1017_5037, 0xd); goto l_0x1017_5037; /* jmp 0x10175037 */
        l_0x1017_502a:
            ii(0x1017_502a, 3); cmp(esi, 0x4);                          /* cmp esi, 0x4 */
            ii(0x1017_502d, 2); if(jz(0x1017_5032, 0x3)) goto l_0x1017_5032; /* jz 0x10175032 */
            ii(0x1017_502f, 3); cmp(esi, 0x3);                          /* cmp esi, 0x3 */
        l_0x1017_5032:
            ii(0x1017_5032, 5); mov(eax, 0x35);                         /* mov eax, 0x35 */
        l_0x1017_5037:
            ii(0x1017_5037, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1017_5039, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1017_503c, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_503e, 5); mov(ecx, 0x5f);                         /* mov ecx, 0x5f */
            ii(0x1017_5043, 6); mov(edx, memd[ds, 0x1020_9540]);        /* mov edx, [0x10209540] */
            ii(0x1017_5049, 8); mov(memw[ds, eax * 2 + 0x1020_8a42], cx); /* mov [eax*2+0x10208a42], cx */
            ii(0x1017_5051, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1017_5053, 2); if(jnz(0x1017_505c, 0x7)) goto l_0x1017_505c; /* jnz 0x1017505c */
            ii(0x1017_5055, 5); mov(edx, 0xc);                          /* mov edx, 0xc */
            ii(0x1017_505a, 2); jmp(0x1017_5077, 0x1b); goto l_0x1017_5077; /* jmp 0x10175077 */
        l_0x1017_505c:
            ii(0x1017_505c, 3); cmp(edx, 0x1);                          /* cmp edx, 0x1 */
            ii(0x1017_505f, 2); if(jnz(0x1017_5068, 0x7)) goto l_0x1017_5068; /* jnz 0x10175068 */
            ii(0x1017_5061, 5); mov(edx, 0x7);                          /* mov edx, 0x7 */
            ii(0x1017_5066, 2); jmp(0x1017_5077, 0xf); goto l_0x1017_5077; /* jmp 0x10175077 */
        l_0x1017_5068:
            ii(0x1017_5068, 3); cmp(edx, 0x4);                          /* cmp edx, 0x4 */
            ii(0x1017_506b, 2); if(jz(0x1017_5070, 0x3)) goto l_0x1017_5070; /* jz 0x10175070 */
            ii(0x1017_506d, 3); cmp(edx, 0x3);                          /* cmp edx, 0x3 */
        l_0x1017_5070:
            ii(0x1017_5070, 5); mov(eax, 0x35);                         /* mov eax, 0x35 */
            ii(0x1017_5075, 2); mov(edx, eax);                          /* mov edx, eax */
        l_0x1017_5077:
            ii(0x1017_5077, 7); lea(eax, edx * 4 + 0);                  /* lea eax, [edx*4] */
            ii(0x1017_507e, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_5080, 5); mov(esi, 0xffff_ffff);                  /* mov esi, 0xffffffff */
            ii(0x1017_5085, 6); mov(edi, memd[ds, 0x1020_9540]);        /* mov edi, [0x10209540] */
            ii(0x1017_508b, 8); mov(memw[ds, eax * 2 + 0x1020_8a44], si); /* mov [eax*2+0x10208a44], si */
            ii(0x1017_5093, 2); test(edi, edi);                         /* test edi, edi */
            ii(0x1017_5095, 2); if(jnz(0x1017_509e, 0x7)) goto l_0x1017_509e; /* jnz 0x1017509e */
            ii(0x1017_5097, 5); mov(eax, 0xc);                          /* mov eax, 0xc */
            ii(0x1017_509c, 2); jmp(0x1017_50b7, 0x19); goto l_0x1017_50b7; /* jmp 0x101750b7 */
        l_0x1017_509e:
            ii(0x1017_509e, 3); cmp(edi, 0x1);                          /* cmp edi, 0x1 */
            ii(0x1017_50a1, 2); if(jnz(0x1017_50aa, 0x7)) goto l_0x1017_50aa; /* jnz 0x101750aa */
            ii(0x1017_50a3, 5); mov(eax, 0x7);                          /* mov eax, 0x7 */
            ii(0x1017_50a8, 2); jmp(0x1017_50b7, 0xd); goto l_0x1017_50b7; /* jmp 0x101750b7 */
        l_0x1017_50aa:
            ii(0x1017_50aa, 3); cmp(edi, 0x4);                          /* cmp edi, 0x4 */
            ii(0x1017_50ad, 2); if(jz(0x1017_50b2, 0x3)) goto l_0x1017_50b2; /* jz 0x101750b2 */
            ii(0x1017_50af, 3); cmp(edi, 0x3);                          /* cmp edi, 0x3 */
        l_0x1017_50b2:
            ii(0x1017_50b2, 5); mov(eax, 0x35);                         /* mov eax, 0x35 */
        l_0x1017_50b7:
            ii(0x1017_50b7, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1017_50b9, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1017_50bc, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_50be, 5); mov(edi, 0xffff_ffff);                  /* mov edi, 0xffffffff */
            ii(0x1017_50c3, 6); mov(ebx, memd[ds, 0x1020_9540]);        /* mov ebx, [0x10209540] */
            ii(0x1017_50c9, 8); mov(memw[ds, eax * 2 + 0x1020_8a46], di); /* mov [eax*2+0x10208a46], di */
            ii(0x1017_50d1, 2); test(ebx, ebx);                         /* test ebx, ebx */
            ii(0x1017_50d3, 2); if(jnz(0x1017_50dc, 0x7)) goto l_0x1017_50dc; /* jnz 0x101750dc */
            ii(0x1017_50d5, 5); mov(edx, 0xc);                          /* mov edx, 0xc */
            ii(0x1017_50da, 2); jmp(0x1017_50f7, 0x1b); goto l_0x1017_50f7; /* jmp 0x101750f7 */
        l_0x1017_50dc:
            ii(0x1017_50dc, 3); cmp(ebx, 0x1);                          /* cmp ebx, 0x1 */
            ii(0x1017_50df, 2); if(jnz(0x1017_50e8, 0x7)) goto l_0x1017_50e8; /* jnz 0x101750e8 */
            ii(0x1017_50e1, 5); mov(eax, 0x7);                          /* mov eax, 0x7 */
            ii(0x1017_50e6, 2); jmp(0x1017_50f5, 0xd); goto l_0x1017_50f5; /* jmp 0x101750f5 */
        l_0x1017_50e8:
            ii(0x1017_50e8, 3); cmp(ebx, 0x4);                          /* cmp ebx, 0x4 */
            ii(0x1017_50eb, 2); if(jz(0x1017_50f0, 0x3)) goto l_0x1017_50f0; /* jz 0x101750f0 */
            ii(0x1017_50ed, 3); cmp(ebx, 0x3);                          /* cmp ebx, 0x3 */
        l_0x1017_50f0:
            ii(0x1017_50f0, 5); mov(eax, 0x35);                         /* mov eax, 0x35 */
        l_0x1017_50f5:
            ii(0x1017_50f5, 2); mov(edx, eax);                          /* mov edx, eax */
        l_0x1017_50f7:
            ii(0x1017_50f7, 7); lea(eax, edx * 4 + 0);                  /* lea eax, [edx*4] */
            ii(0x1017_50fe, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_5100, 5); mov(edx, 0xffff_ffff);                  /* mov edx, 0xffffffff */
            ii(0x1017_5105, 6); mov(ebp, memd[ds, 0x1020_9540]);        /* mov ebp, [0x10209540] */
            ii(0x1017_510b, 8); mov(memw[ds, eax * 2 + 0x1020_8a48], dx); /* mov [eax*2+0x10208a48], dx */
            ii(0x1017_5113, 2); test(ebp, ebp);                         /* test ebp, ebp */
            ii(0x1017_5115, 2); if(jnz(0x1017_511e, 0x7)) goto l_0x1017_511e; /* jnz 0x1017511e */
            ii(0x1017_5117, 5); mov(edx, 0xd);                          /* mov edx, 0xd */
            ii(0x1017_511c, 2); jmp(0x1017_5139, 0x1b); goto l_0x1017_5139; /* jmp 0x10175139 */
        l_0x1017_511e:
            ii(0x1017_511e, 3); cmp(ebp, 0x1);                          /* cmp ebp, 0x1 */
            ii(0x1017_5121, 2); if(jnz(0x1017_512a, 0x7)) goto l_0x1017_512a; /* jnz 0x1017512a */
            ii(0x1017_5123, 5); mov(eax, 0xd);                          /* mov eax, 0xd */
            ii(0x1017_5128, 2); jmp(0x1017_5137, 0xd); goto l_0x1017_5137; /* jmp 0x10175137 */
        l_0x1017_512a:
            ii(0x1017_512a, 3); cmp(ebp, 0x4);                          /* cmp ebp, 0x4 */
            ii(0x1017_512d, 2); if(jz(0x1017_5132, 0x3)) goto l_0x1017_5132; /* jz 0x10175132 */
            ii(0x1017_512f, 3); cmp(ebp, 0x3);                          /* cmp ebp, 0x3 */
        l_0x1017_5132:
            ii(0x1017_5132, 5); mov(eax, 0xb);                          /* mov eax, 0xb */
        l_0x1017_5137:
            ii(0x1017_5137, 2); mov(edx, eax);                          /* mov edx, eax */
        l_0x1017_5139:
            ii(0x1017_5139, 7); lea(eax, edx * 4 + 0);                  /* lea eax, [edx*4] */
            ii(0x1017_5140, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_5142, 5); mov(ebx, 0x3d);                         /* mov ebx, 0x3d */
            ii(0x1017_5147, 6); mov(ecx, memd[ds, 0x1020_9540]);        /* mov ecx, [0x10209540] */
            ii(0x1017_514d, 8); mov(memw[ds, eax * 2 + 0x1020_8a40], bx); /* mov [eax*2+0x10208a40], bx */
            ii(0x1017_5155, 2); test(ecx, ecx);                         /* test ecx, ecx */
            ii(0x1017_5157, 2); if(jnz(0x1017_5160, 0x7)) goto l_0x1017_5160; /* jnz 0x10175160 */
            ii(0x1017_5159, 5); mov(edx, 0xd);                          /* mov edx, 0xd */
            ii(0x1017_515e, 2); jmp(0x1017_5179, 0x19); goto l_0x1017_5179; /* jmp 0x10175179 */
        l_0x1017_5160:
            ii(0x1017_5160, 3); cmp(ecx, 0x1);                          /* cmp ecx, 0x1 */
            ii(0x1017_5163, 2); if(jnz(0x1017_516c, 0x7)) goto l_0x1017_516c; /* jnz 0x1017516c */
            ii(0x1017_5165, 5); mov(edx, 0xd);                          /* mov edx, 0xd */
            ii(0x1017_516a, 2); jmp(0x1017_5179, 0xd); goto l_0x1017_5179; /* jmp 0x10175179 */
        l_0x1017_516c:
            ii(0x1017_516c, 3); cmp(ecx, 0x4);                          /* cmp ecx, 0x4 */
            ii(0x1017_516f, 2); if(jz(0x1017_5174, 0x3)) goto l_0x1017_5174; /* jz 0x10175174 */
            ii(0x1017_5171, 3); cmp(ecx, 0x3);                          /* cmp ecx, 0x3 */
        l_0x1017_5174:
            ii(0x1017_5174, 5); mov(edx, 0xb);                          /* mov edx, 0xb */
        l_0x1017_5179:
            ii(0x1017_5179, 7); lea(eax, edx * 4 + 0);                  /* lea eax, [edx*4] */
            ii(0x1017_5180, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_5182, 10); mov(memw[ds, eax * 2 + 0x1020_8a42], 0x2b); /* mov word [eax*2+0x10208a42], 0x2b */
            ii(0x1017_518c, 5); mov(eax, memd[ds, 0x1020_9540]);        /* mov eax, [0x10209540] */
            ii(0x1017_5191, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_5193, 2); if(jnz(0x1017_519c, 0x7)) goto l_0x1017_519c; /* jnz 0x1017519c */
            ii(0x1017_5195, 5); mov(edx, 0xd);                          /* mov edx, 0xd */
            ii(0x1017_519a, 2); jmp(0x1017_51b5, 0x19); goto l_0x1017_51b5; /* jmp 0x101751b5 */
        l_0x1017_519c:
            ii(0x1017_519c, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1017_519f, 2); if(jnz(0x1017_51a8, 0x7)) goto l_0x1017_51a8; /* jnz 0x101751a8 */
            ii(0x1017_51a1, 5); mov(edx, 0xd);                          /* mov edx, 0xd */
            ii(0x1017_51a6, 2); jmp(0x1017_51b5, 0xd); goto l_0x1017_51b5; /* jmp 0x101751b5 */
        l_0x1017_51a8:
            ii(0x1017_51a8, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x1017_51ab, 2); if(jz(0x1017_51b0, 0x3)) goto l_0x1017_51b0; /* jz 0x101751b0 */
            ii(0x1017_51ad, 3); cmp(eax, 0x3);                          /* cmp eax, 0x3 */
        l_0x1017_51b0:
            ii(0x1017_51b0, 5); mov(edx, 0xb);                          /* mov edx, 0xb */
        l_0x1017_51b5:
            ii(0x1017_51b5, 7); lea(eax, edx * 4 + 0);                  /* lea eax, [edx*4] */
            ii(0x1017_51bc, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_51be, 10); mov(memw[ds, eax * 2 + 0x1020_8a44], 0xffff); /* mov word [eax*2+0x10208a44], 0xffff */
            ii(0x1017_51c8, 6); mov(esi, memd[ds, 0x1020_9540]);        /* mov esi, [0x10209540] */
            ii(0x1017_51ce, 2); test(esi, esi);                         /* test esi, esi */
            ii(0x1017_51d0, 2); if(jnz(0x1017_51d9, 0x7)) goto l_0x1017_51d9; /* jnz 0x101751d9 */
            ii(0x1017_51d2, 5); mov(edx, 0xd);                          /* mov edx, 0xd */
            ii(0x1017_51d7, 2); jmp(0x1017_51f2, 0x19); goto l_0x1017_51f2; /* jmp 0x101751f2 */
        l_0x1017_51d9:
            ii(0x1017_51d9, 3); cmp(esi, 0x1);                          /* cmp esi, 0x1 */
            ii(0x1017_51dc, 2); if(jnz(0x1017_51e5, 0x7)) goto l_0x1017_51e5; /* jnz 0x101751e5 */
            ii(0x1017_51de, 5); mov(edx, 0xd);                          /* mov edx, 0xd */
            ii(0x1017_51e3, 2); jmp(0x1017_51f2, 0xd); goto l_0x1017_51f2; /* jmp 0x101751f2 */
        l_0x1017_51e5:
            ii(0x1017_51e5, 3); cmp(esi, 0x4);                          /* cmp esi, 0x4 */
            ii(0x1017_51e8, 2); if(jz(0x1017_51ed, 0x3)) goto l_0x1017_51ed; /* jz 0x101751ed */
            ii(0x1017_51ea, 3); cmp(esi, 0x3);                          /* cmp esi, 0x3 */
        l_0x1017_51ed:
            ii(0x1017_51ed, 5); mov(edx, 0xb);                          /* mov edx, 0xb */
        l_0x1017_51f2:
            ii(0x1017_51f2, 7); lea(eax, edx * 4 + 0);                  /* lea eax, [edx*4] */
            ii(0x1017_51f9, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_51fb, 5); mov(edi, 0xffff_ffff);                  /* mov edi, 0xffffffff */
            ii(0x1017_5200, 6); mov(edx, memd[ds, 0x1020_9540]);        /* mov edx, [0x10209540] */
            ii(0x1017_5206, 8); mov(memw[ds, eax * 2 + 0x1020_8a46], di); /* mov [eax*2+0x10208a46], di */
            ii(0x1017_520e, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1017_5210, 2); if(jnz(0x1017_5219, 0x7)) goto l_0x1017_5219; /* jnz 0x10175219 */
            ii(0x1017_5212, 5); mov(edx, 0xd);                          /* mov edx, 0xd */
            ii(0x1017_5217, 2); jmp(0x1017_5232, 0x19); goto l_0x1017_5232; /* jmp 0x10175232 */
        l_0x1017_5219:
            ii(0x1017_5219, 3); cmp(edx, 0x1);                          /* cmp edx, 0x1 */
            ii(0x1017_521c, 2); if(jnz(0x1017_5225, 0x7)) goto l_0x1017_5225; /* jnz 0x10175225 */
            ii(0x1017_521e, 5); mov(edx, 0xd);                          /* mov edx, 0xd */
            ii(0x1017_5223, 2); jmp(0x1017_5232, 0xd); goto l_0x1017_5232; /* jmp 0x10175232 */
        l_0x1017_5225:
            ii(0x1017_5225, 3); cmp(edx, 0x4);                          /* cmp edx, 0x4 */
            ii(0x1017_5228, 2); if(jz(0x1017_522d, 0x3)) goto l_0x1017_522d; /* jz 0x1017522d */
            ii(0x1017_522a, 3); cmp(edx, 0x3);                          /* cmp edx, 0x3 */
        l_0x1017_522d:
            ii(0x1017_522d, 5); mov(edx, 0xb);                          /* mov edx, 0xb */
        l_0x1017_5232:
            ii(0x1017_5232, 7); lea(eax, edx * 4 + 0);                  /* lea eax, [edx*4] */
            ii(0x1017_5239, 5); mov(ebx, 0x8);                          /* mov ebx, 0x8 */
            ii(0x1017_523e, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_5240, 5); mov(edx, 0xffff_ffff);                  /* mov edx, 0xffffffff */
            ii(0x1017_5245, 6); mov(edi, memd[ds, 0x1020_9540]);        /* mov edi, [0x10209540] */
            ii(0x1017_524b, 8); mov(memw[ds, eax * 2 + 0x1020_8a48], dx); /* mov [eax*2+0x10208a48], dx */
            ii(0x1017_5253, 5); mov(eax, 0x7f);                         /* mov eax, 0x7f */
            ii(0x1017_5258, 5); mov(edx, 0x9);                          /* mov edx, 0x9 */
            ii(0x1017_525d, 7); mov(memw[ds, 0x1020_8acc], bx);         /* mov [0x10208acc], bx */
            ii(0x1017_5264, 7); mov(memw[ds, 0x1020_8ace], bx);         /* mov [0x10208ace], bx */
            ii(0x1017_526b, 7); mov(memw[ds, 0x1020_8ad0], bx);         /* mov [0x10208ad0], bx */
            ii(0x1017_5272, 7); mov(memw[ds, 0x1020_8ad2], bx);         /* mov [0x10208ad2], bx */
            ii(0x1017_5279, 6); mov(memw[ds, 0x1020_8ad4], ax);         /* mov [0x10208ad4], ax */
            ii(0x1017_527f, 7); mov(memw[ds, 0x1020_8ad6], dx);         /* mov [0x10208ad6], dx */
            ii(0x1017_5286, 7); mov(memw[ds, 0x1020_8ad8], dx);         /* mov [0x10208ad8], dx */
            ii(0x1017_528d, 7); mov(memw[ds, 0x1020_8ada], dx);         /* mov [0x10208ada], dx */
            ii(0x1017_5294, 7); mov(memw[ds, 0x1020_8adc], dx);         /* mov [0x10208adc], dx */
            ii(0x1017_529b, 7); mov(memw[ds, 0x1020_8ade], dx);         /* mov [0x10208ade], dx */
            ii(0x1017_52a2, 2); test(edi, edi);                         /* test edi, edi */
            ii(0x1017_52a4, 2); if(jnz(0x1017_52ad, 0x7)) goto l_0x1017_52ad; /* jnz 0x101752ad */
            ii(0x1017_52a6, 5); mov(edx, 0x10);                         /* mov edx, 0x10 */
            ii(0x1017_52ab, 2); jmp(0x1017_52c8, 0x1b); goto l_0x1017_52c8; /* jmp 0x101752c8 */
        l_0x1017_52ad:
            ii(0x1017_52ad, 3); cmp(edi, 0x1);                          /* cmp edi, 0x1 */
            ii(0x1017_52b0, 2); if(jnz(0x1017_52b9, 0x7)) goto l_0x1017_52b9; /* jnz 0x101752b9 */
            ii(0x1017_52b2, 5); mov(eax, 0x1e);                         /* mov eax, 0x1e */
            ii(0x1017_52b7, 2); jmp(0x1017_52c6, 0xd); goto l_0x1017_52c6; /* jmp 0x101752c6 */
        l_0x1017_52b9:
            ii(0x1017_52b9, 3); cmp(edi, 0x4);                          /* cmp edi, 0x4 */
            ii(0x1017_52bc, 2); if(jz(0x1017_52c1, 0x3)) goto l_0x1017_52c1; /* jz 0x101752c1 */
            ii(0x1017_52be, 3); cmp(edi, 0x3);                          /* cmp edi, 0x3 */
        l_0x1017_52c1:
            ii(0x1017_52c1, 5); mov(eax, 0x10);                         /* mov eax, 0x10 */
        l_0x1017_52c6:
            ii(0x1017_52c6, 2); mov(edx, eax);                          /* mov edx, eax */
        l_0x1017_52c8:
            ii(0x1017_52c8, 7); lea(eax, edx * 4 + 0);                  /* lea eax, [edx*4] */
            ii(0x1017_52cf, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_52d1, 5); mov(edx, 0x71);                         /* mov edx, 0x71 */
            ii(0x1017_52d6, 6); mov(ebx, memd[ds, 0x1020_9540]);        /* mov ebx, [0x10209540] */
            ii(0x1017_52dc, 8); mov(memw[ds, eax * 2 + 0x1020_8a40], dx); /* mov [eax*2+0x10208a40], dx */
            ii(0x1017_52e4, 2); test(ebx, ebx);                         /* test ebx, ebx */
            ii(0x1017_52e6, 2); if(jnz(0x1017_52ef, 0x7)) goto l_0x1017_52ef; /* jnz 0x101752ef */
            ii(0x1017_52e8, 5); mov(edx, 0x10);                         /* mov edx, 0x10 */
            ii(0x1017_52ed, 2); jmp(0x1017_530a, 0x1b); goto l_0x1017_530a; /* jmp 0x1017530a */
        l_0x1017_52ef:
            ii(0x1017_52ef, 3); cmp(ebx, 0x1);                          /* cmp ebx, 0x1 */
            ii(0x1017_52f2, 2); if(jnz(0x1017_52fb, 0x7)) goto l_0x1017_52fb; /* jnz 0x101752fb */
            ii(0x1017_52f4, 5); mov(eax, 0x1e);                         /* mov eax, 0x1e */
            ii(0x1017_52f9, 2); jmp(0x1017_5308, 0xd); goto l_0x1017_5308; /* jmp 0x10175308 */
        l_0x1017_52fb:
            ii(0x1017_52fb, 3); cmp(ebx, 0x4);                          /* cmp ebx, 0x4 */
            ii(0x1017_52fe, 2); if(jz(0x1017_5303, 0x3)) goto l_0x1017_5303; /* jz 0x10175303 */
            ii(0x1017_5300, 3); cmp(ebx, 0x3);                          /* cmp ebx, 0x3 */
        l_0x1017_5303:
            ii(0x1017_5303, 5); mov(eax, 0x10);                         /* mov eax, 0x10 */
        l_0x1017_5308:
            ii(0x1017_5308, 2); mov(edx, eax);                          /* mov edx, eax */
        l_0x1017_530a:
            ii(0x1017_530a, 7); lea(eax, edx * 4 + 0);                  /* lea eax, [edx*4] */
            ii(0x1017_5311, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_5313, 5); mov(ebx, 0x51);                         /* mov ebx, 0x51 */
            ii(0x1017_5318, 6); mov(ebp, memd[ds, 0x1020_9540]);        /* mov ebp, [0x10209540] */
            ii(0x1017_531e, 8); mov(memw[ds, eax * 2 + 0x1020_8a42], bx); /* mov [eax*2+0x10208a42], bx */
            ii(0x1017_5326, 2); test(ebp, ebp);                         /* test ebp, ebp */
            ii(0x1017_5328, 2); if(jz(0x1017_533e, 0x14)) goto l_0x1017_533e; /* jz 0x1017533e */
            ii(0x1017_532a, 3); cmp(ebp, 0x1);                          /* cmp ebp, 0x1 */
            ii(0x1017_532d, 2); if(jnz(0x1017_5336, 0x7)) goto l_0x1017_5336; /* jnz 0x10175336 */
            ii(0x1017_532f, 5); mov(eax, 0x1e);                         /* mov eax, 0x1e */
            ii(0x1017_5334, 2); jmp(0x1017_5343, 0xd); goto l_0x1017_5343; /* jmp 0x10175343 */
        l_0x1017_5336:
            ii(0x1017_5336, 3); cmp(ebp, 0x4);                          /* cmp ebp, 0x4 */
            ii(0x1017_5339, 2); if(jz(0x1017_533e, 0x3)) goto l_0x1017_533e; /* jz 0x1017533e */
            ii(0x1017_533b, 3); cmp(ebp, 0x3);                          /* cmp ebp, 0x3 */
        l_0x1017_533e:
            ii(0x1017_533e, 5); mov(eax, 0x10);                         /* mov eax, 0x10 */
        l_0x1017_5343:
            ii(0x1017_5343, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1017_5345, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1017_5348, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_534a, 10); mov(memw[ds, eax * 2 + 0x1020_8a44], 0x110); /* mov word [eax*2+0x10208a44], 0x110 */
            ii(0x1017_5354, 6); mov(ecx, memd[ds, 0x1020_9540]);        /* mov ecx, [0x10209540] */
            ii(0x1017_535a, 2); test(ecx, ecx);                         /* test ecx, ecx */
            ii(0x1017_535c, 2); if(jz(0x1017_5372, 0x14)) goto l_0x1017_5372; /* jz 0x10175372 */
            ii(0x1017_535e, 3); cmp(ecx, 0x1);                          /* cmp ecx, 0x1 */
            ii(0x1017_5361, 2); if(jnz(0x1017_536a, 0x7)) goto l_0x1017_536a; /* jnz 0x1017536a */
            ii(0x1017_5363, 5); mov(eax, 0x1e);                         /* mov eax, 0x1e */
            ii(0x1017_5368, 2); jmp(0x1017_5377, 0xd); goto l_0x1017_5377; /* jmp 0x10175377 */
        l_0x1017_536a:
            ii(0x1017_536a, 3); cmp(ecx, 0x4);                          /* cmp ecx, 0x4 */
            ii(0x1017_536d, 2); if(jz(0x1017_5372, 0x3)) goto l_0x1017_5372; /* jz 0x10175372 */
            ii(0x1017_536f, 3); cmp(ecx, 0x3);                          /* cmp ecx, 0x3 */
        l_0x1017_5372:
            ii(0x1017_5372, 5); mov(eax, 0x10);                         /* mov eax, 0x10 */
        l_0x1017_5377:
            ii(0x1017_5377, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1017_5379, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1017_537c, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_537e, 10); mov(memw[ds, eax * 2 + 0x1020_8a46], 0x110); /* mov word [eax*2+0x10208a46], 0x110 */
            ii(0x1017_5388, 5); mov(eax, memd[ds, 0x1020_9540]);        /* mov eax, [0x10209540] */
            ii(0x1017_538d, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_538f, 2); if(jz(0x1017_53a5, 0x14)) goto l_0x1017_53a5; /* jz 0x101753a5 */
            ii(0x1017_5391, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1017_5394, 2); if(jnz(0x1017_539d, 0x7)) goto l_0x1017_539d; /* jnz 0x1017539d */
            ii(0x1017_5396, 5); mov(eax, 0x1e);                         /* mov eax, 0x1e */
            ii(0x1017_539b, 2); jmp(0x1017_53aa, 0xd); goto l_0x1017_53aa; /* jmp 0x101753aa */
        l_0x1017_539d:
            ii(0x1017_539d, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x1017_53a0, 2); if(jz(0x1017_53a5, 0x3)) goto l_0x1017_53a5; /* jz 0x101753a5 */
            ii(0x1017_53a2, 3); cmp(eax, 0x3);                          /* cmp eax, 0x3 */
        l_0x1017_53a5:
            ii(0x1017_53a5, 5); mov(eax, 0x10);                         /* mov eax, 0x10 */
        l_0x1017_53aa:
            ii(0x1017_53aa, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1017_53ac, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1017_53af, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_53b1, 5); mov(edi, 0x11);                         /* mov edi, 0x11 */
            ii(0x1017_53b6, 6); mov(esi, memd[ds, 0x1020_9540]);        /* mov esi, [0x10209540] */
            ii(0x1017_53bc, 8); mov(memw[ds, eax * 2 + 0x1020_8a48], di); /* mov [eax*2+0x10208a48], di */
            ii(0x1017_53c4, 2); test(esi, esi);                         /* test esi, esi */
            ii(0x1017_53c6, 2); if(jz(0x1017_53dc, 0x14)) goto l_0x1017_53dc; /* jz 0x101753dc */
            ii(0x1017_53c8, 3); cmp(esi, 0x1);                          /* cmp esi, 0x1 */
            ii(0x1017_53cb, 2); if(jnz(0x1017_53d4, 0x7)) goto l_0x1017_53d4; /* jnz 0x101753d4 */
            ii(0x1017_53cd, 5); mov(eax, 0x2c);                         /* mov eax, 0x2c */
            ii(0x1017_53d2, 2); jmp(0x1017_53e1, 0xd); goto l_0x1017_53e1; /* jmp 0x101753e1 */
        l_0x1017_53d4:
            ii(0x1017_53d4, 3); cmp(esi, 0x4);                          /* cmp esi, 0x4 */
            ii(0x1017_53d7, 2); if(jz(0x1017_53dc, 0x3)) goto l_0x1017_53dc; /* jz 0x101753dc */
            ii(0x1017_53d9, 3); cmp(esi, 0x3);                          /* cmp esi, 0x3 */
        l_0x1017_53dc:
            ii(0x1017_53dc, 5); mov(eax, 0x11);                         /* mov eax, 0x11 */
        l_0x1017_53e1:
            ii(0x1017_53e1, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1017_53e3, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1017_53e6, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_53e8, 10); mov(memw[ds, eax * 2 + 0x1020_8a40], 0x77); /* mov word [eax*2+0x10208a40], 0x77 */
            ii(0x1017_53f2, 6); mov(edx, memd[ds, 0x1020_9540]);        /* mov edx, [0x10209540] */
            ii(0x1017_53f8, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1017_53fa, 2); if(jz(0x1017_5410, 0x14)) goto l_0x1017_5410; /* jz 0x10175410 */
            ii(0x1017_53fc, 3); cmp(edx, 0x1);                          /* cmp edx, 0x1 */
            ii(0x1017_53ff, 2); if(jnz(0x1017_5408, 0x7)) goto l_0x1017_5408; /* jnz 0x10175408 */
            ii(0x1017_5401, 5); mov(eax, 0x2c);                         /* mov eax, 0x2c */
            ii(0x1017_5406, 2); jmp(0x1017_5415, 0xd); goto l_0x1017_5415; /* jmp 0x10175415 */
        l_0x1017_5408:
            ii(0x1017_5408, 3); cmp(edx, 0x4);                          /* cmp edx, 0x4 */
            ii(0x1017_540b, 2); if(jz(0x1017_5410, 0x3)) goto l_0x1017_5410; /* jz 0x10175410 */
            ii(0x1017_540d, 3); cmp(edx, 0x3);                          /* cmp edx, 0x3 */
        l_0x1017_5410:
            ii(0x1017_5410, 5); mov(eax, 0x11);                         /* mov eax, 0x11 */
        l_0x1017_5415:
            ii(0x1017_5415, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1017_5417, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1017_541a, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_541c, 5); mov(ebx, 0x57);                         /* mov ebx, 0x57 */
            ii(0x1017_5421, 6); mov(edi, memd[ds, 0x1020_9540]);        /* mov edi, [0x10209540] */
            ii(0x1017_5427, 8); mov(memw[ds, eax * 2 + 0x1020_8a42], bx); /* mov [eax*2+0x10208a42], bx */
            ii(0x1017_542f, 2); test(edi, edi);                         /* test edi, edi */
            ii(0x1017_5431, 2); if(jz(0x1017_5447, 0x14)) goto l_0x1017_5447; /* jz 0x10175447 */
            ii(0x1017_5433, 3); cmp(edi, 0x1);                          /* cmp edi, 0x1 */
            ii(0x1017_5436, 2); if(jnz(0x1017_543f, 0x7)) goto l_0x1017_543f; /* jnz 0x1017543f */
            ii(0x1017_5438, 5); mov(eax, 0x2c);                         /* mov eax, 0x2c */
            ii(0x1017_543d, 2); jmp(0x1017_544c, 0xd); goto l_0x1017_544c; /* jmp 0x1017544c */
        l_0x1017_543f:
            ii(0x1017_543f, 3); cmp(edi, 0x4);                          /* cmp edi, 0x4 */
            ii(0x1017_5442, 2); if(jz(0x1017_5447, 0x3)) goto l_0x1017_5447; /* jz 0x10175447 */
            ii(0x1017_5444, 3); cmp(edi, 0x3);                          /* cmp edi, 0x3 */
        l_0x1017_5447:
            ii(0x1017_5447, 5); mov(eax, 0x11);                         /* mov eax, 0x11 */
        l_0x1017_544c:
            ii(0x1017_544c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1017_544e, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1017_5451, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_5453, 5); mov(ecx, 0x111);                        /* mov ecx, 0x111 */
            ii(0x1017_5458, 6); mov(ebx, memd[ds, 0x1020_9540]);        /* mov ebx, [0x10209540] */
            ii(0x1017_545e, 8); mov(memw[ds, eax * 2 + 0x1020_8a44], cx); /* mov [eax*2+0x10208a44], cx */
            ii(0x1017_5466, 2); test(ebx, ebx);                         /* test ebx, ebx */
            ii(0x1017_5468, 2); if(jz(0x1017_547e, 0x14)) goto l_0x1017_547e; /* jz 0x1017547e */
            ii(0x1017_546a, 3); cmp(ebx, 0x1);                          /* cmp ebx, 0x1 */
            ii(0x1017_546d, 2); if(jnz(0x1017_5476, 0x7)) goto l_0x1017_5476; /* jnz 0x10175476 */
            ii(0x1017_546f, 5); mov(eax, 0x2c);                         /* mov eax, 0x2c */
            ii(0x1017_5474, 2); jmp(0x1017_5483, 0xd); goto l_0x1017_5483; /* jmp 0x10175483 */
        l_0x1017_5476:
            ii(0x1017_5476, 3); cmp(ebx, 0x4);                          /* cmp ebx, 0x4 */
            ii(0x1017_5479, 2); if(jz(0x1017_547e, 0x3)) goto l_0x1017_547e; /* jz 0x1017547e */
            ii(0x1017_547b, 3); cmp(ebx, 0x3);                          /* cmp ebx, 0x3 */
        l_0x1017_547e:
            ii(0x1017_547e, 5); mov(eax, 0x11);                         /* mov eax, 0x11 */
        l_0x1017_5483:
            ii(0x1017_5483, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1017_5485, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1017_5488, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_548a, 5); mov(esi, 0x111);                        /* mov esi, 0x111 */
            ii(0x1017_548f, 6); mov(ebp, memd[ds, 0x1020_9540]);        /* mov ebp, [0x10209540] */
            ii(0x1017_5495, 8); mov(memw[ds, eax * 2 + 0x1020_8a46], si); /* mov [eax*2+0x10208a46], si */
            ii(0x1017_549d, 2); test(ebp, ebp);                         /* test ebp, ebp */
            ii(0x1017_549f, 2); if(jnz(0x1017_54a8, 0x7)) goto l_0x1017_54a8; /* jnz 0x101754a8 */
            ii(0x1017_54a1, 5); mov(edx, 0x11);                         /* mov edx, 0x11 */
            ii(0x1017_54a6, 2); jmp(0x1017_54c3, 0x1b); goto l_0x1017_54c3; /* jmp 0x101754c3 */
        l_0x1017_54a8:
            ii(0x1017_54a8, 3); cmp(ebp, 0x1);                          /* cmp ebp, 0x1 */
            ii(0x1017_54ab, 2); if(jnz(0x1017_54b4, 0x7)) goto l_0x1017_54b4; /* jnz 0x101754b4 */
            ii(0x1017_54ad, 5); mov(eax, 0x2c);                         /* mov eax, 0x2c */
            ii(0x1017_54b2, 2); jmp(0x1017_54c1, 0xd); goto l_0x1017_54c1; /* jmp 0x101754c1 */
        l_0x1017_54b4:
            ii(0x1017_54b4, 3); cmp(ebp, 0x4);                          /* cmp ebp, 0x4 */
            ii(0x1017_54b7, 2); if(jz(0x1017_54bc, 0x3)) goto l_0x1017_54bc; /* jz 0x101754bc */
            ii(0x1017_54b9, 3); cmp(ebp, 0x3);                          /* cmp ebp, 0x3 */
        l_0x1017_54bc:
            ii(0x1017_54bc, 5); mov(eax, 0x11);                         /* mov eax, 0x11 */
        l_0x1017_54c1:
            ii(0x1017_54c1, 2); mov(edx, eax);                          /* mov edx, eax */
        l_0x1017_54c3:
            ii(0x1017_54c3, 5); mov(edi, 0x17);                         /* mov edi, 0x17 */
            ii(0x1017_54c8, 5); mov(ebx, 0x112);                        /* mov ebx, 0x112 */
            ii(0x1017_54cd, 7); lea(eax, edx * 4 + 0);                  /* lea eax, [edx*4] */
            ii(0x1017_54d4, 5); mov(esi, 0x5);                          /* mov esi, 0x5 */
            ii(0x1017_54d9, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_54db, 5); mov(ecx, 0x12);                         /* mov ecx, 0x12 */
            ii(0x1017_54e0, 5); mov(edx, 0x45);                         /* mov edx, 0x45 */
            ii(0x1017_54e5, 8); mov(memw[ds, eax * 2 + 0x1020_8a48], di); /* mov [eax*2+0x10208a48], di */
            ii(0x1017_54ed, 5); mov(eax, 0x65);                         /* mov eax, 0x65 */
            ii(0x1017_54f2, 5); mov(edi, 0x72);                         /* mov edi, 0x72 */
            ii(0x1017_54f7, 7); mov(memw[ds, 0x1020_8af6], dx);         /* mov [0x10208af6], dx */
            ii(0x1017_54fe, 7); mov(memw[ds, 0x1020_8af8], bx);         /* mov [0x10208af8], bx */
            ii(0x1017_5505, 7); mov(memw[ds, 0x1020_8afa], bx);         /* mov [0x10208afa], bx */
            ii(0x1017_550c, 7); mov(memw[ds, 0x1020_8afc], si);         /* mov [0x10208afc], si */
            ii(0x1017_5513, 7); mov(memw[ds, 0x1020_8b06], cx);         /* mov [0x10208b06], cx */
            ii(0x1017_551a, 5); mov(edx, 0x113);                        /* mov edx, 0x113 */
            ii(0x1017_551f, 5); mov(esi, 0x74);                         /* mov esi, 0x74 */
            ii(0x1017_5524, 5); mov(ebx, 0x14);                         /* mov ebx, 0x14 */
            ii(0x1017_5529, 6); mov(ecx, memd[ds, 0x1020_9540]);        /* mov ecx, [0x10209540] */
            ii(0x1017_552f, 6); mov(memw[ds, 0x1020_8af4], ax);         /* mov [0x10208af4], ax */
            ii(0x1017_5535, 7); mov(memw[ds, 0x1020_8afe], di);         /* mov [0x10208afe], di */
            ii(0x1017_553c, 5); mov(eax, 0x52);                         /* mov eax, 0x52 */
            ii(0x1017_5541, 5); mov(edi, 0x54);                         /* mov edi, 0x54 */
            ii(0x1017_5546, 7); mov(memw[ds, 0x1020_8b02], dx);         /* mov [0x10208b02], dx */
            ii(0x1017_554d, 7); mov(memw[ds, 0x1020_8b04], dx);         /* mov [0x10208b04], dx */
            ii(0x1017_5554, 7); mov(memw[ds, 0x1020_8b08], si);         /* mov [0x10208b08], si */
            ii(0x1017_555b, 7); mov(memw[ds, 0x1020_8b10], bx);         /* mov [0x10208b10], bx */
            ii(0x1017_5562, 6); mov(memw[ds, 0x1020_8b00], ax);         /* mov [0x10208b00], ax */
            ii(0x1017_5568, 5); mov(eax, 0x114);                        /* mov eax, 0x114 */
            ii(0x1017_556d, 7); mov(memw[ds, 0x1020_8b0a], di);         /* mov [0x10208b0a], di */
            ii(0x1017_5574, 6); mov(memw[ds, 0x1020_8b0c], ax);         /* mov [0x10208b0c], ax */
            ii(0x1017_557a, 6); mov(memw[ds, 0x1020_8b0e], ax);         /* mov [0x10208b0e], ax */
            ii(0x1017_5580, 2); test(ecx, ecx);                         /* test ecx, ecx */
            ii(0x1017_5582, 2); if(jnz(0x1017_558b, 0x7)) goto l_0x1017_558b; /* jnz 0x1017558b */
            ii(0x1017_5584, 5); mov(edx, 0x15);                         /* mov edx, 0x15 */
            ii(0x1017_5589, 2); jmp(0x1017_55b6, 0x2b); goto l_0x1017_55b6; /* jmp 0x101755b6 */
        l_0x1017_558b:
            ii(0x1017_558b, 3); cmp(ecx, 0x1);                          /* cmp ecx, 0x1 */
            ii(0x1017_558e, 2); if(jnz(0x1017_5597, 0x7)) goto l_0x1017_5597; /* jnz 0x10175597 */
            ii(0x1017_5590, 5); mov(eax, 0x15);                         /* mov eax, 0x15 */
            ii(0x1017_5595, 2); jmp(0x1017_55b4, 0x1d); goto l_0x1017_55b4; /* jmp 0x101755b4 */
        l_0x1017_5597:
            ii(0x1017_5597, 3); cmp(ecx, 0x4);                          /* cmp ecx, 0x4 */
            ii(0x1017_559a, 2); if(jnz(0x1017_55a3, 0x7)) goto l_0x1017_55a3; /* jnz 0x101755a3 */
            ii(0x1017_559c, 5); mov(eax, 0x15);                         /* mov eax, 0x15 */
            ii(0x1017_55a1, 2); jmp(0x1017_55b4, 0x11); goto l_0x1017_55b4; /* jmp 0x101755b4 */
        l_0x1017_55a3:
            ii(0x1017_55a3, 3); cmp(ecx, 0x3);                          /* cmp ecx, 0x3 */
            ii(0x1017_55a6, 2); if(jnz(0x1017_55af, 0x7)) goto l_0x1017_55af; /* jnz 0x101755af */
            ii(0x1017_55a8, 5); mov(eax, 0x15);                         /* mov eax, 0x15 */
            ii(0x1017_55ad, 2); jmp(0x1017_55b4, 0x5); goto l_0x1017_55b4; /* jmp 0x101755b4 */
        l_0x1017_55af:
            ii(0x1017_55af, 5); mov(eax, 0x2c);                         /* mov eax, 0x2c */
        l_0x1017_55b4:
            ii(0x1017_55b4, 2); mov(edx, eax);                          /* mov edx, eax */
        l_0x1017_55b6:
            ii(0x1017_55b6, 7); lea(eax, edx * 4 + 0);                  /* lea eax, [edx*4] */
            ii(0x1017_55bd, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_55bf, 10); mov(memw[ds, eax * 2 + 0x1020_8a40], 0x79); /* mov word [eax*2+0x10208a40], 0x79 */
            ii(0x1017_55c9, 5); mov(eax, memd[ds, 0x1020_9540]);        /* mov eax, [0x10209540] */
            ii(0x1017_55ce, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_55d0, 2); if(jnz(0x1017_55d9, 0x7)) goto l_0x1017_55d9; /* jnz 0x101755d9 */
            ii(0x1017_55d2, 5); mov(edx, 0x15);                         /* mov edx, 0x15 */
            ii(0x1017_55d7, 2); jmp(0x1017_5602, 0x29); goto l_0x1017_5602; /* jmp 0x10175602 */
        l_0x1017_55d9:
            ii(0x1017_55d9, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1017_55dc, 2); if(jnz(0x1017_55e5, 0x7)) goto l_0x1017_55e5; /* jnz 0x101755e5 */
            ii(0x1017_55de, 5); mov(edx, 0x15);                         /* mov edx, 0x15 */
            ii(0x1017_55e3, 2); jmp(0x1017_5602, 0x1d); goto l_0x1017_5602; /* jmp 0x10175602 */
        l_0x1017_55e5:
            ii(0x1017_55e5, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x1017_55e8, 2); if(jnz(0x1017_55f1, 0x7)) goto l_0x1017_55f1; /* jnz 0x101755f1 */
            ii(0x1017_55ea, 5); mov(edx, 0x15);                         /* mov edx, 0x15 */
            ii(0x1017_55ef, 2); jmp(0x1017_5602, 0x11); goto l_0x1017_5602; /* jmp 0x10175602 */
        l_0x1017_55f1:
            ii(0x1017_55f1, 3); cmp(eax, 0x3);                          /* cmp eax, 0x3 */
            ii(0x1017_55f4, 2); if(jnz(0x1017_55fd, 0x7)) goto l_0x1017_55fd; /* jnz 0x101755fd */
            ii(0x1017_55f6, 5); mov(edx, 0x15);                         /* mov edx, 0x15 */
            ii(0x1017_55fb, 2); jmp(0x1017_5602, 0x5); goto l_0x1017_5602; /* jmp 0x10175602 */
        l_0x1017_55fd:
            ii(0x1017_55fd, 5); mov(edx, 0x2c);                         /* mov edx, 0x2c */
        l_0x1017_5602:
            ii(0x1017_5602, 7); lea(eax, edx * 4 + 0);                  /* lea eax, [edx*4] */
            ii(0x1017_5609, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_560b, 10); mov(memw[ds, eax * 2 + 0x1020_8a42], 0x59); /* mov word [eax*2+0x10208a42], 0x59 */
            ii(0x1017_5615, 6); mov(esi, memd[ds, 0x1020_9540]);        /* mov esi, [0x10209540] */
            ii(0x1017_561b, 2); test(esi, esi);                         /* test esi, esi */
            ii(0x1017_561d, 2); if(jnz(0x1017_5626, 0x7)) goto l_0x1017_5626; /* jnz 0x10175626 */
            ii(0x1017_561f, 5); mov(edx, 0x15);                         /* mov edx, 0x15 */
            ii(0x1017_5624, 2); jmp(0x1017_564f, 0x29); goto l_0x1017_564f; /* jmp 0x1017564f */
        l_0x1017_5626:
            ii(0x1017_5626, 3); cmp(esi, 0x1);                          /* cmp esi, 0x1 */
            ii(0x1017_5629, 2); if(jnz(0x1017_5632, 0x7)) goto l_0x1017_5632; /* jnz 0x10175632 */
            ii(0x1017_562b, 5); mov(edx, 0x15);                         /* mov edx, 0x15 */
            ii(0x1017_5630, 2); jmp(0x1017_564f, 0x1d); goto l_0x1017_564f; /* jmp 0x1017564f */
        l_0x1017_5632:
            ii(0x1017_5632, 3); cmp(esi, 0x4);                          /* cmp esi, 0x4 */
            ii(0x1017_5635, 2); if(jnz(0x1017_563e, 0x7)) goto l_0x1017_563e; /* jnz 0x1017563e */
            ii(0x1017_5637, 5); mov(edx, 0x15);                         /* mov edx, 0x15 */
            ii(0x1017_563c, 2); jmp(0x1017_564f, 0x11); goto l_0x1017_564f; /* jmp 0x1017564f */
        l_0x1017_563e:
            ii(0x1017_563e, 3); cmp(esi, 0x3);                          /* cmp esi, 0x3 */
            ii(0x1017_5641, 2); if(jnz(0x1017_564a, 0x7)) goto l_0x1017_564a; /* jnz 0x1017564a */
            ii(0x1017_5643, 5); mov(edx, 0x15);                         /* mov edx, 0x15 */
            ii(0x1017_5648, 2); jmp(0x1017_564f, 0x5); goto l_0x1017_564f; /* jmp 0x1017564f */
        l_0x1017_564a:
            ii(0x1017_564a, 5); mov(edx, 0x2c);                         /* mov edx, 0x2c */
        l_0x1017_564f:
            ii(0x1017_564f, 7); lea(eax, edx * 4 + 0);                  /* lea eax, [edx*4] */
            ii(0x1017_5656, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_5658, 5); mov(edi, 0x115);                        /* mov edi, 0x115 */
            ii(0x1017_565d, 6); mov(edx, memd[ds, 0x1020_9540]);        /* mov edx, [0x10209540] */
            ii(0x1017_5663, 8); mov(memw[ds, eax * 2 + 0x1020_8a44], di); /* mov [eax*2+0x10208a44], di */
            ii(0x1017_566b, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1017_566d, 2); if(jnz(0x1017_5676, 0x7)) goto l_0x1017_5676; /* jnz 0x10175676 */
            ii(0x1017_566f, 5); mov(edx, 0x15);                         /* mov edx, 0x15 */
            ii(0x1017_5674, 2); jmp(0x1017_569f, 0x29); goto l_0x1017_569f; /* jmp 0x1017569f */
        l_0x1017_5676:
            ii(0x1017_5676, 3); cmp(edx, 0x1);                          /* cmp edx, 0x1 */
            ii(0x1017_5679, 2); if(jnz(0x1017_5682, 0x7)) goto l_0x1017_5682; /* jnz 0x10175682 */
            ii(0x1017_567b, 5); mov(edx, 0x15);                         /* mov edx, 0x15 */
            ii(0x1017_5680, 2); jmp(0x1017_569f, 0x1d); goto l_0x1017_569f; /* jmp 0x1017569f */
        l_0x1017_5682:
            ii(0x1017_5682, 3); cmp(edx, 0x4);                          /* cmp edx, 0x4 */
            ii(0x1017_5685, 2); if(jnz(0x1017_568e, 0x7)) goto l_0x1017_568e; /* jnz 0x1017568e */
            ii(0x1017_5687, 5); mov(edx, 0x15);                         /* mov edx, 0x15 */
            ii(0x1017_568c, 2); jmp(0x1017_569f, 0x11); goto l_0x1017_569f; /* jmp 0x1017569f */
        l_0x1017_568e:
            ii(0x1017_568e, 3); cmp(edx, 0x3);                          /* cmp edx, 0x3 */
            ii(0x1017_5691, 2); if(jnz(0x1017_569a, 0x7)) goto l_0x1017_569a; /* jnz 0x1017569a */
            ii(0x1017_5693, 5); mov(edx, 0x15);                         /* mov edx, 0x15 */
            ii(0x1017_5698, 2); jmp(0x1017_569f, 0x5); goto l_0x1017_569f; /* jmp 0x1017569f */
        l_0x1017_569a:
            ii(0x1017_569a, 5); mov(edx, 0x2c);                         /* mov edx, 0x2c */
        l_0x1017_569f:
            ii(0x1017_569f, 7); lea(eax, edx * 4 + 0);                  /* lea eax, [edx*4] */
            ii(0x1017_56a6, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_56a8, 5); mov(edx, 0x115);                        /* mov edx, 0x115 */
            ii(0x1017_56ad, 6); mov(edi, memd[ds, 0x1020_9540]);        /* mov edi, [0x10209540] */
            ii(0x1017_56b3, 8); mov(memw[ds, eax * 2 + 0x1020_8a46], dx); /* mov [eax*2+0x10208a46], dx */
            ii(0x1017_56bb, 2); test(edi, edi);                         /* test edi, edi */
            ii(0x1017_56bd, 2); if(jnz(0x1017_56c6, 0x7)) goto l_0x1017_56c6; /* jnz 0x101756c6 */
            ii(0x1017_56bf, 5); mov(edx, 0x15);                         /* mov edx, 0x15 */
            ii(0x1017_56c4, 2); jmp(0x1017_56ef, 0x29); goto l_0x1017_56ef; /* jmp 0x101756ef */
        l_0x1017_56c6:
            ii(0x1017_56c6, 3); cmp(edi, 0x1);                          /* cmp edi, 0x1 */
            ii(0x1017_56c9, 2); if(jnz(0x1017_56d2, 0x7)) goto l_0x1017_56d2; /* jnz 0x101756d2 */
            ii(0x1017_56cb, 5); mov(edx, 0x15);                         /* mov edx, 0x15 */
            ii(0x1017_56d0, 2); jmp(0x1017_56ef, 0x1d); goto l_0x1017_56ef; /* jmp 0x101756ef */
        l_0x1017_56d2:
            ii(0x1017_56d2, 3); cmp(edi, 0x4);                          /* cmp edi, 0x4 */
            ii(0x1017_56d5, 2); if(jnz(0x1017_56de, 0x7)) goto l_0x1017_56de; /* jnz 0x101756de */
            ii(0x1017_56d7, 5); mov(edx, 0x15);                         /* mov edx, 0x15 */
            ii(0x1017_56dc, 2); jmp(0x1017_56ef, 0x11); goto l_0x1017_56ef; /* jmp 0x101756ef */
        l_0x1017_56de:
            ii(0x1017_56de, 3); cmp(edi, 0x3);                          /* cmp edi, 0x3 */
            ii(0x1017_56e1, 2); if(jnz(0x1017_56ea, 0x7)) goto l_0x1017_56ea; /* jnz 0x101756ea */
            ii(0x1017_56e3, 5); mov(edx, 0x15);                         /* mov edx, 0x15 */
            ii(0x1017_56e8, 2); jmp(0x1017_56ef, 0x5); goto l_0x1017_56ef; /* jmp 0x101756ef */
        l_0x1017_56ea:
            ii(0x1017_56ea, 5); mov(edx, 0x2c);                         /* mov edx, 0x2c */
        l_0x1017_56ef:
            ii(0x1017_56ef, 5); mov(ebx, 0x19);                         /* mov ebx, 0x19 */
            ii(0x1017_56f4, 5); mov(ecx, 0x75);                         /* mov ecx, 0x75 */
            ii(0x1017_56f9, 7); lea(eax, edx * 4 + 0);                  /* lea eax, [edx*4] */
            ii(0x1017_5700, 5); mov(esi, 0x55);                         /* mov esi, 0x55 */
            ii(0x1017_5705, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_5707, 5); mov(edi, 0x116);                        /* mov edi, 0x116 */
            ii(0x1017_570c, 5); mov(edx, 0x15);                         /* mov edx, 0x15 */
            ii(0x1017_5711, 8); mov(memw[ds, eax * 2 + 0x1020_8a48], bx); /* mov [eax*2+0x10208a48], bx */
            ii(0x1017_5719, 5); mov(ebx, 0x69);                         /* mov ebx, 0x69 */
            ii(0x1017_571e, 5); mov(eax, 0x9);                          /* mov eax, 0x9 */
            ii(0x1017_5723, 7); mov(memw[ds, 0x1020_8b1c], cx);         /* mov [0x10208b1c], cx */
            ii(0x1017_572a, 7); mov(memw[ds, 0x1020_8b1e], si);         /* mov [0x10208b1e], si */
            ii(0x1017_5731, 7); mov(memw[ds, 0x1020_8b20], di);         /* mov [0x10208b20], di */
            ii(0x1017_5738, 7); mov(memw[ds, 0x1020_8b22], di);         /* mov [0x10208b22], di */
            ii(0x1017_573f, 7); mov(memw[ds, 0x1020_8b24], dx);         /* mov [0x10208b24], dx */
            ii(0x1017_5746, 5); mov(ecx, 0x49);                         /* mov ecx, 0x49 */
            ii(0x1017_574b, 5); mov(esi, 0x117);                        /* mov esi, 0x117 */
            ii(0x1017_5750, 5); mov(edx, 0x6f);                         /* mov edx, 0x6f */
            ii(0x1017_5755, 5); mov(edi, 0xf);                          /* mov edi, 0xf */
            ii(0x1017_575a, 7); mov(memw[ds, 0x1020_8b26], bx);         /* mov [0x10208b26], bx */
            ii(0x1017_5761, 6); mov(memw[ds, 0x1020_8b2e], ax);         /* mov [0x10208b2e], ax */
            ii(0x1017_5767, 5); mov(ebx, 0x4f);                         /* mov ebx, 0x4f */
            ii(0x1017_576c, 5); mov(eax, 0x70);                         /* mov eax, 0x70 */
            ii(0x1017_5771, 7); mov(memw[ds, 0x1020_8b28], cx);         /* mov [0x10208b28], cx */
            ii(0x1017_5778, 7); mov(memw[ds, 0x1020_8b2a], si);         /* mov [0x10208b2a], si */
            ii(0x1017_577f, 7); mov(memw[ds, 0x1020_8b2c], si);         /* mov [0x10208b2c], si */
            ii(0x1017_5786, 7); mov(memw[ds, 0x1020_8b30], dx);         /* mov [0x10208b30], dx */
            ii(0x1017_578d, 7); mov(memw[ds, 0x1020_8b38], di);         /* mov [0x10208b38], di */
            ii(0x1017_5794, 5); mov(ecx, 0x118);                        /* mov ecx, 0x118 */
            ii(0x1017_5799, 5); mov(edx, 0x50);                         /* mov edx, 0x50 */
            ii(0x1017_579e, 5); mov(esi, 0x10);                         /* mov esi, 0x10 */
            ii(0x1017_57a3, 7); mov(memw[ds, 0x1020_8b32], bx);         /* mov [0x10208b32], bx */
            ii(0x1017_57aa, 6); mov(memw[ds, 0x1020_8b3a], ax);         /* mov [0x10208b3a], ax */
            ii(0x1017_57b0, 5); mov(ebx, 0x119);                        /* mov ebx, 0x119 */
            ii(0x1017_57b5, 7); mov(memw[ds, 0x1020_8b34], cx);         /* mov [0x10208b34], cx */
            ii(0x1017_57bc, 7); mov(memw[ds, 0x1020_8b36], cx);         /* mov [0x10208b36], cx */
            ii(0x1017_57c3, 7); mov(memw[ds, 0x1020_8b3c], dx);         /* mov [0x10208b3c], dx */
            ii(0x1017_57ca, 7); mov(memw[ds, 0x1020_8b3e], bx);         /* mov [0x10208b3e], bx */
            ii(0x1017_57d1, 7); mov(memw[ds, 0x1020_8b40], bx);         /* mov [0x10208b40], bx */
            ii(0x1017_57d8, 6); mov(ebx, memd[ds, 0x1020_9540]);        /* mov ebx, [0x10209540] */
            ii(0x1017_57de, 7); mov(memw[ds, 0x1020_8b42], si);         /* mov [0x10208b42], si */
            ii(0x1017_57e5, 2); test(ebx, ebx);                         /* test ebx, ebx */
            ii(0x1017_57e7, 2); if(jnz(0x1017_57f0, 0x7)) goto l_0x1017_57f0; /* jnz 0x101757f0 */
            ii(0x1017_57e9, 5); mov(edx, 0x1a);                         /* mov edx, 0x1a */
            ii(0x1017_57ee, 2); jmp(0x1017_5819, 0x29); goto l_0x1017_5819; /* jmp 0x10175819 */
        l_0x1017_57f0:
            ii(0x1017_57f0, 3); cmp(ebx, 0x1);                          /* cmp ebx, 0x1 */
            ii(0x1017_57f3, 2); if(jnz(0x1017_57fc, 0x7)) goto l_0x1017_57fc; /* jnz 0x101757fc */
            ii(0x1017_57f5, 5); mov(edx, 0x6);                          /* mov edx, 0x6 */
            ii(0x1017_57fa, 2); jmp(0x1017_5819, 0x1d); goto l_0x1017_5819; /* jmp 0x10175819 */
        l_0x1017_57fc:
            ii(0x1017_57fc, 3); cmp(ebx, 0x4);                          /* cmp ebx, 0x4 */
            ii(0x1017_57ff, 2); if(jnz(0x1017_5808, 0x7)) goto l_0x1017_5808; /* jnz 0x10175808 */
            ii(0x1017_5801, 5); mov(edx, 0x1a);                         /* mov edx, 0x1a */
            ii(0x1017_5806, 2); jmp(0x1017_5819, 0x11); goto l_0x1017_5819; /* jmp 0x10175819 */
        l_0x1017_5808:
            ii(0x1017_5808, 3); cmp(ebx, 0x3);                          /* cmp ebx, 0x3 */
            ii(0x1017_580b, 2); if(jnz(0x1017_5814, 0x7)) goto l_0x1017_5814; /* jnz 0x10175814 */
            ii(0x1017_580d, 5); mov(edx, 0x1a);                         /* mov edx, 0x1a */
            ii(0x1017_5812, 2); jmp(0x1017_5819, 0x5); goto l_0x1017_5819; /* jmp 0x10175819 */
        l_0x1017_5814:
            ii(0x1017_5814, 5); mov(edx, 0x9);                          /* mov edx, 0x9 */
        l_0x1017_5819:
            ii(0x1017_5819, 7); lea(eax, edx * 4 + 0);                  /* lea eax, [edx*4] */
            ii(0x1017_5820, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_5822, 5); mov(edi, 0x5b);                         /* mov edi, 0x5b */
            ii(0x1017_5827, 6); mov(ebp, memd[ds, 0x1020_9540]);        /* mov ebp, [0x10209540] */
            ii(0x1017_582d, 8); mov(memw[ds, eax * 2 + 0x1020_8a40], di); /* mov [eax*2+0x10208a40], di */
            ii(0x1017_5835, 2); test(ebp, ebp);                         /* test ebp, ebp */
            ii(0x1017_5837, 2); if(jnz(0x1017_5840, 0x7)) goto l_0x1017_5840; /* jnz 0x10175840 */
            ii(0x1017_5839, 5); mov(edx, 0x1a);                         /* mov edx, 0x1a */
            ii(0x1017_583e, 2); jmp(0x1017_5869, 0x29); goto l_0x1017_5869; /* jmp 0x10175869 */
        l_0x1017_5840:
            ii(0x1017_5840, 3); cmp(ebp, 0x1);                          /* cmp ebp, 0x1 */
            ii(0x1017_5843, 2); if(jnz(0x1017_584c, 0x7)) goto l_0x1017_584c; /* jnz 0x1017584c */
            ii(0x1017_5845, 5); mov(edx, 0x6);                          /* mov edx, 0x6 */
            ii(0x1017_584a, 2); jmp(0x1017_5869, 0x1d); goto l_0x1017_5869; /* jmp 0x10175869 */
        l_0x1017_584c:
            ii(0x1017_584c, 3); cmp(ebp, 0x4);                          /* cmp ebp, 0x4 */
            ii(0x1017_584f, 2); if(jnz(0x1017_5858, 0x7)) goto l_0x1017_5858; /* jnz 0x10175858 */
            ii(0x1017_5851, 5); mov(edx, 0x1a);                         /* mov edx, 0x1a */
            ii(0x1017_5856, 2); jmp(0x1017_5869, 0x11); goto l_0x1017_5869; /* jmp 0x10175869 */
        l_0x1017_5858:
            ii(0x1017_5858, 3); cmp(ebp, 0x3);                          /* cmp ebp, 0x3 */
            ii(0x1017_585b, 2); if(jnz(0x1017_5864, 0x7)) goto l_0x1017_5864; /* jnz 0x10175864 */
            ii(0x1017_585d, 5); mov(edx, 0x1a);                         /* mov edx, 0x1a */
            ii(0x1017_5862, 2); jmp(0x1017_5869, 0x5); goto l_0x1017_5869; /* jmp 0x10175869 */
        l_0x1017_5864:
            ii(0x1017_5864, 5); mov(edx, 0x9);                          /* mov edx, 0x9 */
        l_0x1017_5869:
            ii(0x1017_5869, 7); lea(eax, edx * 4 + 0);                  /* lea eax, [edx*4] */
            ii(0x1017_5870, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_5872, 5); mov(edx, 0x7b);                         /* mov edx, 0x7b */
            ii(0x1017_5877, 6); mov(ecx, memd[ds, 0x1020_9540]);        /* mov ecx, [0x10209540] */
            ii(0x1017_587d, 8); mov(memw[ds, eax * 2 + 0x1020_8a42], dx); /* mov [eax*2+0x10208a42], dx */
            ii(0x1017_5885, 2); test(ecx, ecx);                         /* test ecx, ecx */
            ii(0x1017_5887, 2); if(jnz(0x1017_5890, 0x7)) goto l_0x1017_5890; /* jnz 0x10175890 */
            ii(0x1017_5889, 5); mov(edx, 0x1a);                         /* mov edx, 0x1a */
            ii(0x1017_588e, 2); jmp(0x1017_58b9, 0x29); goto l_0x1017_58b9; /* jmp 0x101758b9 */
        l_0x1017_5890:
            ii(0x1017_5890, 3); cmp(ecx, 0x1);                          /* cmp ecx, 0x1 */
            ii(0x1017_5893, 2); if(jnz(0x1017_589c, 0x7)) goto l_0x1017_589c; /* jnz 0x1017589c */
            ii(0x1017_5895, 5); mov(edx, 0x6);                          /* mov edx, 0x6 */
            ii(0x1017_589a, 2); jmp(0x1017_58b9, 0x1d); goto l_0x1017_58b9; /* jmp 0x101758b9 */
        l_0x1017_589c:
            ii(0x1017_589c, 3); cmp(ecx, 0x4);                          /* cmp ecx, 0x4 */
            ii(0x1017_589f, 2); if(jnz(0x1017_58a8, 0x7)) goto l_0x1017_58a8; /* jnz 0x101758a8 */
            ii(0x1017_58a1, 5); mov(edx, 0x1a);                         /* mov edx, 0x1a */
            ii(0x1017_58a6, 2); jmp(0x1017_58b9, 0x11); goto l_0x1017_58b9; /* jmp 0x101758b9 */
        l_0x1017_58a8:
            ii(0x1017_58a8, 3); cmp(ecx, 0x3);                          /* cmp ecx, 0x3 */
            ii(0x1017_58ab, 2); if(jnz(0x1017_58b4, 0x7)) goto l_0x1017_58b4; /* jnz 0x101758b4 */
            ii(0x1017_58ad, 5); mov(edx, 0x1a);                         /* mov edx, 0x1a */
            ii(0x1017_58b2, 2); jmp(0x1017_58b9, 0x5); goto l_0x1017_58b9; /* jmp 0x101758b9 */
        l_0x1017_58b4:
            ii(0x1017_58b4, 5); mov(edx, 0x9);                          /* mov edx, 0x9 */
        l_0x1017_58b9:
            ii(0x1017_58b9, 7); lea(eax, edx * 4 + 0);                  /* lea eax, [edx*4] */
            ii(0x1017_58c0, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_58c2, 10); mov(memw[ds, eax * 2 + 0x1020_8a44], 0xffff); /* mov word [eax*2+0x10208a44], 0xffff */
            ii(0x1017_58cc, 5); mov(eax, memd[ds, 0x1020_9540]);        /* mov eax, [0x10209540] */
            ii(0x1017_58d1, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_58d3, 2); if(jnz(0x1017_58dc, 0x7)) goto l_0x1017_58dc; /* jnz 0x101758dc */
            ii(0x1017_58d5, 5); mov(edx, 0x1a);                         /* mov edx, 0x1a */
            ii(0x1017_58da, 2); jmp(0x1017_5905, 0x29); goto l_0x1017_5905; /* jmp 0x10175905 */
        l_0x1017_58dc:
            ii(0x1017_58dc, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1017_58df, 2); if(jnz(0x1017_58e8, 0x7)) goto l_0x1017_58e8; /* jnz 0x101758e8 */
            ii(0x1017_58e1, 5); mov(edx, 0x6);                          /* mov edx, 0x6 */
            ii(0x1017_58e6, 2); jmp(0x1017_5905, 0x1d); goto l_0x1017_5905; /* jmp 0x10175905 */
        l_0x1017_58e8:
            ii(0x1017_58e8, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x1017_58eb, 2); if(jnz(0x1017_58f4, 0x7)) goto l_0x1017_58f4; /* jnz 0x101758f4 */
            ii(0x1017_58ed, 5); mov(edx, 0x1a);                         /* mov edx, 0x1a */
            ii(0x1017_58f2, 2); jmp(0x1017_5905, 0x11); goto l_0x1017_5905; /* jmp 0x10175905 */
        l_0x1017_58f4:
            ii(0x1017_58f4, 3); cmp(eax, 0x3);                          /* cmp eax, 0x3 */
            ii(0x1017_58f7, 2); if(jnz(0x1017_5900, 0x7)) goto l_0x1017_5900; /* jnz 0x10175900 */
            ii(0x1017_58f9, 5); mov(edx, 0x1a);                         /* mov edx, 0x1a */
            ii(0x1017_58fe, 2); jmp(0x1017_5905, 0x5); goto l_0x1017_5905; /* jmp 0x10175905 */
        l_0x1017_5900:
            ii(0x1017_5900, 5); mov(edx, 0x9);                          /* mov edx, 0x9 */
        l_0x1017_5905:
            ii(0x1017_5905, 7); lea(eax, edx * 4 + 0);                  /* lea eax, [edx*4] */
            ii(0x1017_590c, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_590e, 5); mov(ecx, 0xffff_ffff);                  /* mov ecx, 0xffffffff */
            ii(0x1017_5913, 6); mov(esi, memd[ds, 0x1020_9540]);        /* mov esi, [0x10209540] */
            ii(0x1017_5919, 8); mov(memw[ds, eax * 2 + 0x1020_8a46], cx); /* mov [eax*2+0x10208a46], cx */
            ii(0x1017_5921, 2); test(esi, esi);                         /* test esi, esi */
            ii(0x1017_5923, 2); if(jnz(0x1017_592c, 0x7)) goto l_0x1017_592c; /* jnz 0x1017592c */
            ii(0x1017_5925, 5); mov(eax, 0x1a);                         /* mov eax, 0x1a */
            ii(0x1017_592a, 2); jmp(0x1017_5955, 0x29); goto l_0x1017_5955; /* jmp 0x10175955 */
        l_0x1017_592c:
            ii(0x1017_592c, 3); cmp(esi, 0x1);                          /* cmp esi, 0x1 */
            ii(0x1017_592f, 2); if(jnz(0x1017_5938, 0x7)) goto l_0x1017_5938; /* jnz 0x10175938 */
            ii(0x1017_5931, 5); mov(eax, 0x6);                          /* mov eax, 0x6 */
            ii(0x1017_5936, 2); jmp(0x1017_5955, 0x1d); goto l_0x1017_5955; /* jmp 0x10175955 */
        l_0x1017_5938:
            ii(0x1017_5938, 3); cmp(esi, 0x4);                          /* cmp esi, 0x4 */
            ii(0x1017_593b, 2); if(jnz(0x1017_5944, 0x7)) goto l_0x1017_5944; /* jnz 0x10175944 */
            ii(0x1017_593d, 5); mov(eax, 0x1a);                         /* mov eax, 0x1a */
            ii(0x1017_5942, 2); jmp(0x1017_5955, 0x11); goto l_0x1017_5955; /* jmp 0x10175955 */
        l_0x1017_5944:
            ii(0x1017_5944, 3); cmp(esi, 0x3);                          /* cmp esi, 0x3 */
            ii(0x1017_5947, 2); if(jnz(0x1017_5950, 0x7)) goto l_0x1017_5950; /* jnz 0x10175950 */
            ii(0x1017_5949, 5); mov(eax, 0x1a);                         /* mov eax, 0x1a */
            ii(0x1017_594e, 2); jmp(0x1017_5955, 0x5); goto l_0x1017_5955; /* jmp 0x10175955 */
        l_0x1017_5950:
            ii(0x1017_5950, 5); mov(eax, 0x9);                          /* mov eax, 0x9 */
        l_0x1017_5955:
            ii(0x1017_5955, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1017_5957, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1017_595a, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_595c, 5); mov(esi, 0xffff_ffff);                  /* mov esi, 0xffffffff */
            ii(0x1017_5961, 6); mov(edx, memd[ds, 0x1020_9540]);        /* mov edx, [0x10209540] */
            ii(0x1017_5967, 8); mov(memw[ds, eax * 2 + 0x1020_8a48], si); /* mov [eax*2+0x10208a48], si */
            ii(0x1017_596f, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1017_5971, 2); if(jnz(0x1017_597a, 0x7)) goto l_0x1017_597a; /* jnz 0x1017597a */
            ii(0x1017_5973, 5); mov(edx, 0x1b);                         /* mov edx, 0x1b */
            ii(0x1017_5978, 2); jmp(0x1017_59a5, 0x2b); goto l_0x1017_59a5; /* jmp 0x101759a5 */
        l_0x1017_597a:
            ii(0x1017_597a, 3); cmp(edx, 0x1);                          /* cmp edx, 0x1 */
            ii(0x1017_597d, 2); if(jnz(0x1017_5986, 0x7)) goto l_0x1017_5986; /* jnz 0x10175986 */
            ii(0x1017_597f, 5); mov(eax, 0xc);                          /* mov eax, 0xc */
            ii(0x1017_5984, 2); jmp(0x1017_59a3, 0x1d); goto l_0x1017_59a3; /* jmp 0x101759a3 */
        l_0x1017_5986:
            ii(0x1017_5986, 3); cmp(edx, 0x4);                          /* cmp edx, 0x4 */
            ii(0x1017_5989, 2); if(jnz(0x1017_5992, 0x7)) goto l_0x1017_5992; /* jnz 0x10175992 */
            ii(0x1017_598b, 5); mov(eax, 0x1b);                         /* mov eax, 0x1b */
            ii(0x1017_5990, 2); jmp(0x1017_59a3, 0x11); goto l_0x1017_59a3; /* jmp 0x101759a3 */
        l_0x1017_5992:
            ii(0x1017_5992, 3); cmp(edx, 0x3);                          /* cmp edx, 0x3 */
            ii(0x1017_5995, 2); if(jnz(0x1017_599e, 0x7)) goto l_0x1017_599e; /* jnz 0x1017599e */
            ii(0x1017_5997, 5); mov(eax, 0x1b);                         /* mov eax, 0x1b */
            ii(0x1017_599c, 2); jmp(0x1017_59a3, 0x5); goto l_0x1017_59a3; /* jmp 0x101759a3 */
        l_0x1017_599e:
            ii(0x1017_599e, 5); mov(eax, 0xa);                          /* mov eax, 0xa */
        l_0x1017_59a3:
            ii(0x1017_59a3, 2); mov(edx, eax);                          /* mov edx, eax */
        l_0x1017_59a5:
            ii(0x1017_59a5, 7); lea(eax, edx * 4 + 0);                  /* lea eax, [edx*4] */
            ii(0x1017_59ac, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_59ae, 10); mov(memw[ds, eax * 2 + 0x1020_8a40], 0x5d); /* mov word [eax*2+0x10208a40], 0x5d */
            ii(0x1017_59b8, 6); mov(edi, memd[ds, 0x1020_9540]);        /* mov edi, [0x10209540] */
            ii(0x1017_59be, 2); test(edi, edi);                         /* test edi, edi */
            ii(0x1017_59c0, 2); if(jnz(0x1017_59c9, 0x7)) goto l_0x1017_59c9; /* jnz 0x101759c9 */
            ii(0x1017_59c2, 5); mov(eax, 0x1b);                         /* mov eax, 0x1b */
            ii(0x1017_59c7, 2); jmp(0x1017_59f2, 0x29); goto l_0x1017_59f2; /* jmp 0x101759f2 */
        l_0x1017_59c9:
            ii(0x1017_59c9, 3); cmp(edi, 0x1);                          /* cmp edi, 0x1 */
            ii(0x1017_59cc, 2); if(jnz(0x1017_59d5, 0x7)) goto l_0x1017_59d5; /* jnz 0x101759d5 */
            ii(0x1017_59ce, 5); mov(eax, 0xc);                          /* mov eax, 0xc */
            ii(0x1017_59d3, 2); jmp(0x1017_59f2, 0x1d); goto l_0x1017_59f2; /* jmp 0x101759f2 */
        l_0x1017_59d5:
            ii(0x1017_59d5, 3); cmp(edi, 0x4);                          /* cmp edi, 0x4 */
            ii(0x1017_59d8, 2); if(jnz(0x1017_59e1, 0x7)) goto l_0x1017_59e1; /* jnz 0x101759e1 */
            ii(0x1017_59da, 5); mov(eax, 0x1b);                         /* mov eax, 0x1b */
            ii(0x1017_59df, 2); jmp(0x1017_59f2, 0x11); goto l_0x1017_59f2; /* jmp 0x101759f2 */
        l_0x1017_59e1:
            ii(0x1017_59e1, 3); cmp(edi, 0x3);                          /* cmp edi, 0x3 */
            ii(0x1017_59e4, 2); if(jnz(0x1017_59ed, 0x7)) goto l_0x1017_59ed; /* jnz 0x101759ed */
            ii(0x1017_59e6, 5); mov(eax, 0x1b);                         /* mov eax, 0x1b */
            ii(0x1017_59eb, 2); jmp(0x1017_59f2, 0x5); goto l_0x1017_59f2; /* jmp 0x101759f2 */
        l_0x1017_59ed:
            ii(0x1017_59ed, 5); mov(eax, 0xa);                          /* mov eax, 0xa */
        l_0x1017_59f2:
            ii(0x1017_59f2, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1017_59f4, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1017_59f7, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_59f9, 5); mov(edx, 0x7d);                         /* mov edx, 0x7d */
            ii(0x1017_59fe, 6); mov(ebx, memd[ds, 0x1020_9540]);        /* mov ebx, [0x10209540] */
            ii(0x1017_5a04, 8); mov(memw[ds, eax * 2 + 0x1020_8a42], dx); /* mov [eax*2+0x10208a42], dx */
            ii(0x1017_5a0c, 2); test(ebx, ebx);                         /* test ebx, ebx */
            ii(0x1017_5a0e, 2); if(jnz(0x1017_5a17, 0x7)) goto l_0x1017_5a17; /* jnz 0x10175a17 */
            ii(0x1017_5a10, 5); mov(eax, 0x1b);                         /* mov eax, 0x1b */
            ii(0x1017_5a15, 2); jmp(0x1017_5a40, 0x29); goto l_0x1017_5a40; /* jmp 0x10175a40 */
        l_0x1017_5a17:
            ii(0x1017_5a17, 3); cmp(ebx, 0x1);                          /* cmp ebx, 0x1 */
            ii(0x1017_5a1a, 2); if(jnz(0x1017_5a23, 0x7)) goto l_0x1017_5a23; /* jnz 0x10175a23 */
            ii(0x1017_5a1c, 5); mov(eax, 0xc);                          /* mov eax, 0xc */
            ii(0x1017_5a21, 2); jmp(0x1017_5a40, 0x1d); goto l_0x1017_5a40; /* jmp 0x10175a40 */
        l_0x1017_5a23:
            ii(0x1017_5a23, 3); cmp(ebx, 0x4);                          /* cmp ebx, 0x4 */
            ii(0x1017_5a26, 2); if(jnz(0x1017_5a2f, 0x7)) goto l_0x1017_5a2f; /* jnz 0x10175a2f */
            ii(0x1017_5a28, 5); mov(eax, 0x1b);                         /* mov eax, 0x1b */
            ii(0x1017_5a2d, 2); jmp(0x1017_5a40, 0x11); goto l_0x1017_5a40; /* jmp 0x10175a40 */
        l_0x1017_5a2f:
            ii(0x1017_5a2f, 3); cmp(ebx, 0x3);                          /* cmp ebx, 0x3 */
            ii(0x1017_5a32, 2); if(jnz(0x1017_5a3b, 0x7)) goto l_0x1017_5a3b; /* jnz 0x10175a3b */
            ii(0x1017_5a34, 5); mov(eax, 0x1b);                         /* mov eax, 0x1b */
            ii(0x1017_5a39, 2); jmp(0x1017_5a40, 0x5); goto l_0x1017_5a40; /* jmp 0x10175a40 */
        l_0x1017_5a3b:
            ii(0x1017_5a3b, 5); mov(eax, 0xa);                          /* mov eax, 0xa */
        l_0x1017_5a40:
            ii(0x1017_5a40, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1017_5a42, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1017_5a45, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_5a47, 5); mov(ebx, 0xffff_ffff);                  /* mov ebx, 0xffffffff */
            ii(0x1017_5a4c, 6); mov(ebp, memd[ds, 0x1020_9540]);        /* mov ebp, [0x10209540] */
            ii(0x1017_5a52, 8); mov(memw[ds, eax * 2 + 0x1020_8a44], bx); /* mov [eax*2+0x10208a44], bx */
            ii(0x1017_5a5a, 2); test(ebp, ebp);                         /* test ebp, ebp */
            ii(0x1017_5a5c, 2); if(jnz(0x1017_5a65, 0x7)) goto l_0x1017_5a65; /* jnz 0x10175a65 */
            ii(0x1017_5a5e, 5); mov(edx, 0x1b);                         /* mov edx, 0x1b */
            ii(0x1017_5a63, 2); jmp(0x1017_5a90, 0x2b); goto l_0x1017_5a90; /* jmp 0x10175a90 */
        l_0x1017_5a65:
            ii(0x1017_5a65, 3); cmp(ebp, 0x1);                          /* cmp ebp, 0x1 */
            ii(0x1017_5a68, 2); if(jnz(0x1017_5a71, 0x7)) goto l_0x1017_5a71; /* jnz 0x10175a71 */
            ii(0x1017_5a6a, 5); mov(eax, 0xc);                          /* mov eax, 0xc */
            ii(0x1017_5a6f, 2); jmp(0x1017_5a8e, 0x1d); goto l_0x1017_5a8e; /* jmp 0x10175a8e */
        l_0x1017_5a71:
            ii(0x1017_5a71, 3); cmp(ebp, 0x4);                          /* cmp ebp, 0x4 */
            ii(0x1017_5a74, 2); if(jnz(0x1017_5a7d, 0x7)) goto l_0x1017_5a7d; /* jnz 0x10175a7d */
            ii(0x1017_5a76, 5); mov(eax, 0x1b);                         /* mov eax, 0x1b */
            ii(0x1017_5a7b, 2); jmp(0x1017_5a8e, 0x11); goto l_0x1017_5a8e; /* jmp 0x10175a8e */
        l_0x1017_5a7d:
            ii(0x1017_5a7d, 3); cmp(ebp, 0x3);                          /* cmp ebp, 0x3 */
            ii(0x1017_5a80, 2); if(jnz(0x1017_5a89, 0x7)) goto l_0x1017_5a89; /* jnz 0x10175a89 */
            ii(0x1017_5a82, 5); mov(eax, 0x1b);                         /* mov eax, 0x1b */
            ii(0x1017_5a87, 2); jmp(0x1017_5a8e, 0x5); goto l_0x1017_5a8e; /* jmp 0x10175a8e */
        l_0x1017_5a89:
            ii(0x1017_5a89, 5); mov(eax, 0xa);                          /* mov eax, 0xa */
        l_0x1017_5a8e:
            ii(0x1017_5a8e, 2); mov(edx, eax);                          /* mov edx, eax */
        l_0x1017_5a90:
            ii(0x1017_5a90, 7); lea(eax, edx * 4 + 0);                  /* lea eax, [edx*4] */
            ii(0x1017_5a97, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_5a99, 10); mov(memw[ds, eax * 2 + 0x1020_8a46], 0xffff); /* mov word [eax*2+0x10208a46], 0xffff */
            ii(0x1017_5aa3, 6); mov(ecx, memd[ds, 0x1020_9540]);        /* mov ecx, [0x10209540] */
            ii(0x1017_5aa9, 2); test(ecx, ecx);                         /* test ecx, ecx */
            ii(0x1017_5aab, 2); if(jnz(0x1017_5ab4, 0x7)) goto l_0x1017_5ab4; /* jnz 0x10175ab4 */
            ii(0x1017_5aad, 5); mov(eax, 0x1b);                         /* mov eax, 0x1b */
            ii(0x1017_5ab2, 2); jmp(0x1017_5add, 0x29); goto l_0x1017_5add; /* jmp 0x10175add */
        l_0x1017_5ab4:
            ii(0x1017_5ab4, 3); cmp(ecx, 0x1);                          /* cmp ecx, 0x1 */
            ii(0x1017_5ab7, 2); if(jnz(0x1017_5ac0, 0x7)) goto l_0x1017_5ac0; /* jnz 0x10175ac0 */
            ii(0x1017_5ab9, 5); mov(eax, 0xc);                          /* mov eax, 0xc */
            ii(0x1017_5abe, 2); jmp(0x1017_5add, 0x1d); goto l_0x1017_5add; /* jmp 0x10175add */
        l_0x1017_5ac0:
            ii(0x1017_5ac0, 3); cmp(ecx, 0x4);                          /* cmp ecx, 0x4 */
            ii(0x1017_5ac3, 2); if(jnz(0x1017_5acc, 0x7)) goto l_0x1017_5acc; /* jnz 0x10175acc */
            ii(0x1017_5ac5, 5); mov(eax, 0x1b);                         /* mov eax, 0x1b */
            ii(0x1017_5aca, 2); jmp(0x1017_5add, 0x11); goto l_0x1017_5add; /* jmp 0x10175add */
        l_0x1017_5acc:
            ii(0x1017_5acc, 3); cmp(ecx, 0x3);                          /* cmp ecx, 0x3 */
            ii(0x1017_5acf, 2); if(jnz(0x1017_5ad8, 0x7)) goto l_0x1017_5ad8; /* jnz 0x10175ad8 */
            ii(0x1017_5ad1, 5); mov(eax, 0x1b);                         /* mov eax, 0x1b */
            ii(0x1017_5ad6, 2); jmp(0x1017_5add, 0x5); goto l_0x1017_5add; /* jmp 0x10175add */
        l_0x1017_5ad8:
            ii(0x1017_5ad8, 5); mov(eax, 0xa);                          /* mov eax, 0xa */
        l_0x1017_5add:
            ii(0x1017_5add, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1017_5adf, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1017_5ae2, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_5ae4, 10); mov(memw[ds, eax * 2 + 0x1020_8a48], 0xffff); /* mov word [eax*2+0x10208a48], 0xffff */
            ii(0x1017_5aee, 5); mov(eax, memd[ds, 0x1020_9540]);        /* mov eax, [0x10209540] */
            ii(0x1017_5af3, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_5af5, 2); if(jnz(0x1017_5afe, 0x7)) goto l_0x1017_5afe; /* jnz 0x10175afe */
            ii(0x1017_5af7, 5); mov(eax, 0x2b);                         /* mov eax, 0x2b */
            ii(0x1017_5afc, 2); jmp(0x1017_5b27, 0x29); goto l_0x1017_5b27; /* jmp 0x10175b27 */
        l_0x1017_5afe:
            ii(0x1017_5afe, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1017_5b01, 2); if(jnz(0x1017_5b0a, 0x7)) goto l_0x1017_5b0a; /* jnz 0x10175b0a */
            ii(0x1017_5b03, 5); mov(eax, 0x9);                          /* mov eax, 0x9 */
            ii(0x1017_5b08, 2); jmp(0x1017_5b27, 0x1d); goto l_0x1017_5b27; /* jmp 0x10175b27 */
        l_0x1017_5b0a:
            ii(0x1017_5b0a, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x1017_5b0d, 2); if(jnz(0x1017_5b16, 0x7)) goto l_0x1017_5b16; /* jnz 0x10175b16 */
            ii(0x1017_5b0f, 5); mov(eax, 0x29);                         /* mov eax, 0x29 */
            ii(0x1017_5b14, 2); jmp(0x1017_5b27, 0x11); goto l_0x1017_5b27; /* jmp 0x10175b27 */
        l_0x1017_5b16:
            ii(0x1017_5b16, 3); cmp(eax, 0x3);                          /* cmp eax, 0x3 */
            ii(0x1017_5b19, 2); if(jnz(0x1017_5b22, 0x7)) goto l_0x1017_5b22; /* jnz 0x10175b22 */
            ii(0x1017_5b1b, 5); mov(eax, 0x29);                         /* mov eax, 0x29 */
            ii(0x1017_5b20, 2); jmp(0x1017_5b27, 0x5); goto l_0x1017_5b27; /* jmp 0x10175b27 */
        l_0x1017_5b22:
            ii(0x1017_5b22, 5); mov(eax, 0xc);                          /* mov eax, 0xc */
        l_0x1017_5b27:
            ii(0x1017_5b27, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1017_5b29, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1017_5b2c, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_5b2e, 5); mov(edi, 0x5c);                         /* mov edi, 0x5c */
            ii(0x1017_5b33, 6); mov(esi, memd[ds, 0x1020_9540]);        /* mov esi, [0x10209540] */
            ii(0x1017_5b39, 8); mov(memw[ds, eax * 2 + 0x1020_8a40], di); /* mov [eax*2+0x10208a40], di */
            ii(0x1017_5b41, 2); test(esi, esi);                         /* test esi, esi */
            ii(0x1017_5b43, 2); if(jnz(0x1017_5b4c, 0x7)) goto l_0x1017_5b4c; /* jnz 0x10175b4c */
            ii(0x1017_5b45, 5); mov(edx, 0x2b);                         /* mov edx, 0x2b */
            ii(0x1017_5b4a, 2); jmp(0x1017_5b77, 0x2b); goto l_0x1017_5b77; /* jmp 0x10175b77 */
        l_0x1017_5b4c:
            ii(0x1017_5b4c, 3); cmp(esi, 0x1);                          /* cmp esi, 0x1 */
            ii(0x1017_5b4f, 2); if(jnz(0x1017_5b58, 0x7)) goto l_0x1017_5b58; /* jnz 0x10175b58 */
            ii(0x1017_5b51, 5); mov(eax, 0x9);                          /* mov eax, 0x9 */
            ii(0x1017_5b56, 2); jmp(0x1017_5b75, 0x1d); goto l_0x1017_5b75; /* jmp 0x10175b75 */
        l_0x1017_5b58:
            ii(0x1017_5b58, 3); cmp(esi, 0x4);                          /* cmp esi, 0x4 */
            ii(0x1017_5b5b, 2); if(jnz(0x1017_5b64, 0x7)) goto l_0x1017_5b64; /* jnz 0x10175b64 */
            ii(0x1017_5b5d, 5); mov(eax, 0x29);                         /* mov eax, 0x29 */
            ii(0x1017_5b62, 2); jmp(0x1017_5b75, 0x11); goto l_0x1017_5b75; /* jmp 0x10175b75 */
        l_0x1017_5b64:
            ii(0x1017_5b64, 3); cmp(esi, 0x3);                          /* cmp esi, 0x3 */
            ii(0x1017_5b67, 2); if(jnz(0x1017_5b70, 0x7)) goto l_0x1017_5b70; /* jnz 0x10175b70 */
            ii(0x1017_5b69, 5); mov(eax, 0x29);                         /* mov eax, 0x29 */
            ii(0x1017_5b6e, 2); jmp(0x1017_5b75, 0x5); goto l_0x1017_5b75; /* jmp 0x10175b75 */
        l_0x1017_5b70:
            ii(0x1017_5b70, 5); mov(eax, 0xc);                          /* mov eax, 0xc */
        l_0x1017_5b75:
            ii(0x1017_5b75, 2); mov(edx, eax);                          /* mov edx, eax */
        l_0x1017_5b77:
            ii(0x1017_5b77, 7); lea(eax, edx * 4 + 0);                  /* lea eax, [edx*4] */
            ii(0x1017_5b7e, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_5b80, 10); mov(memw[ds, eax * 2 + 0x1020_8a42], 0x7c); /* mov word [eax*2+0x10208a42], 0x7c */
            ii(0x1017_5b8a, 6); mov(edx, memd[ds, 0x1020_9540]);        /* mov edx, [0x10209540] */
            ii(0x1017_5b90, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1017_5b92, 2); if(jnz(0x1017_5b9b, 0x7)) goto l_0x1017_5b9b; /* jnz 0x10175b9b */
            ii(0x1017_5b94, 5); mov(edx, 0x2b);                         /* mov edx, 0x2b */
            ii(0x1017_5b99, 2); jmp(0x1017_5bc6, 0x2b); goto l_0x1017_5bc6; /* jmp 0x10175bc6 */
        l_0x1017_5b9b:
            ii(0x1017_5b9b, 3); cmp(edx, 0x1);                          /* cmp edx, 0x1 */
            ii(0x1017_5b9e, 2); if(jnz(0x1017_5ba7, 0x7)) goto l_0x1017_5ba7; /* jnz 0x10175ba7 */
            ii(0x1017_5ba0, 5); mov(edx, 0x9);                          /* mov edx, 0x9 */
            ii(0x1017_5ba5, 2); jmp(0x1017_5bc6, 0x1f); goto l_0x1017_5bc6; /* jmp 0x10175bc6 */
        l_0x1017_5ba7:
            ii(0x1017_5ba7, 3); cmp(edx, 0x4);                          /* cmp edx, 0x4 */
            ii(0x1017_5baa, 2); if(jnz(0x1017_5bb3, 0x7)) goto l_0x1017_5bb3; /* jnz 0x10175bb3 */
            ii(0x1017_5bac, 5); mov(eax, 0x29);                         /* mov eax, 0x29 */
            ii(0x1017_5bb1, 2); jmp(0x1017_5bc4, 0x11); goto l_0x1017_5bc4; /* jmp 0x10175bc4 */
        l_0x1017_5bb3:
            ii(0x1017_5bb3, 3); cmp(edx, 0x3);                          /* cmp edx, 0x3 */
            ii(0x1017_5bb6, 2); if(jnz(0x1017_5bbf, 0x7)) goto l_0x1017_5bbf; /* jnz 0x10175bbf */
            ii(0x1017_5bb8, 5); mov(eax, 0x29);                         /* mov eax, 0x29 */
            ii(0x1017_5bbd, 2); jmp(0x1017_5bc4, 0x5); goto l_0x1017_5bc4; /* jmp 0x10175bc4 */
        l_0x1017_5bbf:
            ii(0x1017_5bbf, 5); mov(eax, 0xc);                          /* mov eax, 0xc */
        l_0x1017_5bc4:
            ii(0x1017_5bc4, 2); mov(edx, eax);                          /* mov edx, eax */
        l_0x1017_5bc6:
            ii(0x1017_5bc6, 7); lea(eax, edx * 4 + 0);                  /* lea eax, [edx*4] */
            ii(0x1017_5bcd, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_5bcf, 5); mov(ebx, 0xffff_ffff);                  /* mov ebx, 0xffffffff */
            ii(0x1017_5bd4, 6); mov(edi, memd[ds, 0x1020_9540]);        /* mov edi, [0x10209540] */
            ii(0x1017_5bda, 8); mov(memw[ds, eax * 2 + 0x1020_8a44], bx); /* mov [eax*2+0x10208a44], bx */
            ii(0x1017_5be2, 2); test(edi, edi);                         /* test edi, edi */
            ii(0x1017_5be4, 2); if(jnz(0x1017_5bed, 0x7)) goto l_0x1017_5bed; /* jnz 0x10175bed */
            ii(0x1017_5be6, 5); mov(eax, 0x2b);                         /* mov eax, 0x2b */
            ii(0x1017_5beb, 2); jmp(0x1017_5c16, 0x29); goto l_0x1017_5c16; /* jmp 0x10175c16 */
        l_0x1017_5bed:
            ii(0x1017_5bed, 3); cmp(edi, 0x1);                          /* cmp edi, 0x1 */
            ii(0x1017_5bf0, 2); if(jnz(0x1017_5bf9, 0x7)) goto l_0x1017_5bf9; /* jnz 0x10175bf9 */
            ii(0x1017_5bf2, 5); mov(eax, 0x9);                          /* mov eax, 0x9 */
            ii(0x1017_5bf7, 2); jmp(0x1017_5c16, 0x1d); goto l_0x1017_5c16; /* jmp 0x10175c16 */
        l_0x1017_5bf9:
            ii(0x1017_5bf9, 3); cmp(edi, 0x4);                          /* cmp edi, 0x4 */
            ii(0x1017_5bfc, 2); if(jnz(0x1017_5c05, 0x7)) goto l_0x1017_5c05; /* jnz 0x10175c05 */
            ii(0x1017_5bfe, 5); mov(eax, 0x29);                         /* mov eax, 0x29 */
            ii(0x1017_5c03, 2); jmp(0x1017_5c16, 0x11); goto l_0x1017_5c16; /* jmp 0x10175c16 */
        l_0x1017_5c05:
            ii(0x1017_5c05, 3); cmp(edi, 0x3);                          /* cmp edi, 0x3 */
            ii(0x1017_5c08, 2); if(jnz(0x1017_5c11, 0x7)) goto l_0x1017_5c11; /* jnz 0x10175c11 */
            ii(0x1017_5c0a, 5); mov(eax, 0x29);                         /* mov eax, 0x29 */
            ii(0x1017_5c0f, 2); jmp(0x1017_5c16, 0x5); goto l_0x1017_5c16; /* jmp 0x10175c16 */
        l_0x1017_5c11:
            ii(0x1017_5c11, 5); mov(eax, 0xc);                          /* mov eax, 0xc */
        l_0x1017_5c16:
            ii(0x1017_5c16, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1017_5c18, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1017_5c1b, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_5c1d, 5); mov(ecx, 0xffff_ffff);                  /* mov ecx, 0xffffffff */
            ii(0x1017_5c22, 6); mov(ebx, memd[ds, 0x1020_9540]);        /* mov ebx, [0x10209540] */
            ii(0x1017_5c28, 8); mov(memw[ds, eax * 2 + 0x1020_8a46], cx); /* mov [eax*2+0x10208a46], cx */
            ii(0x1017_5c30, 2); test(ebx, ebx);                         /* test ebx, ebx */
            ii(0x1017_5c32, 2); if(jnz(0x1017_5c3b, 0x7)) goto l_0x1017_5c3b; /* jnz 0x10175c3b */
            ii(0x1017_5c34, 5); mov(edx, 0x2b);                         /* mov edx, 0x2b */
            ii(0x1017_5c39, 2); jmp(0x1017_5c66, 0x2b); goto l_0x1017_5c66; /* jmp 0x10175c66 */
        l_0x1017_5c3b:
            ii(0x1017_5c3b, 3); cmp(ebx, 0x1);                          /* cmp ebx, 0x1 */
            ii(0x1017_5c3e, 2); if(jnz(0x1017_5c47, 0x7)) goto l_0x1017_5c47; /* jnz 0x10175c47 */
            ii(0x1017_5c40, 5); mov(eax, 0x9);                          /* mov eax, 0x9 */
            ii(0x1017_5c45, 2); jmp(0x1017_5c64, 0x1d); goto l_0x1017_5c64; /* jmp 0x10175c64 */
        l_0x1017_5c47:
            ii(0x1017_5c47, 3); cmp(ebx, 0x4);                          /* cmp ebx, 0x4 */
            ii(0x1017_5c4a, 2); if(jnz(0x1017_5c53, 0x7)) goto l_0x1017_5c53; /* jnz 0x10175c53 */
            ii(0x1017_5c4c, 5); mov(eax, 0x29);                         /* mov eax, 0x29 */
            ii(0x1017_5c51, 2); jmp(0x1017_5c64, 0x11); goto l_0x1017_5c64; /* jmp 0x10175c64 */
        l_0x1017_5c53:
            ii(0x1017_5c53, 3); cmp(ebx, 0x3);                          /* cmp ebx, 0x3 */
            ii(0x1017_5c56, 2); if(jnz(0x1017_5c5f, 0x7)) goto l_0x1017_5c5f; /* jnz 0x10175c5f */
            ii(0x1017_5c58, 5); mov(eax, 0x29);                         /* mov eax, 0x29 */
            ii(0x1017_5c5d, 2); jmp(0x1017_5c64, 0x5); goto l_0x1017_5c64; /* jmp 0x10175c64 */
        l_0x1017_5c5f:
            ii(0x1017_5c5f, 5); mov(eax, 0xc);                          /* mov eax, 0xc */
        l_0x1017_5c64:
            ii(0x1017_5c64, 2); mov(edx, eax);                          /* mov edx, eax */
        l_0x1017_5c66:
            ii(0x1017_5c66, 7); lea(eax, edx * 4 + 0);                  /* lea eax, [edx*4] */
            ii(0x1017_5c6d, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_5c6f, 5); mov(esi, 0xc0);                         /* mov esi, 0xc0 */
            ii(0x1017_5c74, 5); mov(edi, 0xffff_ffff);                  /* mov edi, 0xffffffff */
            ii(0x1017_5c79, 8); mov(memw[ds, eax * 2 + 0x1020_8a48], si); /* mov [eax*2+0x10208a48], si */
            ii(0x1017_5c81, 6); mov(ebp, memd[ds, 0x1020_9540]);        /* mov ebp, [0x10209540] */
            ii(0x1017_5c87, 7); mov(memw[ds, 0x1020_8c84], di);         /* mov [0x10208c84], di */
            ii(0x1017_5c8e, 7); mov(memw[ds, 0x1020_8c86], di);         /* mov [0x10208c86], di */
            ii(0x1017_5c95, 7); mov(memw[ds, 0x1020_8c88], di);         /* mov [0x10208c88], di */
            ii(0x1017_5c9c, 7); mov(memw[ds, 0x1020_8c8a], di);         /* mov [0x10208c8a], di */
            ii(0x1017_5ca3, 7); mov(memw[ds, 0x1020_8c8c], di);         /* mov [0x10208c8c], di */
            ii(0x1017_5caa, 2); test(ebp, ebp);                         /* test ebp, ebp */
            ii(0x1017_5cac, 2); if(jnz(0x1017_5cb5, 0x7)) goto l_0x1017_5cb5; /* jnz 0x10175cb5 */
            ii(0x1017_5cae, 5); mov(edx, 0x1e);                         /* mov edx, 0x1e */
            ii(0x1017_5cb3, 2); jmp(0x1017_5cd0, 0x1b); goto l_0x1017_5cd0; /* jmp 0x10175cd0 */
        l_0x1017_5cb5:
            ii(0x1017_5cb5, 3); cmp(ebp, 0x1);                          /* cmp ebp, 0x1 */
            ii(0x1017_5cb8, 2); if(jnz(0x1017_5cc1, 0x7)) goto l_0x1017_5cc1; /* jnz 0x10175cc1 */
            ii(0x1017_5cba, 5); mov(edx, 0x10);                         /* mov edx, 0x10 */
            ii(0x1017_5cbf, 2); jmp(0x1017_5cd0, 0xf); goto l_0x1017_5cd0; /* jmp 0x10175cd0 */
        l_0x1017_5cc1:
            ii(0x1017_5cc1, 3); cmp(ebp, 0x4);                          /* cmp ebp, 0x4 */
            ii(0x1017_5cc4, 2); if(jz(0x1017_5cc9, 0x3)) goto l_0x1017_5cc9; /* jz 0x10175cc9 */
            ii(0x1017_5cc6, 3); cmp(ebp, 0x3);                          /* cmp ebp, 0x3 */
        l_0x1017_5cc9:
            ii(0x1017_5cc9, 5); mov(eax, 0x1e);                         /* mov eax, 0x1e */
            ii(0x1017_5cce, 2); mov(edx, eax);                          /* mov edx, eax */
        l_0x1017_5cd0:
            ii(0x1017_5cd0, 7); lea(eax, edx * 4 + 0);                  /* lea eax, [edx*4] */
            ii(0x1017_5cd7, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_5cd9, 5); mov(esi, 0x61);                         /* mov esi, 0x61 */
            ii(0x1017_5cde, 6); mov(ecx, memd[ds, 0x1020_9540]);        /* mov ecx, [0x10209540] */
            ii(0x1017_5ce4, 8); mov(memw[ds, eax * 2 + 0x1020_8a40], si); /* mov [eax*2+0x10208a40], si */
            ii(0x1017_5cec, 2); test(ecx, ecx);                         /* test ecx, ecx */
            ii(0x1017_5cee, 2); if(jz(0x1017_5d04, 0x14)) goto l_0x1017_5d04; /* jz 0x10175d04 */
            ii(0x1017_5cf0, 3); cmp(ecx, 0x1);                          /* cmp ecx, 0x1 */
            ii(0x1017_5cf3, 2); if(jnz(0x1017_5cfc, 0x7)) goto l_0x1017_5cfc; /* jnz 0x10175cfc */
            ii(0x1017_5cf5, 5); mov(eax, 0x10);                         /* mov eax, 0x10 */
            ii(0x1017_5cfa, 2); jmp(0x1017_5d09, 0xd); goto l_0x1017_5d09; /* jmp 0x10175d09 */
        l_0x1017_5cfc:
            ii(0x1017_5cfc, 3); cmp(ecx, 0x4);                          /* cmp ecx, 0x4 */
            ii(0x1017_5cff, 2); if(jz(0x1017_5d04, 0x3)) goto l_0x1017_5d04; /* jz 0x10175d04 */
            ii(0x1017_5d01, 3); cmp(ecx, 0x3);                          /* cmp ecx, 0x3 */
        l_0x1017_5d04:
            ii(0x1017_5d04, 5); mov(eax, 0x1e);                         /* mov eax, 0x1e */
        l_0x1017_5d09:
            ii(0x1017_5d09, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1017_5d0b, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1017_5d0e, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_5d10, 10); mov(memw[ds, eax * 2 + 0x1020_8a42], 0x41); /* mov word [eax*2+0x10208a42], 0x41 */
            ii(0x1017_5d1a, 5); mov(eax, memd[ds, 0x1020_9540]);        /* mov eax, [0x10209540] */
            ii(0x1017_5d1f, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_5d21, 2); if(jnz(0x1017_5d2a, 0x7)) goto l_0x1017_5d2a; /* jnz 0x10175d2a */
            ii(0x1017_5d23, 5); mov(edx, 0x1e);                         /* mov edx, 0x1e */
            ii(0x1017_5d28, 2); jmp(0x1017_5d45, 0x1b); goto l_0x1017_5d45; /* jmp 0x10175d45 */
        l_0x1017_5d2a:
            ii(0x1017_5d2a, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1017_5d2d, 2); if(jnz(0x1017_5d36, 0x7)) goto l_0x1017_5d36; /* jnz 0x10175d36 */
            ii(0x1017_5d2f, 5); mov(eax, 0x10);                         /* mov eax, 0x10 */
            ii(0x1017_5d34, 2); jmp(0x1017_5d43, 0xd); goto l_0x1017_5d43; /* jmp 0x10175d43 */
        l_0x1017_5d36:
            ii(0x1017_5d36, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x1017_5d39, 2); if(jz(0x1017_5d3e, 0x3)) goto l_0x1017_5d3e; /* jz 0x10175d3e */
            ii(0x1017_5d3b, 3); cmp(eax, 0x3);                          /* cmp eax, 0x3 */
        l_0x1017_5d3e:
            ii(0x1017_5d3e, 5); mov(eax, 0x1e);                         /* mov eax, 0x1e */
        l_0x1017_5d43:
            ii(0x1017_5d43, 2); mov(edx, eax);                          /* mov edx, eax */
        l_0x1017_5d45:
            ii(0x1017_5d45, 7); lea(eax, edx * 4 + 0);                  /* lea eax, [edx*4] */
            ii(0x1017_5d4c, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_5d4e, 5); mov(edx, 0x11e);                        /* mov edx, 0x11e */
            ii(0x1017_5d53, 6); mov(esi, memd[ds, 0x1020_9540]);        /* mov esi, [0x10209540] */
            ii(0x1017_5d59, 8); mov(memw[ds, eax * 2 + 0x1020_8a44], dx); /* mov [eax*2+0x10208a44], dx */
            ii(0x1017_5d61, 2); test(esi, esi);                         /* test esi, esi */
            ii(0x1017_5d63, 2); if(jnz(0x1017_5d6c, 0x7)) goto l_0x1017_5d6c; /* jnz 0x10175d6c */
            ii(0x1017_5d65, 5); mov(edx, 0x1e);                         /* mov edx, 0x1e */
            ii(0x1017_5d6a, 2); jmp(0x1017_5d87, 0x1b); goto l_0x1017_5d87; /* jmp 0x10175d87 */
        l_0x1017_5d6c:
            ii(0x1017_5d6c, 3); cmp(esi, 0x1);                          /* cmp esi, 0x1 */
            ii(0x1017_5d6f, 2); if(jnz(0x1017_5d78, 0x7)) goto l_0x1017_5d78; /* jnz 0x10175d78 */
            ii(0x1017_5d71, 5); mov(edx, 0x10);                         /* mov edx, 0x10 */
            ii(0x1017_5d76, 2); jmp(0x1017_5d87, 0xf); goto l_0x1017_5d87; /* jmp 0x10175d87 */
        l_0x1017_5d78:
            ii(0x1017_5d78, 3); cmp(esi, 0x4);                          /* cmp esi, 0x4 */
            ii(0x1017_5d7b, 2); if(jz(0x1017_5d80, 0x3)) goto l_0x1017_5d80; /* jz 0x10175d80 */
            ii(0x1017_5d7d, 3); cmp(esi, 0x3);                          /* cmp esi, 0x3 */
        l_0x1017_5d80:
            ii(0x1017_5d80, 5); mov(eax, 0x1e);                         /* mov eax, 0x1e */
            ii(0x1017_5d85, 2); mov(edx, eax);                          /* mov edx, eax */
        l_0x1017_5d87:
            ii(0x1017_5d87, 7); lea(eax, edx * 4 + 0);                  /* lea eax, [edx*4] */
            ii(0x1017_5d8e, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_5d90, 5); mov(ebx, 0x11e);                        /* mov ebx, 0x11e */
            ii(0x1017_5d95, 6); mov(edx, memd[ds, 0x1020_9540]);        /* mov edx, [0x10209540] */
            ii(0x1017_5d9b, 8); mov(memw[ds, eax * 2 + 0x1020_8a46], bx); /* mov [eax*2+0x10208a46], bx */
            ii(0x1017_5da3, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1017_5da5, 2); if(jz(0x1017_5dbb, 0x14)) goto l_0x1017_5dbb; /* jz 0x10175dbb */
            ii(0x1017_5da7, 3); cmp(edx, 0x1);                          /* cmp edx, 0x1 */
            ii(0x1017_5daa, 2); if(jnz(0x1017_5db3, 0x7)) goto l_0x1017_5db3; /* jnz 0x10175db3 */
            ii(0x1017_5dac, 5); mov(eax, 0x10);                         /* mov eax, 0x10 */
            ii(0x1017_5db1, 2); jmp(0x1017_5dc0, 0xd); goto l_0x1017_5dc0; /* jmp 0x10175dc0 */
        l_0x1017_5db3:
            ii(0x1017_5db3, 3); cmp(edx, 0x4);                          /* cmp edx, 0x4 */
            ii(0x1017_5db6, 2); if(jz(0x1017_5dbb, 0x3)) goto l_0x1017_5dbb; /* jz 0x10175dbb */
            ii(0x1017_5db8, 3); cmp(edx, 0x3);                          /* cmp edx, 0x3 */
        l_0x1017_5dbb:
            ii(0x1017_5dbb, 5); mov(eax, 0x1e);                         /* mov eax, 0x1e */
        l_0x1017_5dc0:
            ii(0x1017_5dc0, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x1017_5dc5, 5); mov(esi, 0x73);                         /* mov esi, 0x73 */
            ii(0x1017_5dca, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1017_5dcc, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1017_5dcf, 5); mov(edi, 0x53);                         /* mov edi, 0x53 */
            ii(0x1017_5dd4, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_5dd6, 5); mov(ebx, 0x13);                         /* mov ebx, 0x13 */
            ii(0x1017_5ddb, 5); mov(edx, 0x4);                          /* mov edx, 0x4 */
            ii(0x1017_5de0, 8); mov(memw[ds, eax * 2 + 0x1020_8a48], cx); /* mov [eax*2+0x10208a48], cx */
            ii(0x1017_5de8, 5); mov(eax, 0x11f);                        /* mov eax, 0x11f */
            ii(0x1017_5ded, 5); mov(ecx, 0x64);                         /* mov ecx, 0x64 */
            ii(0x1017_5df2, 7); mov(memw[ds, 0x1020_8b76], si);         /* mov [0x10208b76], si */
            ii(0x1017_5df9, 7); mov(memw[ds, 0x1020_8b78], di);         /* mov [0x10208b78], di */
            ii(0x1017_5e00, 7); mov(memw[ds, 0x1020_8b7e], bx);         /* mov [0x10208b7e], bx */
            ii(0x1017_5e07, 7); mov(memw[ds, 0x1020_8b88], dx);         /* mov [0x10208b88], dx */
            ii(0x1017_5e0e, 5); mov(esi, 0x44);                         /* mov esi, 0x44 */
            ii(0x1017_5e13, 5); mov(edi, 0x120);                        /* mov edi, 0x120 */
            ii(0x1017_5e18, 5); mov(ebx, 0x66);                         /* mov ebx, 0x66 */
            ii(0x1017_5e1d, 5); mov(edx, 0x67);                         /* mov edx, 0x67 */
            ii(0x1017_5e22, 6); mov(memw[ds, 0x1020_8b7a], ax);         /* mov [0x10208b7a], ax */
            ii(0x1017_5e28, 6); mov(memw[ds, 0x1020_8b7c], ax);         /* mov [0x10208b7c], ax */
            ii(0x1017_5e2e, 7); mov(memw[ds, 0x1020_8b80], cx);         /* mov [0x10208b80], cx */
            ii(0x1017_5e35, 5); mov(ecx, 0x46);                         /* mov ecx, 0x46 */
            ii(0x1017_5e3a, 5); mov(eax, 0x6);                          /* mov eax, 0x6 */
            ii(0x1017_5e3f, 7); mov(memw[ds, 0x1020_8b82], si);         /* mov [0x10208b82], si */
            ii(0x1017_5e46, 7); mov(memw[ds, 0x1020_8b84], di);         /* mov [0x10208b84], di */
            ii(0x1017_5e4d, 7); mov(memw[ds, 0x1020_8b86], di);         /* mov [0x10208b86], di */
            ii(0x1017_5e54, 7); mov(memw[ds, 0x1020_8b8a], bx);         /* mov [0x10208b8a], bx */
            ii(0x1017_5e5b, 7); mov(memw[ds, 0x1020_8b94], dx);         /* mov [0x10208b94], dx */
            ii(0x1017_5e62, 5); mov(esi, 0x121);                        /* mov esi, 0x121 */
            ii(0x1017_5e67, 5); mov(ebx, 0x47);                         /* mov ebx, 0x47 */
            ii(0x1017_5e6c, 5); mov(edi, 0x7);                          /* mov edi, 0x7 */
            ii(0x1017_5e71, 5); mov(edx, 0x48);                         /* mov edx, 0x48 */
            ii(0x1017_5e76, 7); mov(memw[ds, 0x1020_8b8c], cx);         /* mov [0x10208b8c], cx */
            ii(0x1017_5e7d, 6); mov(memw[ds, 0x1020_8b92], ax);         /* mov [0x10208b92], ax */
            ii(0x1017_5e83, 5); mov(ecx, 0x122);                        /* mov ecx, 0x122 */
            ii(0x1017_5e88, 5); mov(eax, 0x68);                         /* mov eax, 0x68 */
            ii(0x1017_5e8d, 7); mov(memw[ds, 0x1020_8b8e], si);         /* mov [0x10208b8e], si */
            ii(0x1017_5e94, 7); mov(memw[ds, 0x1020_8b90], si);         /* mov [0x10208b90], si */
            ii(0x1017_5e9b, 7); mov(memw[ds, 0x1020_8b96], bx);         /* mov [0x10208b96], bx */
            ii(0x1017_5ea2, 7); mov(memw[ds, 0x1020_8b9c], di);         /* mov [0x10208b9c], di */
            ii(0x1017_5ea9, 7); mov(memw[ds, 0x1020_8ba0], dx);         /* mov [0x10208ba0], dx */
            ii(0x1017_5eb0, 5); mov(ebx, 0x123);                        /* mov ebx, 0x123 */
            ii(0x1017_5eb5, 5); mov(esi, 0x8);                          /* mov esi, 0x8 */
            ii(0x1017_5eba, 5); mov(edi, 0x6a);                         /* mov edi, 0x6a */
            ii(0x1017_5ebf, 5); mov(edx, 0x124);                        /* mov edx, 0x124 */
            ii(0x1017_5ec4, 7); mov(memw[ds, 0x1020_8b98], cx);         /* mov [0x10208b98], cx */
            ii(0x1017_5ecb, 7); mov(memw[ds, 0x1020_8b9a], cx);         /* mov [0x10208b9a], cx */
            ii(0x1017_5ed2, 6); mov(memw[ds, 0x1020_8b9e], ax);         /* mov [0x10208b9e], ax */
            ii(0x1017_5ed8, 5); mov(eax, 0x4a);                         /* mov eax, 0x4a */
            ii(0x1017_5edd, 5); mov(ecx, 0xa);                          /* mov ecx, 0xa */
            ii(0x1017_5ee2, 7); mov(memw[ds, 0x1020_8ba2], bx);         /* mov [0x10208ba2], bx */
            ii(0x1017_5ee9, 7); mov(memw[ds, 0x1020_8ba4], bx);         /* mov [0x10208ba4], bx */
            ii(0x1017_5ef0, 7); mov(memw[ds, 0x1020_8ba6], si);         /* mov [0x10208ba6], si */
            ii(0x1017_5ef7, 7); mov(memw[ds, 0x1020_8ba8], di);         /* mov [0x10208ba8], di */
            ii(0x1017_5efe, 7); mov(memw[ds, 0x1020_8bac], dx);         /* mov [0x10208bac], dx */
            ii(0x1017_5f05, 7); mov(memw[ds, 0x1020_8bae], dx);         /* mov [0x10208bae], dx */
            ii(0x1017_5f0c, 5); mov(esi, 0x6b);                         /* mov esi, 0x6b */
            ii(0x1017_5f11, 5); mov(edi, 0x4b);                         /* mov edi, 0x4b */
            ii(0x1017_5f16, 5); mov(ebx, 0xb);                          /* mov ebx, 0xb */
            ii(0x1017_5f1b, 5); mov(edx, 0xc);                          /* mov edx, 0xc */
            ii(0x1017_5f20, 6); mov(memw[ds, 0x1020_8baa], ax);         /* mov [0x10208baa], ax */
            ii(0x1017_5f26, 7); mov(memw[ds, 0x1020_8bb0], cx);         /* mov [0x10208bb0], cx */
            ii(0x1017_5f2d, 5); mov(eax, 0x125);                        /* mov eax, 0x125 */
            ii(0x1017_5f32, 5); mov(ecx, 0x6c);                         /* mov ecx, 0x6c */
            ii(0x1017_5f37, 7); mov(memw[ds, 0x1020_8bb2], si);         /* mov [0x10208bb2], si */
            ii(0x1017_5f3e, 7); mov(memw[ds, 0x1020_8bb4], di);         /* mov [0x10208bb4], di */
            ii(0x1017_5f45, 7); mov(memw[ds, 0x1020_8bba], bx);         /* mov [0x10208bba], bx */
            ii(0x1017_5f4c, 7); mov(memw[ds, 0x1020_8bc4], dx);         /* mov [0x10208bc4], dx */
            ii(0x1017_5f53, 5); mov(esi, 0x4c);                         /* mov esi, 0x4c */
            ii(0x1017_5f58, 5); mov(edi, 0x126);                        /* mov edi, 0x126 */
            ii(0x1017_5f5d, 6); mov(memw[ds, 0x1020_8bb6], ax);         /* mov [0x10208bb6], ax */
            ii(0x1017_5f63, 6); mov(memw[ds, 0x1020_8bb8], ax);         /* mov [0x10208bb8], ax */
            ii(0x1017_5f69, 7); mov(memw[ds, 0x1020_8bbc], cx);         /* mov [0x10208bbc], cx */
            ii(0x1017_5f70, 7); mov(memw[ds, 0x1020_8bc0], di);         /* mov [0x10208bc0], di */
            ii(0x1017_5f77, 7); mov(memw[ds, 0x1020_8bc2], di);         /* mov [0x10208bc2], di */
            ii(0x1017_5f7e, 6); mov(edi, memd[ds, 0x1020_9540]);        /* mov edi, [0x10209540] */
            ii(0x1017_5f84, 7); mov(memw[ds, 0x1020_8bbe], si);         /* mov [0x10208bbe], si */
            ii(0x1017_5f8b, 2); test(edi, edi);                         /* test edi, edi */
            ii(0x1017_5f8d, 2); if(jnz(0x1017_5f96, 0x7)) goto l_0x1017_5f96; /* jnz 0x10175f96 */
            ii(0x1017_5f8f, 5); mov(edx, 0x27);                         /* mov edx, 0x27 */
            ii(0x1017_5f94, 2); jmp(0x1017_5faa, 0x14); goto l_0x1017_5faa; /* jmp 0x10175faa */
        l_0x1017_5f96:
            ii(0x1017_5f96, 3); cmp(edi, 0x1);                          /* cmp edi, 0x1 */
            ii(0x1017_5f99, 2); if(jz(0x1017_5fa3, 0x8)) goto l_0x1017_5fa3; /* jz 0x10175fa3 */
            ii(0x1017_5f9b, 3); cmp(edi, 0x4);                          /* cmp edi, 0x4 */
            ii(0x1017_5f9e, 2); if(jz(0x1017_5fa3, 0x3)) goto l_0x1017_5fa3; /* jz 0x10175fa3 */
            ii(0x1017_5fa0, 3); cmp(edi, 0x3);                          /* cmp edi, 0x3 */
        l_0x1017_5fa3:
            ii(0x1017_5fa3, 5); mov(eax, 0x33);                         /* mov eax, 0x33 */
            ii(0x1017_5fa8, 2); mov(edx, eax);                          /* mov edx, eax */
        l_0x1017_5faa:
            ii(0x1017_5faa, 7); lea(eax, edx * 4 + 0);                  /* lea eax, [edx*4] */
            ii(0x1017_5fb1, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_5fb3, 10); mov(memw[ds, eax * 2 + 0x1020_8a40], 0x3b); /* mov word [eax*2+0x10208a40], 0x3b */
            ii(0x1017_5fbd, 6); mov(ebx, memd[ds, 0x1020_9540]);        /* mov ebx, [0x10209540] */
            ii(0x1017_5fc3, 2); test(ebx, ebx);                         /* test ebx, ebx */
            ii(0x1017_5fc5, 2); if(jnz(0x1017_5fce, 0x7)) goto l_0x1017_5fce; /* jnz 0x10175fce */
            ii(0x1017_5fc7, 5); mov(edx, 0x27);                         /* mov edx, 0x27 */
            ii(0x1017_5fcc, 2); jmp(0x1017_5fe9, 0x1b); goto l_0x1017_5fe9; /* jmp 0x10175fe9 */
        l_0x1017_5fce:
            ii(0x1017_5fce, 3); cmp(ebx, 0x1);                          /* cmp ebx, 0x1 */
            ii(0x1017_5fd1, 2); if(jnz(0x1017_5fda, 0x7)) goto l_0x1017_5fda; /* jnz 0x10175fda */
            ii(0x1017_5fd3, 5); mov(edx, 0x33);                         /* mov edx, 0x33 */
            ii(0x1017_5fd8, 2); jmp(0x1017_5fe9, 0xf); goto l_0x1017_5fe9; /* jmp 0x10175fe9 */
        l_0x1017_5fda:
            ii(0x1017_5fda, 3); cmp(ebx, 0x4);                          /* cmp ebx, 0x4 */
            ii(0x1017_5fdd, 2); if(jz(0x1017_5fe2, 0x3)) goto l_0x1017_5fe2; /* jz 0x10175fe2 */
            ii(0x1017_5fdf, 3); cmp(ebx, 0x3);                          /* cmp ebx, 0x3 */
        l_0x1017_5fe2:
            ii(0x1017_5fe2, 5); mov(eax, 0x33);                         /* mov eax, 0x33 */
            ii(0x1017_5fe7, 2); mov(edx, eax);                          /* mov edx, eax */
        l_0x1017_5fe9:
            ii(0x1017_5fe9, 7); lea(eax, edx * 4 + 0);                  /* lea eax, [edx*4] */
            ii(0x1017_5ff0, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_5ff2, 5); mov(ecx, 0x3a);                         /* mov ecx, 0x3a */
            ii(0x1017_5ff7, 6); mov(ebp, memd[ds, 0x1020_9540]);        /* mov ebp, [0x10209540] */
            ii(0x1017_5ffd, 8); mov(memw[ds, eax * 2 + 0x1020_8a42], cx); /* mov [eax*2+0x10208a42], cx */
            ii(0x1017_6005, 2); test(ebp, ebp);                         /* test ebp, ebp */
            ii(0x1017_6007, 2); if(jnz(0x1017_6010, 0x7)) goto l_0x1017_6010; /* jnz 0x10176010 */
            ii(0x1017_6009, 5); mov(eax, 0x27);                         /* mov eax, 0x27 */
            ii(0x1017_600e, 2); jmp(0x1017_6022, 0x12); goto l_0x1017_6022; /* jmp 0x10176022 */
        l_0x1017_6010:
            ii(0x1017_6010, 3); cmp(ebp, 0x1);                          /* cmp ebp, 0x1 */
            ii(0x1017_6013, 2); if(jz(0x1017_601d, 0x8)) goto l_0x1017_601d; /* jz 0x1017601d */
            ii(0x1017_6015, 3); cmp(ebp, 0x4);                          /* cmp ebp, 0x4 */
            ii(0x1017_6018, 2); if(jz(0x1017_601d, 0x3)) goto l_0x1017_601d; /* jz 0x1017601d */
            ii(0x1017_601a, 3); cmp(ebp, 0x3);                          /* cmp ebp, 0x3 */
        l_0x1017_601d:
            ii(0x1017_601d, 5); mov(eax, 0x33);                         /* mov eax, 0x33 */
        l_0x1017_6022:
            ii(0x1017_6022, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1017_6024, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1017_6027, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_6029, 5); mov(esi, 0xffff_ffff);                  /* mov esi, 0xffffffff */
            ii(0x1017_602e, 6); mov(ecx, memd[ds, 0x1020_9540]);        /* mov ecx, [0x10209540] */
            ii(0x1017_6034, 8); mov(memw[ds, eax * 2 + 0x1020_8a44], si); /* mov [eax*2+0x10208a44], si */
            ii(0x1017_603c, 2); test(ecx, ecx);                         /* test ecx, ecx */
            ii(0x1017_603e, 2); if(jnz(0x1017_6047, 0x7)) goto l_0x1017_6047; /* jnz 0x10176047 */
            ii(0x1017_6040, 5); mov(edx, 0x27);                         /* mov edx, 0x27 */
            ii(0x1017_6045, 2); jmp(0x1017_605b, 0x14); goto l_0x1017_605b; /* jmp 0x1017605b */
        l_0x1017_6047:
            ii(0x1017_6047, 3); cmp(ecx, 0x1);                          /* cmp ecx, 0x1 */
            ii(0x1017_604a, 2); if(jz(0x1017_6054, 0x8)) goto l_0x1017_6054; /* jz 0x10176054 */
            ii(0x1017_604c, 3); cmp(ecx, 0x4);                          /* cmp ecx, 0x4 */
            ii(0x1017_604f, 2); if(jz(0x1017_6054, 0x3)) goto l_0x1017_6054; /* jz 0x10176054 */
            ii(0x1017_6051, 3); cmp(ecx, 0x3);                          /* cmp ecx, 0x3 */
        l_0x1017_6054:
            ii(0x1017_6054, 5); mov(eax, 0x33);                         /* mov eax, 0x33 */
            ii(0x1017_6059, 2); mov(edx, eax);                          /* mov edx, eax */
        l_0x1017_605b:
            ii(0x1017_605b, 7); lea(eax, edx * 4 + 0);                  /* lea eax, [edx*4] */
            ii(0x1017_6062, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_6064, 10); mov(memw[ds, eax * 2 + 0x1020_8a46], 0xffff); /* mov word [eax*2+0x10208a46], 0xffff */
            ii(0x1017_606e, 5); mov(eax, memd[ds, 0x1020_9540]);        /* mov eax, [0x10209540] */
            ii(0x1017_6073, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_6075, 2); if(jnz(0x1017_607e, 0x7)) goto l_0x1017_607e; /* jnz 0x1017607e */
            ii(0x1017_6077, 5); mov(edx, 0x27);                         /* mov edx, 0x27 */
            ii(0x1017_607c, 2); jmp(0x1017_6099, 0x1b); goto l_0x1017_6099; /* jmp 0x10176099 */
        l_0x1017_607e:
            ii(0x1017_607e, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1017_6081, 2); if(jnz(0x1017_608a, 0x7)) goto l_0x1017_608a; /* jnz 0x1017608a */
            ii(0x1017_6083, 5); mov(edx, 0x33);                         /* mov edx, 0x33 */
            ii(0x1017_6088, 2); jmp(0x1017_6099, 0xf); goto l_0x1017_6099; /* jmp 0x10176099 */
        l_0x1017_608a:
            ii(0x1017_608a, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x1017_608d, 2); if(jz(0x1017_6092, 0x3)) goto l_0x1017_6092; /* jz 0x10176092 */
            ii(0x1017_608f, 3); cmp(eax, 0x3);                          /* cmp eax, 0x3 */
        l_0x1017_6092:
            ii(0x1017_6092, 5); mov(eax, 0x33);                         /* mov eax, 0x33 */
            ii(0x1017_6097, 2); mov(edx, eax);                          /* mov edx, eax */
        l_0x1017_6099:
            ii(0x1017_6099, 7); lea(eax, edx * 4 + 0);                  /* lea eax, [edx*4] */
            ii(0x1017_60a0, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_60a2, 5); mov(edx, 0xffff_ffff);                  /* mov edx, 0xffffffff */
            ii(0x1017_60a7, 6); mov(esi, memd[ds, 0x1020_9540]);        /* mov esi, [0x10209540] */
            ii(0x1017_60ad, 8); mov(memw[ds, eax * 2 + 0x1020_8a48], dx); /* mov [eax*2+0x10208a48], dx */
            ii(0x1017_60b5, 2); test(esi, esi);                         /* test esi, esi */
            ii(0x1017_60b7, 2); if(jnz(0x1017_60c0, 0x7)) goto l_0x1017_60c0; /* jnz 0x101760c0 */
            ii(0x1017_60b9, 5); mov(eax, 0x28);                         /* mov eax, 0x28 */
            ii(0x1017_60be, 2); jmp(0x1017_60df, 0x1f); goto l_0x1017_60df; /* jmp 0x101760df */
        l_0x1017_60c0:
            ii(0x1017_60c0, 3); cmp(esi, 0x1);                          /* cmp esi, 0x1 */
            ii(0x1017_60c3, 2); if(jnz(0x1017_60cc, 0x7)) goto l_0x1017_60cc; /* jnz 0x101760cc */
            ii(0x1017_60c5, 5); mov(eax, 0x4);                          /* mov eax, 0x4 */
            ii(0x1017_60ca, 2); jmp(0x1017_60df, 0x13); goto l_0x1017_60df; /* jmp 0x101760df */
        l_0x1017_60cc:
            ii(0x1017_60cc, 3); cmp(esi, 0x4);                          /* cmp esi, 0x4 */
            ii(0x1017_60cf, 2); if(jz(0x1017_60da, 0x9)) goto l_0x1017_60da; /* jz 0x101760da */
            ii(0x1017_60d1, 3); cmp(esi, 0x3);                          /* cmp esi, 0x3 */
            ii(0x1017_60d4, 2); if(jnz(0x1017_60da, 0x4)) goto l_0x1017_60da; /* jnz 0x101760da */
            ii(0x1017_60d6, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1017_60d8, 2); jmp(0x1017_60df, 0x5); goto l_0x1017_60df; /* jmp 0x101760df */
        l_0x1017_60da:
            ii(0x1017_60da, 5); mov(eax, 0x3);                          /* mov eax, 0x3 */
        l_0x1017_60df:
            ii(0x1017_60df, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1017_60e1, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1017_60e4, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_60e6, 5); mov(ebx, 0x27);                         /* mov ebx, 0x27 */
            ii(0x1017_60eb, 6); mov(edx, memd[ds, 0x1020_9540]);        /* mov edx, [0x10209540] */
            ii(0x1017_60f1, 8); mov(memw[ds, eax * 2 + 0x1020_8a40], bx); /* mov [eax*2+0x10208a40], bx */
            ii(0x1017_60f9, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1017_60fb, 2); if(jnz(0x1017_6104, 0x7)) goto l_0x1017_6104; /* jnz 0x10176104 */
            ii(0x1017_60fd, 5); mov(edx, 0x28);                         /* mov edx, 0x28 */
            ii(0x1017_6102, 2); jmp(0x1017_6125, 0x21); goto l_0x1017_6125; /* jmp 0x10176125 */
        l_0x1017_6104:
            ii(0x1017_6104, 3); cmp(edx, 0x1);                          /* cmp edx, 0x1 */
            ii(0x1017_6107, 2); if(jnz(0x1017_6110, 0x7)) goto l_0x1017_6110; /* jnz 0x10176110 */
            ii(0x1017_6109, 5); mov(eax, 0x4);                          /* mov eax, 0x4 */
            ii(0x1017_610e, 2); jmp(0x1017_6123, 0x13); goto l_0x1017_6123; /* jmp 0x10176123 */
        l_0x1017_6110:
            ii(0x1017_6110, 3); cmp(edx, 0x4);                          /* cmp edx, 0x4 */
            ii(0x1017_6113, 2); if(jz(0x1017_611e, 0x9)) goto l_0x1017_611e; /* jz 0x1017611e */
            ii(0x1017_6115, 3); cmp(edx, 0x3);                          /* cmp edx, 0x3 */
            ii(0x1017_6118, 2); if(jnz(0x1017_611e, 0x4)) goto l_0x1017_611e; /* jnz 0x1017611e */
            ii(0x1017_611a, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1017_611c, 2); jmp(0x1017_6123, 0x5); goto l_0x1017_6123; /* jmp 0x10176123 */
        l_0x1017_611e:
            ii(0x1017_611e, 5); mov(eax, 0x3);                          /* mov eax, 0x3 */
        l_0x1017_6123:
            ii(0x1017_6123, 2); mov(edx, eax);                          /* mov edx, eax */
        l_0x1017_6125:
            ii(0x1017_6125, 7); lea(eax, edx * 4 + 0);                  /* lea eax, [edx*4] */
            ii(0x1017_612c, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_612e, 5); mov(ecx, 0x22);                         /* mov ecx, 0x22 */
            ii(0x1017_6133, 6); mov(edi, memd[ds, 0x1020_9540]);        /* mov edi, [0x10209540] */
            ii(0x1017_6139, 8); mov(memw[ds, eax * 2 + 0x1020_8a42], cx); /* mov [eax*2+0x10208a42], cx */
            ii(0x1017_6141, 2); test(edi, edi);                         /* test edi, edi */
            ii(0x1017_6143, 2); if(jnz(0x1017_614c, 0x7)) goto l_0x1017_614c; /* jnz 0x1017614c */
            ii(0x1017_6145, 5); mov(edx, 0x28);                         /* mov edx, 0x28 */
            ii(0x1017_614a, 2); jmp(0x1017_616d, 0x21); goto l_0x1017_616d; /* jmp 0x1017616d */
        l_0x1017_614c:
            ii(0x1017_614c, 3); cmp(edi, 0x1);                          /* cmp edi, 0x1 */
            ii(0x1017_614f, 2); if(jnz(0x1017_6158, 0x7)) goto l_0x1017_6158; /* jnz 0x10176158 */
            ii(0x1017_6151, 5); mov(edx, 0x4);                          /* mov edx, 0x4 */
            ii(0x1017_6156, 2); jmp(0x1017_616d, 0x15); goto l_0x1017_616d; /* jmp 0x1017616d */
        l_0x1017_6158:
            ii(0x1017_6158, 3); cmp(edi, 0x4);                          /* cmp edi, 0x4 */
            ii(0x1017_615b, 2); if(jz(0x1017_6166, 0x9)) goto l_0x1017_6166; /* jz 0x10176166 */
            ii(0x1017_615d, 3); cmp(edi, 0x3);                          /* cmp edi, 0x3 */
            ii(0x1017_6160, 2); if(jnz(0x1017_6166, 0x4)) goto l_0x1017_6166; /* jnz 0x10176166 */
            ii(0x1017_6162, 2); mov(eax, edi);                          /* mov eax, edi */
            ii(0x1017_6164, 2); jmp(0x1017_616b, 0x5); goto l_0x1017_616b; /* jmp 0x1017616b */
        l_0x1017_6166:
            ii(0x1017_6166, 5); mov(eax, 0x3);                          /* mov eax, 0x3 */
        l_0x1017_616b:
            ii(0x1017_616b, 2); mov(edx, eax);                          /* mov edx, eax */
        l_0x1017_616d:
            ii(0x1017_616d, 7); lea(eax, edx * 4 + 0);                  /* lea eax, [edx*4] */
            ii(0x1017_6174, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_6176, 5); mov(esi, 0xffff_ffff);                  /* mov esi, 0xffffffff */
            ii(0x1017_617b, 6); mov(ebx, memd[ds, 0x1020_9540]);        /* mov ebx, [0x10209540] */
            ii(0x1017_6181, 8); mov(memw[ds, eax * 2 + 0x1020_8a44], si); /* mov [eax*2+0x10208a44], si */
            ii(0x1017_6189, 2); test(ebx, ebx);                         /* test ebx, ebx */
            ii(0x1017_618b, 2); if(jnz(0x1017_6194, 0x7)) goto l_0x1017_6194; /* jnz 0x10176194 */
            ii(0x1017_618d, 5); mov(eax, 0x28);                         /* mov eax, 0x28 */
            ii(0x1017_6192, 2); jmp(0x1017_61b3, 0x1f); goto l_0x1017_61b3; /* jmp 0x101761b3 */
        l_0x1017_6194:
            ii(0x1017_6194, 3); cmp(ebx, 0x1);                          /* cmp ebx, 0x1 */
            ii(0x1017_6197, 2); if(jnz(0x1017_61a0, 0x7)) goto l_0x1017_61a0; /* jnz 0x101761a0 */
            ii(0x1017_6199, 5); mov(eax, 0x4);                          /* mov eax, 0x4 */
            ii(0x1017_619e, 2); jmp(0x1017_61b3, 0x13); goto l_0x1017_61b3; /* jmp 0x101761b3 */
        l_0x1017_61a0:
            ii(0x1017_61a0, 3); cmp(ebx, 0x4);                          /* cmp ebx, 0x4 */
            ii(0x1017_61a3, 2); if(jz(0x1017_61ae, 0x9)) goto l_0x1017_61ae; /* jz 0x101761ae */
            ii(0x1017_61a5, 3); cmp(ebx, 0x3);                          /* cmp ebx, 0x3 */
            ii(0x1017_61a8, 2); if(jnz(0x1017_61ae, 0x4)) goto l_0x1017_61ae; /* jnz 0x101761ae */
            ii(0x1017_61aa, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1017_61ac, 2); jmp(0x1017_61b3, 0x5); goto l_0x1017_61b3; /* jmp 0x101761b3 */
        l_0x1017_61ae:
            ii(0x1017_61ae, 5); mov(eax, 0x3);                          /* mov eax, 0x3 */
        l_0x1017_61b3:
            ii(0x1017_61b3, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1017_61b5, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1017_61b8, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_61ba, 5); mov(edi, 0xffff_ffff);                  /* mov edi, 0xffffffff */
            ii(0x1017_61bf, 6); mov(ebp, memd[ds, 0x1020_9540]);        /* mov ebp, [0x10209540] */
            ii(0x1017_61c5, 8); mov(memw[ds, eax * 2 + 0x1020_8a46], di); /* mov [eax*2+0x10208a46], di */
            ii(0x1017_61cd, 2); test(ebp, ebp);                         /* test ebp, ebp */
            ii(0x1017_61cf, 2); if(jnz(0x1017_61d8, 0x7)) goto l_0x1017_61d8; /* jnz 0x101761d8 */
            ii(0x1017_61d1, 5); mov(edx, 0x28);                         /* mov edx, 0x28 */
            ii(0x1017_61d6, 2); jmp(0x1017_61f9, 0x21); goto l_0x1017_61f9; /* jmp 0x101761f9 */
        l_0x1017_61d8:
            ii(0x1017_61d8, 3); cmp(ebp, 0x1);                          /* cmp ebp, 0x1 */
            ii(0x1017_61db, 2); if(jnz(0x1017_61e4, 0x7)) goto l_0x1017_61e4; /* jnz 0x101761e4 */
            ii(0x1017_61dd, 5); mov(eax, 0x4);                          /* mov eax, 0x4 */
            ii(0x1017_61e2, 2); jmp(0x1017_61f7, 0x13); goto l_0x1017_61f7; /* jmp 0x101761f7 */
        l_0x1017_61e4:
            ii(0x1017_61e4, 3); cmp(ebp, 0x4);                          /* cmp ebp, 0x4 */
            ii(0x1017_61e7, 2); if(jz(0x1017_61f2, 0x9)) goto l_0x1017_61f2; /* jz 0x101761f2 */
            ii(0x1017_61e9, 3); cmp(ebp, 0x3);                          /* cmp ebp, 0x3 */
            ii(0x1017_61ec, 2); if(jnz(0x1017_61f2, 0x4)) goto l_0x1017_61f2; /* jnz 0x101761f2 */
            ii(0x1017_61ee, 2); mov(eax, ebp);                          /* mov eax, ebp */
            ii(0x1017_61f0, 2); jmp(0x1017_61f7, 0x5); goto l_0x1017_61f7; /* jmp 0x101761f7 */
        l_0x1017_61f2:
            ii(0x1017_61f2, 5); mov(eax, 0x3);                          /* mov eax, 0x3 */
        l_0x1017_61f7:
            ii(0x1017_61f7, 2); mov(edx, eax);                          /* mov edx, eax */
        l_0x1017_61f9:
            ii(0x1017_61f9, 7); lea(eax, edx * 4 + 0);                  /* lea eax, [edx*4] */
            ii(0x1017_6200, 5); mov(ebx, 0xd);                          /* mov ebx, 0xd */
            ii(0x1017_6205, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_6207, 5); mov(edx, 0xffff_ffff);                  /* mov edx, 0xffffffff */
            ii(0x1017_620c, 6); mov(ecx, memd[ds, 0x1020_9540]);        /* mov ecx, [0x10209540] */
            ii(0x1017_6212, 8); mov(memw[ds, eax * 2 + 0x1020_8a48], dx); /* mov [eax*2+0x10208a48], dx */
            ii(0x1017_621a, 5); mov(eax, 0xa);                          /* mov eax, 0xa */
            ii(0x1017_621f, 7); mov(memw[ds, 0x1020_8b58], bx);         /* mov [0x10208b58], bx */
            ii(0x1017_6226, 7); mov(memw[ds, 0x1020_8b5a], bx);         /* mov [0x10208b5a], bx */
            ii(0x1017_622d, 7); mov(memw[ds, 0x1020_8b5c], bx);         /* mov [0x10208b5c], bx */
            ii(0x1017_6234, 7); mov(memw[ds, 0x1020_8b5e], bx);         /* mov [0x10208b5e], bx */
            ii(0x1017_623b, 7); mov(memw[ds, 0x1020_8be4], dx);         /* mov [0x10208be4], dx */
            ii(0x1017_6242, 7); mov(memw[ds, 0x1020_8be6], dx);         /* mov [0x10208be6], dx */
            ii(0x1017_6249, 7); mov(memw[ds, 0x1020_8be8], dx);         /* mov [0x10208be8], dx */
            ii(0x1017_6250, 7); mov(memw[ds, 0x1020_8bea], dx);         /* mov [0x10208bea], dx */
            ii(0x1017_6257, 7); mov(memw[ds, 0x1020_8bec], dx);         /* mov [0x10208bec], dx */
            ii(0x1017_625e, 6); mov(memw[ds, 0x1020_8b60], ax);         /* mov [0x10208b60], ax */
            ii(0x1017_6264, 2); test(ecx, ecx);                         /* test ecx, ecx */
            ii(0x1017_6266, 2); if(jnz(0x1017_626f, 0x7)) goto l_0x1017_626f; /* jnz 0x1017626f */
            ii(0x1017_6268, 5); mov(edx, 0x2c);                         /* mov edx, 0x2c */
            ii(0x1017_626d, 2); jmp(0x1017_629a, 0x2b); goto l_0x1017_629a; /* jmp 0x1017629a */
        l_0x1017_626f:
            ii(0x1017_626f, 3); cmp(ecx, 0x1);                          /* cmp ecx, 0x1 */
            ii(0x1017_6272, 2); if(jnz(0x1017_627b, 0x7)) goto l_0x1017_627b; /* jnz 0x1017627b */
            ii(0x1017_6274, 5); mov(eax, 0x11);                         /* mov eax, 0x11 */
            ii(0x1017_6279, 2); jmp(0x1017_6298, 0x1d); goto l_0x1017_6298; /* jmp 0x10176298 */
        l_0x1017_627b:
            ii(0x1017_627b, 3); cmp(ecx, 0x4);                          /* cmp ecx, 0x4 */
            ii(0x1017_627e, 2); if(jnz(0x1017_6287, 0x7)) goto l_0x1017_6287; /* jnz 0x10176287 */
            ii(0x1017_6280, 5); mov(eax, 0x2c);                         /* mov eax, 0x2c */
            ii(0x1017_6285, 2); jmp(0x1017_6298, 0x11); goto l_0x1017_6298; /* jmp 0x10176298 */
        l_0x1017_6287:
            ii(0x1017_6287, 3); cmp(ecx, 0x3);                          /* cmp ecx, 0x3 */
            ii(0x1017_628a, 2); if(jnz(0x1017_6293, 0x7)) goto l_0x1017_6293; /* jnz 0x10176293 */
            ii(0x1017_628c, 5); mov(eax, 0x2c);                         /* mov eax, 0x2c */
            ii(0x1017_6291, 2); jmp(0x1017_6298, 0x5); goto l_0x1017_6298; /* jmp 0x10176298 */
        l_0x1017_6293:
            ii(0x1017_6293, 5); mov(eax, 0x15);                         /* mov eax, 0x15 */
        l_0x1017_6298:
            ii(0x1017_6298, 2); mov(edx, eax);                          /* mov edx, eax */
        l_0x1017_629a:
            ii(0x1017_629a, 7); lea(eax, edx * 4 + 0);                  /* lea eax, [edx*4] */
            ii(0x1017_62a1, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_62a3, 10); mov(memw[ds, eax * 2 + 0x1020_8a40], 0x7a); /* mov word [eax*2+0x10208a40], 0x7a */
            ii(0x1017_62ad, 5); mov(eax, memd[ds, 0x1020_9540]);        /* mov eax, [0x10209540] */
            ii(0x1017_62b2, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_62b4, 2); if(jnz(0x1017_62bd, 0x7)) goto l_0x1017_62bd; /* jnz 0x101762bd */
            ii(0x1017_62b6, 5); mov(edx, 0x2c);                         /* mov edx, 0x2c */
            ii(0x1017_62bb, 2); jmp(0x1017_62e8, 0x2b); goto l_0x1017_62e8; /* jmp 0x101762e8 */
        l_0x1017_62bd:
            ii(0x1017_62bd, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1017_62c0, 2); if(jnz(0x1017_62c9, 0x7)) goto l_0x1017_62c9; /* jnz 0x101762c9 */
            ii(0x1017_62c2, 5); mov(eax, 0x11);                         /* mov eax, 0x11 */
            ii(0x1017_62c7, 2); jmp(0x1017_62e6, 0x1d); goto l_0x1017_62e6; /* jmp 0x101762e6 */
        l_0x1017_62c9:
            ii(0x1017_62c9, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x1017_62cc, 2); if(jnz(0x1017_62d5, 0x7)) goto l_0x1017_62d5; /* jnz 0x101762d5 */
            ii(0x1017_62ce, 5); mov(eax, 0x2c);                         /* mov eax, 0x2c */
            ii(0x1017_62d3, 2); jmp(0x1017_62e6, 0x11); goto l_0x1017_62e6; /* jmp 0x101762e6 */
        l_0x1017_62d5:
            ii(0x1017_62d5, 3); cmp(eax, 0x3);                          /* cmp eax, 0x3 */
            ii(0x1017_62d8, 2); if(jnz(0x1017_62e1, 0x7)) goto l_0x1017_62e1; /* jnz 0x101762e1 */
            ii(0x1017_62da, 5); mov(eax, 0x2c);                         /* mov eax, 0x2c */
            ii(0x1017_62df, 2); jmp(0x1017_62e6, 0x5); goto l_0x1017_62e6; /* jmp 0x101762e6 */
        l_0x1017_62e1:
            ii(0x1017_62e1, 5); mov(eax, 0x15);                         /* mov eax, 0x15 */
        l_0x1017_62e6:
            ii(0x1017_62e6, 2); mov(edx, eax);                          /* mov edx, eax */
        l_0x1017_62e8:
            ii(0x1017_62e8, 7); lea(eax, edx * 4 + 0);                  /* lea eax, [edx*4] */
            ii(0x1017_62ef, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_62f1, 5); mov(ebx, 0x5a);                         /* mov ebx, 0x5a */
            ii(0x1017_62f6, 6); mov(esi, memd[ds, 0x1020_9540]);        /* mov esi, [0x10209540] */
            ii(0x1017_62fc, 8); mov(memw[ds, eax * 2 + 0x1020_8a42], bx); /* mov [eax*2+0x10208a42], bx */
            ii(0x1017_6304, 2); test(esi, esi);                         /* test esi, esi */
            ii(0x1017_6306, 2); if(jnz(0x1017_630f, 0x7)) goto l_0x1017_630f; /* jnz 0x1017630f */
            ii(0x1017_6308, 5); mov(eax, 0x2c);                         /* mov eax, 0x2c */
            ii(0x1017_630d, 2); jmp(0x1017_6338, 0x29); goto l_0x1017_6338; /* jmp 0x10176338 */
        l_0x1017_630f:
            ii(0x1017_630f, 3); cmp(esi, 0x1);                          /* cmp esi, 0x1 */
            ii(0x1017_6312, 2); if(jnz(0x1017_631b, 0x7)) goto l_0x1017_631b; /* jnz 0x1017631b */
            ii(0x1017_6314, 5); mov(eax, 0x11);                         /* mov eax, 0x11 */
            ii(0x1017_6319, 2); jmp(0x1017_6338, 0x1d); goto l_0x1017_6338; /* jmp 0x10176338 */
        l_0x1017_631b:
            ii(0x1017_631b, 3); cmp(esi, 0x4);                          /* cmp esi, 0x4 */
            ii(0x1017_631e, 2); if(jnz(0x1017_6327, 0x7)) goto l_0x1017_6327; /* jnz 0x10176327 */
            ii(0x1017_6320, 5); mov(eax, 0x2c);                         /* mov eax, 0x2c */
            ii(0x1017_6325, 2); jmp(0x1017_6338, 0x11); goto l_0x1017_6338; /* jmp 0x10176338 */
        l_0x1017_6327:
            ii(0x1017_6327, 3); cmp(esi, 0x3);                          /* cmp esi, 0x3 */
            ii(0x1017_632a, 2); if(jnz(0x1017_6333, 0x7)) goto l_0x1017_6333; /* jnz 0x10176333 */
            ii(0x1017_632c, 5); mov(eax, 0x2c);                         /* mov eax, 0x2c */
            ii(0x1017_6331, 2); jmp(0x1017_6338, 0x5); goto l_0x1017_6338; /* jmp 0x10176338 */
        l_0x1017_6333:
            ii(0x1017_6333, 5); mov(eax, 0x15);                         /* mov eax, 0x15 */
        l_0x1017_6338:
            ii(0x1017_6338, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1017_633a, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1017_633d, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_633f, 5); mov(ecx, 0x12c);                        /* mov ecx, 0x12c */
            ii(0x1017_6344, 6); mov(edx, memd[ds, 0x1020_9540]);        /* mov edx, [0x10209540] */
            ii(0x1017_634a, 8); mov(memw[ds, eax * 2 + 0x1020_8a44], cx); /* mov [eax*2+0x10208a44], cx */
            ii(0x1017_6352, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1017_6354, 2); if(jnz(0x1017_635d, 0x7)) goto l_0x1017_635d; /* jnz 0x1017635d */
            ii(0x1017_6356, 5); mov(edx, 0x2c);                         /* mov edx, 0x2c */
            ii(0x1017_635b, 2); jmp(0x1017_6388, 0x2b); goto l_0x1017_6388; /* jmp 0x10176388 */
        l_0x1017_635d:
            ii(0x1017_635d, 3); cmp(edx, 0x1);                          /* cmp edx, 0x1 */
            ii(0x1017_6360, 2); if(jnz(0x1017_6369, 0x7)) goto l_0x1017_6369; /* jnz 0x10176369 */
            ii(0x1017_6362, 5); mov(eax, 0x11);                         /* mov eax, 0x11 */
            ii(0x1017_6367, 2); jmp(0x1017_6386, 0x1d); goto l_0x1017_6386; /* jmp 0x10176386 */
        l_0x1017_6369:
            ii(0x1017_6369, 3); cmp(edx, 0x4);                          /* cmp edx, 0x4 */
            ii(0x1017_636c, 2); if(jnz(0x1017_6375, 0x7)) goto l_0x1017_6375; /* jnz 0x10176375 */
            ii(0x1017_636e, 5); mov(eax, 0x2c);                         /* mov eax, 0x2c */
            ii(0x1017_6373, 2); jmp(0x1017_6386, 0x11); goto l_0x1017_6386; /* jmp 0x10176386 */
        l_0x1017_6375:
            ii(0x1017_6375, 3); cmp(edx, 0x3);                          /* cmp edx, 0x3 */
            ii(0x1017_6378, 2); if(jnz(0x1017_6381, 0x7)) goto l_0x1017_6381; /* jnz 0x10176381 */
            ii(0x1017_637a, 5); mov(eax, 0x2c);                         /* mov eax, 0x2c */
            ii(0x1017_637f, 2); jmp(0x1017_6386, 0x5); goto l_0x1017_6386; /* jmp 0x10176386 */
        l_0x1017_6381:
            ii(0x1017_6381, 5); mov(eax, 0x15);                         /* mov eax, 0x15 */
        l_0x1017_6386:
            ii(0x1017_6386, 2); mov(edx, eax);                          /* mov edx, eax */
        l_0x1017_6388:
            ii(0x1017_6388, 7); lea(eax, edx * 4 + 0);                  /* lea eax, [edx*4] */
            ii(0x1017_638f, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_6391, 5); mov(esi, 0x12c);                        /* mov esi, 0x12c */
            ii(0x1017_6396, 6); mov(edi, memd[ds, 0x1020_9540]);        /* mov edi, [0x10209540] */
            ii(0x1017_639c, 8); mov(memw[ds, eax * 2 + 0x1020_8a46], si); /* mov [eax*2+0x10208a46], si */
            ii(0x1017_63a4, 2); test(edi, edi);                         /* test edi, edi */
            ii(0x1017_63a6, 2); if(jnz(0x1017_63af, 0x7)) goto l_0x1017_63af; /* jnz 0x101763af */
            ii(0x1017_63a8, 5); mov(eax, 0x2c);                         /* mov eax, 0x2c */
            ii(0x1017_63ad, 2); jmp(0x1017_63d8, 0x29); goto l_0x1017_63d8; /* jmp 0x101763d8 */
        l_0x1017_63af:
            ii(0x1017_63af, 3); cmp(edi, 0x1);                          /* cmp edi, 0x1 */
            ii(0x1017_63b2, 2); if(jnz(0x1017_63bb, 0x7)) goto l_0x1017_63bb; /* jnz 0x101763bb */
            ii(0x1017_63b4, 5); mov(eax, 0x11);                         /* mov eax, 0x11 */
            ii(0x1017_63b9, 2); jmp(0x1017_63d8, 0x1d); goto l_0x1017_63d8; /* jmp 0x101763d8 */
        l_0x1017_63bb:
            ii(0x1017_63bb, 3); cmp(edi, 0x4);                          /* cmp edi, 0x4 */
            ii(0x1017_63be, 2); if(jnz(0x1017_63c7, 0x7)) goto l_0x1017_63c7; /* jnz 0x101763c7 */
            ii(0x1017_63c0, 5); mov(eax, 0x2c);                         /* mov eax, 0x2c */
            ii(0x1017_63c5, 2); jmp(0x1017_63d8, 0x11); goto l_0x1017_63d8; /* jmp 0x101763d8 */
        l_0x1017_63c7:
            ii(0x1017_63c7, 3); cmp(edi, 0x3);                          /* cmp edi, 0x3 */
            ii(0x1017_63ca, 2); if(jnz(0x1017_63d3, 0x7)) goto l_0x1017_63d3; /* jnz 0x101763d3 */
            ii(0x1017_63cc, 5); mov(eax, 0x2c);                         /* mov eax, 0x2c */
            ii(0x1017_63d1, 2); jmp(0x1017_63d8, 0x5); goto l_0x1017_63d8; /* jmp 0x101763d8 */
        l_0x1017_63d3:
            ii(0x1017_63d3, 5); mov(eax, 0x15);                         /* mov eax, 0x15 */
        l_0x1017_63d8:
            ii(0x1017_63d8, 5); mov(edi, 0x1a);                         /* mov edi, 0x1a */
            ii(0x1017_63dd, 5); mov(ebx, 0x12d);                        /* mov ebx, 0x12d */
            ii(0x1017_63e2, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1017_63e4, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1017_63e7, 5); mov(esi, 0x18);                         /* mov esi, 0x18 */
            ii(0x1017_63ec, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_63ee, 5); mov(ecx, 0x3);                          /* mov ecx, 0x3 */
            ii(0x1017_63f3, 5); mov(edx, 0x58);                         /* mov edx, 0x58 */
            ii(0x1017_63f8, 8); mov(memw[ds, eax * 2 + 0x1020_8a48], di); /* mov [eax*2+0x10208a48], di */
            ii(0x1017_6400, 5); mov(eax, 0x78);                         /* mov eax, 0x78 */
            ii(0x1017_6405, 5); mov(edi, 0x63);                         /* mov edi, 0x63 */
            ii(0x1017_640a, 7); mov(memw[ds, 0x1020_8c04], dx);         /* mov [0x10208c04], dx */
            ii(0x1017_6411, 7); mov(memw[ds, 0x1020_8c06], bx);         /* mov [0x10208c06], bx */
            ii(0x1017_6418, 7); mov(memw[ds, 0x1020_8c08], bx);         /* mov [0x10208c08], bx */
            ii(0x1017_641f, 7); mov(memw[ds, 0x1020_8c0a], si);         /* mov [0x10208c0a], si */
            ii(0x1017_6426, 7); mov(memw[ds, 0x1020_8c14], cx);         /* mov [0x10208c14], cx */
            ii(0x1017_642d, 5); mov(edx, 0x12e);                        /* mov edx, 0x12e */
            ii(0x1017_6432, 5); mov(esi, 0x76);                         /* mov esi, 0x76 */
            ii(0x1017_6437, 5); mov(ebx, 0x16);                         /* mov ebx, 0x16 */
            ii(0x1017_643c, 5); mov(ecx, 0x62);                         /* mov ecx, 0x62 */
            ii(0x1017_6441, 6); mov(memw[ds, 0x1020_8c02], ax);         /* mov [0x10208c02], ax */
            ii(0x1017_6447, 7); mov(memw[ds, 0x1020_8c0c], di);         /* mov [0x10208c0c], di */
            ii(0x1017_644e, 5); mov(eax, 0x43);                         /* mov eax, 0x43 */
            ii(0x1017_6453, 5); mov(edi, 0x56);                         /* mov edi, 0x56 */
            ii(0x1017_6458, 7); mov(memw[ds, 0x1020_8c10], dx);         /* mov [0x10208c10], dx */
            ii(0x1017_645f, 7); mov(memw[ds, 0x1020_8c12], dx);         /* mov [0x10208c12], dx */
            ii(0x1017_6466, 7); mov(memw[ds, 0x1020_8c16], si);         /* mov [0x10208c16], si */
            ii(0x1017_646d, 7); mov(memw[ds, 0x1020_8c1e], bx);         /* mov [0x10208c1e], bx */
            ii(0x1017_6474, 7); mov(memw[ds, 0x1020_8c20], cx);         /* mov [0x10208c20], cx */
            ii(0x1017_647b, 5); mov(esi, 0x42);                         /* mov esi, 0x42 */
            ii(0x1017_6480, 5); mov(edx, 0x2);                          /* mov edx, 0x2 */
            ii(0x1017_6485, 5); mov(ebx, 0x6e);                         /* mov ebx, 0x6e */
            ii(0x1017_648a, 5); mov(ecx, 0x4e);                         /* mov ecx, 0x4e */
            ii(0x1017_648f, 6); mov(memw[ds, 0x1020_8c0e], ax);         /* mov [0x10208c0e], ax */
            ii(0x1017_6495, 7); mov(memw[ds, 0x1020_8c18], di);         /* mov [0x10208c18], di */
            ii(0x1017_649c, 5); mov(eax, 0x12f);                        /* mov eax, 0x12f */
            ii(0x1017_64a1, 5); mov(edi, 0x130);                        /* mov edi, 0x130 */
            ii(0x1017_64a6, 7); mov(memw[ds, 0x1020_8c22], si);         /* mov [0x10208c22], si */
            ii(0x1017_64ad, 7); mov(memw[ds, 0x1020_8c28], dx);         /* mov [0x10208c28], dx */
            ii(0x1017_64b4, 7); mov(memw[ds, 0x1020_8c2a], bx);         /* mov [0x10208c2a], bx */
            ii(0x1017_64bb, 7); mov(memw[ds, 0x1020_8c2c], cx);         /* mov [0x10208c2c], cx */
            ii(0x1017_64c2, 5); mov(esi, 0x131);                        /* mov esi, 0x131 */
            ii(0x1017_64c7, 6); mov(ebx, memd[ds, 0x1020_9540]);        /* mov ebx, [0x10209540] */
            ii(0x1017_64cd, 6); mov(memw[ds, 0x1020_8c1a], ax);         /* mov [0x10208c1a], ax */
            ii(0x1017_64d3, 6); mov(memw[ds, 0x1020_8c1c], ax);         /* mov [0x10208c1c], ax */
            ii(0x1017_64d9, 7); mov(memw[ds, 0x1020_8c24], di);         /* mov [0x10208c24], di */
            ii(0x1017_64e0, 7); mov(memw[ds, 0x1020_8c26], di);         /* mov [0x10208c26], di */
            ii(0x1017_64e7, 5); mov(eax, 0xe);                          /* mov eax, 0xe */
            ii(0x1017_64ec, 7); mov(memw[ds, 0x1020_8c2e], si);         /* mov [0x10208c2e], si */
            ii(0x1017_64f3, 7); mov(memw[ds, 0x1020_8c30], si);         /* mov [0x10208c30], si */
            ii(0x1017_64fa, 6); mov(memw[ds, 0x1020_8c32], ax);         /* mov [0x10208c32], ax */
            ii(0x1017_6500, 2); test(ebx, ebx);                         /* test ebx, ebx */
            ii(0x1017_6502, 2); if(jnz(0x1017_650b, 0x7)) goto l_0x1017_650b; /* jnz 0x1017650b */
            ii(0x1017_6504, 5); mov(edx, 0x32);                         /* mov edx, 0x32 */
            ii(0x1017_6509, 2); jmp(0x1017_6526, 0x1b); goto l_0x1017_6526; /* jmp 0x10176526 */
        l_0x1017_650b:
            ii(0x1017_650b, 3); cmp(ebx, 0x1);                          /* cmp ebx, 0x1 */
            ii(0x1017_650e, 2); if(jnz(0x1017_6517, 0x7)) goto l_0x1017_6517; /* jnz 0x10176517 */
            ii(0x1017_6510, 5); mov(eax, 0x27);                         /* mov eax, 0x27 */
            ii(0x1017_6515, 2); jmp(0x1017_6524, 0xd); goto l_0x1017_6524; /* jmp 0x10176524 */
        l_0x1017_6517:
            ii(0x1017_6517, 3); cmp(ebx, 0x4);                          /* cmp ebx, 0x4 */
            ii(0x1017_651a, 2); if(jz(0x1017_651f, 0x3)) goto l_0x1017_651f; /* jz 0x1017651f */
            ii(0x1017_651c, 3); cmp(ebx, 0x3);                          /* cmp ebx, 0x3 */
        l_0x1017_651f:
            ii(0x1017_651f, 5); mov(eax, 0x32);                         /* mov eax, 0x32 */
        l_0x1017_6524:
            ii(0x1017_6524, 2); mov(edx, eax);                          /* mov edx, eax */
        l_0x1017_6526:
            ii(0x1017_6526, 7); lea(eax, edx * 4 + 0);                  /* lea eax, [edx*4] */
            ii(0x1017_652d, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_652f, 5); mov(edx, 0x6d);                         /* mov edx, 0x6d */
            ii(0x1017_6534, 6); mov(ebp, memd[ds, 0x1020_9540]);        /* mov ebp, [0x10209540] */
            ii(0x1017_653a, 8); mov(memw[ds, eax * 2 + 0x1020_8a40], dx); /* mov [eax*2+0x10208a40], dx */
            ii(0x1017_6542, 2); test(ebp, ebp);                         /* test ebp, ebp */
            ii(0x1017_6544, 2); if(jz(0x1017_655a, 0x14)) goto l_0x1017_655a; /* jz 0x1017655a */
            ii(0x1017_6546, 3); cmp(ebp, 0x1);                          /* cmp ebp, 0x1 */
            ii(0x1017_6549, 2); if(jnz(0x1017_6552, 0x7)) goto l_0x1017_6552; /* jnz 0x10176552 */
            ii(0x1017_654b, 5); mov(eax, 0x27);                         /* mov eax, 0x27 */
            ii(0x1017_6550, 2); jmp(0x1017_655f, 0xd); goto l_0x1017_655f; /* jmp 0x1017655f */
        l_0x1017_6552:
            ii(0x1017_6552, 3); cmp(ebp, 0x4);                          /* cmp ebp, 0x4 */
            ii(0x1017_6555, 2); if(jz(0x1017_655a, 0x3)) goto l_0x1017_655a; /* jz 0x1017655a */
            ii(0x1017_6557, 3); cmp(ebp, 0x3);                          /* cmp ebp, 0x3 */
        l_0x1017_655a:
            ii(0x1017_655a, 5); mov(eax, 0x32);                         /* mov eax, 0x32 */
        l_0x1017_655f:
            ii(0x1017_655f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1017_6561, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1017_6564, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_6566, 5); mov(ebx, 0x4d);                         /* mov ebx, 0x4d */
            ii(0x1017_656b, 6); mov(ecx, memd[ds, 0x1020_9540]);        /* mov ecx, [0x10209540] */
            ii(0x1017_6571, 8); mov(memw[ds, eax * 2 + 0x1020_8a42], bx); /* mov [eax*2+0x10208a42], bx */
            ii(0x1017_6579, 2); test(ecx, ecx);                         /* test ecx, ecx */
            ii(0x1017_657b, 2); if(jz(0x1017_6591, 0x14)) goto l_0x1017_6591; /* jz 0x10176591 */
            ii(0x1017_657d, 3); cmp(ecx, 0x1);                          /* cmp ecx, 0x1 */
            ii(0x1017_6580, 2); if(jnz(0x1017_6589, 0x7)) goto l_0x1017_6589; /* jnz 0x10176589 */
            ii(0x1017_6582, 5); mov(eax, 0x27);                         /* mov eax, 0x27 */
            ii(0x1017_6587, 2); jmp(0x1017_6596, 0xd); goto l_0x1017_6596; /* jmp 0x10176596 */
        l_0x1017_6589:
            ii(0x1017_6589, 3); cmp(ecx, 0x4);                          /* cmp ecx, 0x4 */
            ii(0x1017_658c, 2); if(jz(0x1017_6591, 0x3)) goto l_0x1017_6591; /* jz 0x10176591 */
            ii(0x1017_658e, 3); cmp(ecx, 0x3);                          /* cmp ecx, 0x3 */
        l_0x1017_6591:
            ii(0x1017_6591, 5); mov(eax, 0x32);                         /* mov eax, 0x32 */
        l_0x1017_6596:
            ii(0x1017_6596, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1017_6598, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1017_659b, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_659d, 10); mov(memw[ds, eax * 2 + 0x1020_8a44], 0x132); /* mov word [eax*2+0x10208a44], 0x132 */
            ii(0x1017_65a7, 5); mov(eax, memd[ds, 0x1020_9540]);        /* mov eax, [0x10209540] */
            ii(0x1017_65ac, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_65ae, 2); if(jnz(0x1017_65b7, 0x7)) goto l_0x1017_65b7; /* jnz 0x101765b7 */
            ii(0x1017_65b0, 5); mov(edx, 0x32);                         /* mov edx, 0x32 */
            ii(0x1017_65b5, 2); jmp(0x1017_65d2, 0x1b); goto l_0x1017_65d2; /* jmp 0x101765d2 */
        l_0x1017_65b7:
            ii(0x1017_65b7, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1017_65ba, 2); if(jnz(0x1017_65c3, 0x7)) goto l_0x1017_65c3; /* jnz 0x101765c3 */
            ii(0x1017_65bc, 5); mov(eax, 0x27);                         /* mov eax, 0x27 */
            ii(0x1017_65c1, 2); jmp(0x1017_65d0, 0xd); goto l_0x1017_65d0; /* jmp 0x101765d0 */
        l_0x1017_65c3:
            ii(0x1017_65c3, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x1017_65c6, 2); if(jz(0x1017_65cb, 0x3)) goto l_0x1017_65cb; /* jz 0x101765cb */
            ii(0x1017_65c8, 3); cmp(eax, 0x3);                          /* cmp eax, 0x3 */
        l_0x1017_65cb:
            ii(0x1017_65cb, 5); mov(eax, 0x32);                         /* mov eax, 0x32 */
        l_0x1017_65d0:
            ii(0x1017_65d0, 2); mov(edx, eax);                          /* mov edx, eax */
        l_0x1017_65d2:
            ii(0x1017_65d2, 7); lea(eax, edx * 4 + 0);                  /* lea eax, [edx*4] */
            ii(0x1017_65d9, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_65db, 10); mov(memw[ds, eax * 2 + 0x1020_8a46], 0x132); /* mov word [eax*2+0x10208a46], 0x132 */
            ii(0x1017_65e5, 6); mov(esi, memd[ds, 0x1020_9540]);        /* mov esi, [0x10209540] */
            ii(0x1017_65eb, 2); test(esi, esi);                         /* test esi, esi */
            ii(0x1017_65ed, 2); if(jnz(0x1017_65f6, 0x7)) goto l_0x1017_65f6; /* jnz 0x101765f6 */
            ii(0x1017_65ef, 5); mov(edx, 0x32);                         /* mov edx, 0x32 */
            ii(0x1017_65f4, 2); jmp(0x1017_6611, 0x1b); goto l_0x1017_6611; /* jmp 0x10176611 */
        l_0x1017_65f6:
            ii(0x1017_65f6, 3); cmp(esi, 0x1);                          /* cmp esi, 0x1 */
            ii(0x1017_65f9, 2); if(jnz(0x1017_6602, 0x7)) goto l_0x1017_6602; /* jnz 0x10176602 */
            ii(0x1017_65fb, 5); mov(eax, 0x27);                         /* mov eax, 0x27 */
            ii(0x1017_6600, 2); jmp(0x1017_660f, 0xd); goto l_0x1017_660f; /* jmp 0x1017660f */
        l_0x1017_6602:
            ii(0x1017_6602, 3); cmp(esi, 0x4);                          /* cmp esi, 0x4 */
            ii(0x1017_6605, 2); if(jz(0x1017_660a, 0x3)) goto l_0x1017_660a; /* jz 0x1017660a */
            ii(0x1017_6607, 3); cmp(esi, 0x3);                          /* cmp esi, 0x3 */
        l_0x1017_660a:
            ii(0x1017_660a, 5); mov(eax, 0x32);                         /* mov eax, 0x32 */
        l_0x1017_660f:
            ii(0x1017_660f, 2); mov(edx, eax);                          /* mov edx, eax */
        l_0x1017_6611:
            ii(0x1017_6611, 7); lea(eax, edx * 4 + 0);                  /* lea eax, [edx*4] */
            ii(0x1017_6618, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_661a, 5); mov(edi, 0xd);                          /* mov edi, 0xd */
            ii(0x1017_661f, 6); mov(edx, memd[ds, 0x1020_9540]);        /* mov edx, [0x10209540] */
            ii(0x1017_6625, 8); mov(memw[ds, eax * 2 + 0x1020_8a48], di); /* mov [eax*2+0x10208a48], di */
            ii(0x1017_662d, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1017_662f, 2); if(jnz(0x1017_6638, 0x7)) goto l_0x1017_6638; /* jnz 0x10176638 */
            ii(0x1017_6631, 5); mov(edx, 0x33);                         /* mov edx, 0x33 */
            ii(0x1017_6636, 2); jmp(0x1017_6653, 0x1b); goto l_0x1017_6653; /* jmp 0x10176653 */
        l_0x1017_6638:
            ii(0x1017_6638, 3); cmp(edx, 0x1);                          /* cmp edx, 0x1 */
            ii(0x1017_663b, 2); if(jnz(0x1017_6644, 0x7)) goto l_0x1017_6644; /* jnz 0x10176644 */
            ii(0x1017_663d, 5); mov(eax, 0x32);                         /* mov eax, 0x32 */
            ii(0x1017_6642, 2); jmp(0x1017_6651, 0xd); goto l_0x1017_6651; /* jmp 0x10176651 */
        l_0x1017_6644:
            ii(0x1017_6644, 3); cmp(edx, 0x4);                          /* cmp edx, 0x4 */
            ii(0x1017_6647, 2); if(jz(0x1017_664c, 0x3)) goto l_0x1017_664c; /* jz 0x1017664c */
            ii(0x1017_6649, 3); cmp(edx, 0x3);                          /* cmp edx, 0x3 */
        l_0x1017_664c:
            ii(0x1017_664c, 5); mov(eax, 0x33);                         /* mov eax, 0x33 */
        l_0x1017_6651:
            ii(0x1017_6651, 2); mov(edx, eax);                          /* mov edx, eax */
        l_0x1017_6653:
            ii(0x1017_6653, 7); lea(eax, edx * 4 + 0);                  /* lea eax, [edx*4] */
            ii(0x1017_665a, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_665c, 5); mov(edx, 0x2c);                         /* mov edx, 0x2c */
            ii(0x1017_6661, 6); mov(edi, memd[ds, 0x1020_9540]);        /* mov edi, [0x10209540] */
            ii(0x1017_6667, 8); mov(memw[ds, eax * 2 + 0x1020_8a40], dx); /* mov [eax*2+0x10208a40], dx */
            ii(0x1017_666f, 2); test(edi, edi);                         /* test edi, edi */
            ii(0x1017_6671, 2); if(jnz(0x1017_667a, 0x7)) goto l_0x1017_667a; /* jnz 0x1017667a */
            ii(0x1017_6673, 5); mov(edx, 0x33);                         /* mov edx, 0x33 */
            ii(0x1017_6678, 2); jmp(0x1017_6695, 0x1b); goto l_0x1017_6695; /* jmp 0x10176695 */
        l_0x1017_667a:
            ii(0x1017_667a, 3); cmp(edi, 0x1);                          /* cmp edi, 0x1 */
            ii(0x1017_667d, 2); if(jnz(0x1017_6686, 0x7)) goto l_0x1017_6686; /* jnz 0x10176686 */
            ii(0x1017_667f, 5); mov(eax, 0x32);                         /* mov eax, 0x32 */
            ii(0x1017_6684, 2); jmp(0x1017_6693, 0xd); goto l_0x1017_6693; /* jmp 0x10176693 */
        l_0x1017_6686:
            ii(0x1017_6686, 3); cmp(edi, 0x4);                          /* cmp edi, 0x4 */
            ii(0x1017_6689, 2); if(jz(0x1017_668e, 0x3)) goto l_0x1017_668e; /* jz 0x1017668e */
            ii(0x1017_668b, 3); cmp(edi, 0x3);                          /* cmp edi, 0x3 */
        l_0x1017_668e:
            ii(0x1017_668e, 5); mov(eax, 0x33);                         /* mov eax, 0x33 */
        l_0x1017_6693:
            ii(0x1017_6693, 2); mov(edx, eax);                          /* mov edx, eax */
        l_0x1017_6695:
            ii(0x1017_6695, 7); lea(eax, edx * 4 + 0);                  /* lea eax, [edx*4] */
            ii(0x1017_669c, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_669e, 10); mov(memw[ds, eax * 2 + 0x1020_8a42], 0x3c); /* mov word [eax*2+0x10208a42], 0x3c */
            ii(0x1017_66a8, 6); mov(ebx, memd[ds, 0x1020_9540]);        /* mov ebx, [0x10209540] */
            ii(0x1017_66ae, 2); test(ebx, ebx);                         /* test ebx, ebx */
            ii(0x1017_66b0, 2); if(jnz(0x1017_66b9, 0x7)) goto l_0x1017_66b9; /* jnz 0x101766b9 */
            ii(0x1017_66b2, 5); mov(edx, 0x33);                         /* mov edx, 0x33 */
            ii(0x1017_66b7, 2); jmp(0x1017_66d4, 0x1b); goto l_0x1017_66d4; /* jmp 0x101766d4 */
        l_0x1017_66b9:
            ii(0x1017_66b9, 3); cmp(ebx, 0x1);                          /* cmp ebx, 0x1 */
            ii(0x1017_66bc, 2); if(jnz(0x1017_66c5, 0x7)) goto l_0x1017_66c5; /* jnz 0x101766c5 */
            ii(0x1017_66be, 5); mov(eax, 0x32);                         /* mov eax, 0x32 */
            ii(0x1017_66c3, 2); jmp(0x1017_66d2, 0xd); goto l_0x1017_66d2; /* jmp 0x101766d2 */
        l_0x1017_66c5:
            ii(0x1017_66c5, 3); cmp(ebx, 0x4);                          /* cmp ebx, 0x4 */
            ii(0x1017_66c8, 2); if(jz(0x1017_66cd, 0x3)) goto l_0x1017_66cd; /* jz 0x101766cd */
            ii(0x1017_66ca, 3); cmp(ebx, 0x3);                          /* cmp ebx, 0x3 */
        l_0x1017_66cd:
            ii(0x1017_66cd, 5); mov(eax, 0x33);                         /* mov eax, 0x33 */
        l_0x1017_66d2:
            ii(0x1017_66d2, 2); mov(edx, eax);                          /* mov edx, eax */
        l_0x1017_66d4:
            ii(0x1017_66d4, 7); lea(eax, edx * 4 + 0);                  /* lea eax, [edx*4] */
            ii(0x1017_66db, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_66dd, 5); mov(ecx, 0xffff_ffff);                  /* mov ecx, 0xffffffff */
            ii(0x1017_66e2, 6); mov(ebp, memd[ds, 0x1020_9540]);        /* mov ebp, [0x10209540] */
            ii(0x1017_66e8, 8); mov(memw[ds, eax * 2 + 0x1020_8a44], cx); /* mov [eax*2+0x10208a44], cx */
            ii(0x1017_66f0, 2); test(ebp, ebp);                         /* test ebp, ebp */
            ii(0x1017_66f2, 2); if(jnz(0x1017_66fb, 0x7)) goto l_0x1017_66fb; /* jnz 0x101766fb */
            ii(0x1017_66f4, 5); mov(edx, 0x33);                         /* mov edx, 0x33 */
            ii(0x1017_66f9, 2); jmp(0x1017_6716, 0x1b); goto l_0x1017_6716; /* jmp 0x10176716 */
        l_0x1017_66fb:
            ii(0x1017_66fb, 3); cmp(ebp, 0x1);                          /* cmp ebp, 0x1 */
            ii(0x1017_66fe, 2); if(jnz(0x1017_6707, 0x7)) goto l_0x1017_6707; /* jnz 0x10176707 */
            ii(0x1017_6700, 5); mov(eax, 0x32);                         /* mov eax, 0x32 */
            ii(0x1017_6705, 2); jmp(0x1017_6714, 0xd); goto l_0x1017_6714; /* jmp 0x10176714 */
        l_0x1017_6707:
            ii(0x1017_6707, 3); cmp(ebp, 0x4);                          /* cmp ebp, 0x4 */
            ii(0x1017_670a, 2); if(jz(0x1017_670f, 0x3)) goto l_0x1017_670f; /* jz 0x1017670f */
            ii(0x1017_670c, 3); cmp(ebp, 0x3);                          /* cmp ebp, 0x3 */
        l_0x1017_670f:
            ii(0x1017_670f, 5); mov(eax, 0x33);                         /* mov eax, 0x33 */
        l_0x1017_6714:
            ii(0x1017_6714, 2); mov(edx, eax);                          /* mov edx, eax */
        l_0x1017_6716:
            ii(0x1017_6716, 7); lea(eax, edx * 4 + 0);                  /* lea eax, [edx*4] */
            ii(0x1017_671d, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_671f, 5); mov(esi, 0xffff_ffff);                  /* mov esi, 0xffffffff */
            ii(0x1017_6724, 6); mov(ecx, memd[ds, 0x1020_9540]);        /* mov ecx, [0x10209540] */
            ii(0x1017_672a, 8); mov(memw[ds, eax * 2 + 0x1020_8a46], si); /* mov [eax*2+0x10208a46], si */
            ii(0x1017_6732, 2); test(ecx, ecx);                         /* test ecx, ecx */
            ii(0x1017_6734, 2); if(jnz(0x1017_673d, 0x7)) goto l_0x1017_673d; /* jnz 0x1017673d */
            ii(0x1017_6736, 5); mov(edx, 0x33);                         /* mov edx, 0x33 */
            ii(0x1017_673b, 2); jmp(0x1017_6758, 0x1b); goto l_0x1017_6758; /* jmp 0x10176758 */
        l_0x1017_673d:
            ii(0x1017_673d, 3); cmp(ecx, 0x1);                          /* cmp ecx, 0x1 */
            ii(0x1017_6740, 2); if(jnz(0x1017_6749, 0x7)) goto l_0x1017_6749; /* jnz 0x10176749 */
            ii(0x1017_6742, 5); mov(eax, 0x32);                         /* mov eax, 0x32 */
            ii(0x1017_6747, 2); jmp(0x1017_6756, 0xd); goto l_0x1017_6756; /* jmp 0x10176756 */
        l_0x1017_6749:
            ii(0x1017_6749, 3); cmp(ecx, 0x4);                          /* cmp ecx, 0x4 */
            ii(0x1017_674c, 2); if(jz(0x1017_6751, 0x3)) goto l_0x1017_6751; /* jz 0x10176751 */
            ii(0x1017_674e, 3); cmp(ecx, 0x3);                          /* cmp ecx, 0x3 */
        l_0x1017_6751:
            ii(0x1017_6751, 5); mov(eax, 0x33);                         /* mov eax, 0x33 */
        l_0x1017_6756:
            ii(0x1017_6756, 2); mov(edx, eax);                          /* mov edx, eax */
        l_0x1017_6758:
            ii(0x1017_6758, 7); lea(eax, edx * 4 + 0);                  /* lea eax, [edx*4] */
            ii(0x1017_675f, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_6761, 10); mov(memw[ds, eax * 2 + 0x1020_8a48], 0xffff); /* mov word [eax*2+0x10208a48], 0xffff */
            ii(0x1017_676b, 5); mov(eax, memd[ds, 0x1020_9540]);        /* mov eax, [0x10209540] */
            ii(0x1017_6770, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_6772, 2); if(jnz(0x1017_677b, 0x7)) goto l_0x1017_677b; /* jnz 0x1017677b */
            ii(0x1017_6774, 5); mov(edx, 0x34);                         /* mov edx, 0x34 */
            ii(0x1017_6779, 2); jmp(0x1017_6796, 0x1b); goto l_0x1017_6796; /* jmp 0x10176796 */
        l_0x1017_677b:
            ii(0x1017_677b, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1017_677e, 2); if(jnz(0x1017_6787, 0x7)) goto l_0x1017_6787; /* jnz 0x10176787 */
            ii(0x1017_6780, 5); mov(eax, 0x33);                         /* mov eax, 0x33 */
            ii(0x1017_6785, 2); jmp(0x1017_6794, 0xd); goto l_0x1017_6794; /* jmp 0x10176794 */
        l_0x1017_6787:
            ii(0x1017_6787, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x1017_678a, 2); if(jz(0x1017_678f, 0x3)) goto l_0x1017_678f; /* jz 0x1017678f */
            ii(0x1017_678c, 3); cmp(eax, 0x3);                          /* cmp eax, 0x3 */
        l_0x1017_678f:
            ii(0x1017_678f, 5); mov(eax, 0x34);                         /* mov eax, 0x34 */
        l_0x1017_6794:
            ii(0x1017_6794, 2); mov(edx, eax);                          /* mov edx, eax */
        l_0x1017_6796:
            ii(0x1017_6796, 7); lea(eax, edx * 4 + 0);                  /* lea eax, [edx*4] */
            ii(0x1017_679d, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_679f, 5); mov(edx, 0x2e);                         /* mov edx, 0x2e */
            ii(0x1017_67a4, 6); mov(esi, memd[ds, 0x1020_9540]);        /* mov esi, [0x10209540] */
            ii(0x1017_67aa, 8); mov(memw[ds, eax * 2 + 0x1020_8a40], dx); /* mov [eax*2+0x10208a40], dx */
            ii(0x1017_67b2, 2); test(esi, esi);                         /* test esi, esi */
            ii(0x1017_67b4, 2); if(jnz(0x1017_67bd, 0x7)) goto l_0x1017_67bd; /* jnz 0x101767bd */
            ii(0x1017_67b6, 5); mov(edx, 0x34);                         /* mov edx, 0x34 */
            ii(0x1017_67bb, 2); jmp(0x1017_67d8, 0x1b); goto l_0x1017_67d8; /* jmp 0x101767d8 */
        l_0x1017_67bd:
            ii(0x1017_67bd, 3); cmp(esi, 0x1);                          /* cmp esi, 0x1 */
            ii(0x1017_67c0, 2); if(jnz(0x1017_67c9, 0x7)) goto l_0x1017_67c9; /* jnz 0x101767c9 */
            ii(0x1017_67c2, 5); mov(eax, 0x33);                         /* mov eax, 0x33 */
            ii(0x1017_67c7, 2); jmp(0x1017_67d6, 0xd); goto l_0x1017_67d6; /* jmp 0x101767d6 */
        l_0x1017_67c9:
            ii(0x1017_67c9, 3); cmp(esi, 0x4);                          /* cmp esi, 0x4 */
            ii(0x1017_67cc, 2); if(jz(0x1017_67d1, 0x3)) goto l_0x1017_67d1; /* jz 0x101767d1 */
            ii(0x1017_67ce, 3); cmp(esi, 0x3);                          /* cmp esi, 0x3 */
        l_0x1017_67d1:
            ii(0x1017_67d1, 5); mov(eax, 0x34);                         /* mov eax, 0x34 */
        l_0x1017_67d6:
            ii(0x1017_67d6, 2); mov(edx, eax);                          /* mov edx, eax */
        l_0x1017_67d8:
            ii(0x1017_67d8, 7); lea(eax, edx * 4 + 0);                  /* lea eax, [edx*4] */
            ii(0x1017_67df, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_67e1, 5); mov(ebx, 0x3e);                         /* mov ebx, 0x3e */
            ii(0x1017_67e6, 6); mov(edx, memd[ds, 0x1020_9540]);        /* mov edx, [0x10209540] */
            ii(0x1017_67ec, 8); mov(memw[ds, eax * 2 + 0x1020_8a42], bx); /* mov [eax*2+0x10208a42], bx */
            ii(0x1017_67f4, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1017_67f6, 2); if(jnz(0x1017_67ff, 0x7)) goto l_0x1017_67ff; /* jnz 0x101767ff */
            ii(0x1017_67f8, 5); mov(edx, 0x34);                         /* mov edx, 0x34 */
            ii(0x1017_67fd, 2); jmp(0x1017_681a, 0x1b); goto l_0x1017_681a; /* jmp 0x1017681a */
        l_0x1017_67ff:
            ii(0x1017_67ff, 3); cmp(edx, 0x1);                          /* cmp edx, 0x1 */
            ii(0x1017_6802, 2); if(jnz(0x1017_680b, 0x7)) goto l_0x1017_680b; /* jnz 0x1017680b */
            ii(0x1017_6804, 5); mov(eax, 0x33);                         /* mov eax, 0x33 */
            ii(0x1017_6809, 2); jmp(0x1017_6818, 0xd); goto l_0x1017_6818; /* jmp 0x10176818 */
        l_0x1017_680b:
            ii(0x1017_680b, 3); cmp(edx, 0x4);                          /* cmp edx, 0x4 */
            ii(0x1017_680e, 2); if(jz(0x1017_6813, 0x3)) goto l_0x1017_6813; /* jz 0x10176813 */
            ii(0x1017_6810, 3); cmp(edx, 0x3);                          /* cmp edx, 0x3 */
        l_0x1017_6813:
            ii(0x1017_6813, 5); mov(eax, 0x34);                         /* mov eax, 0x34 */
        l_0x1017_6818:
            ii(0x1017_6818, 2); mov(edx, eax);                          /* mov edx, eax */
        l_0x1017_681a:
            ii(0x1017_681a, 7); lea(eax, edx * 4 + 0);                  /* lea eax, [edx*4] */
            ii(0x1017_6821, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_6823, 5); mov(ecx, 0xffff_ffff);                  /* mov ecx, 0xffffffff */
            ii(0x1017_6828, 6); mov(edi, memd[ds, 0x1020_9540]);        /* mov edi, [0x10209540] */
            ii(0x1017_682e, 8); mov(memw[ds, eax * 2 + 0x1020_8a44], cx); /* mov [eax*2+0x10208a44], cx */
            ii(0x1017_6836, 2); test(edi, edi);                         /* test edi, edi */
            ii(0x1017_6838, 2); if(jnz(0x1017_6841, 0x7)) goto l_0x1017_6841; /* jnz 0x10176841 */
            ii(0x1017_683a, 5); mov(edx, 0x34);                         /* mov edx, 0x34 */
            ii(0x1017_683f, 2); jmp(0x1017_685c, 0x1b); goto l_0x1017_685c; /* jmp 0x1017685c */
        l_0x1017_6841:
            ii(0x1017_6841, 3); cmp(edi, 0x1);                          /* cmp edi, 0x1 */
            ii(0x1017_6844, 2); if(jnz(0x1017_684d, 0x7)) goto l_0x1017_684d; /* jnz 0x1017684d */
            ii(0x1017_6846, 5); mov(eax, 0x33);                         /* mov eax, 0x33 */
            ii(0x1017_684b, 2); jmp(0x1017_685a, 0xd); goto l_0x1017_685a; /* jmp 0x1017685a */
        l_0x1017_684d:
            ii(0x1017_684d, 3); cmp(edi, 0x4);                          /* cmp edi, 0x4 */
            ii(0x1017_6850, 2); if(jz(0x1017_6855, 0x3)) goto l_0x1017_6855; /* jz 0x10176855 */
            ii(0x1017_6852, 3); cmp(edi, 0x3);                          /* cmp edi, 0x3 */
        l_0x1017_6855:
            ii(0x1017_6855, 5); mov(eax, 0x34);                         /* mov eax, 0x34 */
        l_0x1017_685a:
            ii(0x1017_685a, 2); mov(edx, eax);                          /* mov edx, eax */
        l_0x1017_685c:
            ii(0x1017_685c, 7); lea(eax, edx * 4 + 0);                  /* lea eax, [edx*4] */
            ii(0x1017_6863, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_6865, 5); mov(esi, 0xffff_ffff);                  /* mov esi, 0xffffffff */
            ii(0x1017_686a, 6); mov(ebx, memd[ds, 0x1020_9540]);        /* mov ebx, [0x10209540] */
            ii(0x1017_6870, 8); mov(memw[ds, eax * 2 + 0x1020_8a46], si); /* mov [eax*2+0x10208a46], si */
            ii(0x1017_6878, 2); test(ebx, ebx);                         /* test ebx, ebx */
            ii(0x1017_687a, 2); if(jnz(0x1017_6883, 0x7)) goto l_0x1017_6883; /* jnz 0x10176883 */
            ii(0x1017_687c, 5); mov(edx, 0x34);                         /* mov edx, 0x34 */
            ii(0x1017_6881, 2); jmp(0x1017_689e, 0x1b); goto l_0x1017_689e; /* jmp 0x1017689e */
        l_0x1017_6883:
            ii(0x1017_6883, 3); cmp(ebx, 0x1);                          /* cmp ebx, 0x1 */
            ii(0x1017_6886, 2); if(jnz(0x1017_688f, 0x7)) goto l_0x1017_688f; /* jnz 0x1017688f */
            ii(0x1017_6888, 5); mov(eax, 0x33);                         /* mov eax, 0x33 */
            ii(0x1017_688d, 2); jmp(0x1017_689c, 0xd); goto l_0x1017_689c; /* jmp 0x1017689c */
        l_0x1017_688f:
            ii(0x1017_688f, 3); cmp(ebx, 0x4);                          /* cmp ebx, 0x4 */
            ii(0x1017_6892, 2); if(jz(0x1017_6897, 0x3)) goto l_0x1017_6897; /* jz 0x10176897 */
            ii(0x1017_6894, 3); cmp(ebx, 0x3);                          /* cmp ebx, 0x3 */
        l_0x1017_6897:
            ii(0x1017_6897, 5); mov(eax, 0x34);                         /* mov eax, 0x34 */
        l_0x1017_689c:
            ii(0x1017_689c, 2); mov(edx, eax);                          /* mov edx, eax */
        l_0x1017_689e:
            ii(0x1017_689e, 7); lea(eax, edx * 4 + 0);                  /* lea eax, [edx*4] */
            ii(0x1017_68a5, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_68a7, 5); mov(edi, 0xffff_ffff);                  /* mov edi, 0xffffffff */
            ii(0x1017_68ac, 6); mov(ebp, memd[ds, 0x1020_9540]);        /* mov ebp, [0x10209540] */
            ii(0x1017_68b2, 8); mov(memw[ds, eax * 2 + 0x1020_8a48], di); /* mov [eax*2+0x10208a48], di */
            ii(0x1017_68ba, 2); test(ebp, ebp);                         /* test ebp, ebp */
            ii(0x1017_68bc, 2); if(jnz(0x1017_68c5, 0x7)) goto l_0x1017_68c5; /* jnz 0x101768c5 */
            ii(0x1017_68be, 5); mov(edx, 0x35);                         /* mov edx, 0x35 */
            ii(0x1017_68c3, 2); jmp(0x1017_68e0, 0x1b); goto l_0x1017_68e0; /* jmp 0x101768e0 */
        l_0x1017_68c5:
            ii(0x1017_68c5, 3); cmp(ebp, 0x1);                          /* cmp ebp, 0x1 */
            ii(0x1017_68c8, 2); if(jnz(0x1017_68d1, 0x7)) goto l_0x1017_68d1; /* jnz 0x101768d1 */
            ii(0x1017_68ca, 5); mov(eax, 0x34);                         /* mov eax, 0x34 */
            ii(0x1017_68cf, 2); jmp(0x1017_68de, 0xd); goto l_0x1017_68de; /* jmp 0x101768de */
        l_0x1017_68d1:
            ii(0x1017_68d1, 3); cmp(ebp, 0x4);                          /* cmp ebp, 0x4 */
            ii(0x1017_68d4, 2); if(jz(0x1017_68d9, 0x3)) goto l_0x1017_68d9; /* jz 0x101768d9 */
            ii(0x1017_68d6, 3); cmp(ebp, 0x3);                          /* cmp ebp, 0x3 */
        l_0x1017_68d9:
            ii(0x1017_68d9, 5); mov(eax, 0x8);                          /* mov eax, 0x8 */
        l_0x1017_68de:
            ii(0x1017_68de, 2); mov(edx, eax);                          /* mov edx, eax */
        l_0x1017_68e0:
            ii(0x1017_68e0, 7); lea(eax, edx * 4 + 0);                  /* lea eax, [edx*4] */
            ii(0x1017_68e7, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_68e9, 5); mov(edx, 0x2f);                         /* mov edx, 0x2f */
            ii(0x1017_68ee, 6); mov(ecx, memd[ds, 0x1020_9540]);        /* mov ecx, [0x10209540] */
            ii(0x1017_68f4, 8); mov(memw[ds, eax * 2 + 0x1020_8a40], dx); /* mov [eax*2+0x10208a40], dx */
            ii(0x1017_68fc, 2); test(ecx, ecx);                         /* test ecx, ecx */
            ii(0x1017_68fe, 2); if(jnz(0x1017_6907, 0x7)) goto l_0x1017_6907; /* jnz 0x10176907 */
            ii(0x1017_6900, 5); mov(eax, 0x35);                         /* mov eax, 0x35 */
            ii(0x1017_6905, 2); jmp(0x1017_6920, 0x19); goto l_0x1017_6920; /* jmp 0x10176920 */
        l_0x1017_6907:
            ii(0x1017_6907, 3); cmp(ecx, 0x1);                          /* cmp ecx, 0x1 */
            ii(0x1017_690a, 2); if(jnz(0x1017_6913, 0x7)) goto l_0x1017_6913; /* jnz 0x10176913 */
            ii(0x1017_690c, 5); mov(eax, 0x34);                         /* mov eax, 0x34 */
            ii(0x1017_6911, 2); jmp(0x1017_6920, 0xd); goto l_0x1017_6920; /* jmp 0x10176920 */
        l_0x1017_6913:
            ii(0x1017_6913, 3); cmp(ecx, 0x4);                          /* cmp ecx, 0x4 */
            ii(0x1017_6916, 2); if(jz(0x1017_691b, 0x3)) goto l_0x1017_691b; /* jz 0x1017691b */
            ii(0x1017_6918, 3); cmp(ecx, 0x3);                          /* cmp ecx, 0x3 */
        l_0x1017_691b:
            ii(0x1017_691b, 5); mov(eax, 0x8);                          /* mov eax, 0x8 */
        l_0x1017_6920:
            ii(0x1017_6920, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1017_6922, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1017_6925, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_6927, 10); mov(memw[ds, eax * 2 + 0x1020_8a42], 0x3f); /* mov word [eax*2+0x10208a42], 0x3f */
            ii(0x1017_6931, 5); mov(eax, memd[ds, 0x1020_9540]);        /* mov eax, [0x10209540] */
            ii(0x1017_6936, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_6938, 2); if(jnz(0x1017_6941, 0x7)) goto l_0x1017_6941; /* jnz 0x10176941 */
            ii(0x1017_693a, 5); mov(eax, 0x35);                         /* mov eax, 0x35 */
            ii(0x1017_693f, 2); jmp(0x1017_695a, 0x19); goto l_0x1017_695a; /* jmp 0x1017695a */
        l_0x1017_6941:
            ii(0x1017_6941, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1017_6944, 2); if(jnz(0x1017_694d, 0x7)) goto l_0x1017_694d; /* jnz 0x1017694d */
            ii(0x1017_6946, 5); mov(eax, 0x34);                         /* mov eax, 0x34 */
            ii(0x1017_694b, 2); jmp(0x1017_695a, 0xd); goto l_0x1017_695a; /* jmp 0x1017695a */
        l_0x1017_694d:
            ii(0x1017_694d, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x1017_6950, 2); if(jz(0x1017_6955, 0x3)) goto l_0x1017_6955; /* jz 0x10176955 */
            ii(0x1017_6952, 3); cmp(eax, 0x3);                          /* cmp eax, 0x3 */
        l_0x1017_6955:
            ii(0x1017_6955, 5); mov(eax, 0x8);                          /* mov eax, 0x8 */
        l_0x1017_695a:
            ii(0x1017_695a, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1017_695c, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1017_695f, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_6961, 5); mov(ecx, 0xffff_ffff);                  /* mov ecx, 0xffffffff */
            ii(0x1017_6966, 6); mov(esi, memd[ds, 0x1020_9540]);        /* mov esi, [0x10209540] */
            ii(0x1017_696c, 8); mov(memw[ds, eax * 2 + 0x1020_8a44], cx); /* mov [eax*2+0x10208a44], cx */
            ii(0x1017_6974, 2); test(esi, esi);                         /* test esi, esi */
            ii(0x1017_6976, 2); if(jnz(0x1017_697f, 0x7)) goto l_0x1017_697f; /* jnz 0x1017697f */
            ii(0x1017_6978, 5); mov(eax, 0x35);                         /* mov eax, 0x35 */
            ii(0x1017_697d, 2); jmp(0x1017_6998, 0x19); goto l_0x1017_6998; /* jmp 0x10176998 */
        l_0x1017_697f:
            ii(0x1017_697f, 3); cmp(esi, 0x1);                          /* cmp esi, 0x1 */
            ii(0x1017_6982, 2); if(jnz(0x1017_698b, 0x7)) goto l_0x1017_698b; /* jnz 0x1017698b */
            ii(0x1017_6984, 5); mov(eax, 0x34);                         /* mov eax, 0x34 */
            ii(0x1017_6989, 2); jmp(0x1017_6998, 0xd); goto l_0x1017_6998; /* jmp 0x10176998 */
        l_0x1017_698b:
            ii(0x1017_698b, 3); cmp(esi, 0x4);                          /* cmp esi, 0x4 */
            ii(0x1017_698e, 2); if(jz(0x1017_6993, 0x3)) goto l_0x1017_6993; /* jz 0x10176993 */
            ii(0x1017_6990, 3); cmp(esi, 0x3);                          /* cmp esi, 0x3 */
        l_0x1017_6993:
            ii(0x1017_6993, 5); mov(eax, 0x8);                          /* mov eax, 0x8 */
        l_0x1017_6998:
            ii(0x1017_6998, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1017_699a, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1017_699d, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_699f, 5); mov(esi, 0xffff_ffff);                  /* mov esi, 0xffffffff */
            ii(0x1017_69a4, 6); mov(edx, memd[ds, 0x1020_9540]);        /* mov edx, [0x10209540] */
            ii(0x1017_69aa, 8); mov(memw[ds, eax * 2 + 0x1020_8a46], si); /* mov [eax*2+0x10208a46], si */
            ii(0x1017_69b2, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1017_69b4, 2); if(jnz(0x1017_69bd, 0x7)) goto l_0x1017_69bd; /* jnz 0x101769bd */
            ii(0x1017_69b6, 5); mov(eax, 0x35);                         /* mov eax, 0x35 */
            ii(0x1017_69bb, 2); jmp(0x1017_69d6, 0x19); goto l_0x1017_69d6; /* jmp 0x101769d6 */
        l_0x1017_69bd:
            ii(0x1017_69bd, 3); cmp(edx, 0x1);                          /* cmp edx, 0x1 */
            ii(0x1017_69c0, 2); if(jnz(0x1017_69c9, 0x7)) goto l_0x1017_69c9; /* jnz 0x101769c9 */
            ii(0x1017_69c2, 5); mov(eax, 0x34);                         /* mov eax, 0x34 */
            ii(0x1017_69c7, 2); jmp(0x1017_69d6, 0xd); goto l_0x1017_69d6; /* jmp 0x101769d6 */
        l_0x1017_69c9:
            ii(0x1017_69c9, 3); cmp(edx, 0x4);                          /* cmp edx, 0x4 */
            ii(0x1017_69cc, 2); if(jz(0x1017_69d1, 0x3)) goto l_0x1017_69d1; /* jz 0x101769d1 */
            ii(0x1017_69ce, 3); cmp(edx, 0x3);                          /* cmp edx, 0x3 */
        l_0x1017_69d1:
            ii(0x1017_69d1, 5); mov(eax, 0x8);                          /* mov eax, 0x8 */
        l_0x1017_69d6:
            ii(0x1017_69d6, 5); mov(edi, 0xffff_ffff);                  /* mov edi, 0xffffffff */
            ii(0x1017_69db, 5); mov(ecx, 0x20);                         /* mov ecx, 0x20 */
            ii(0x1017_69e0, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1017_69e2, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1017_69e5, 5); mov(ebx, 0x1a2);                        /* mov ebx, 0x1a2 */
            ii(0x1017_69ea, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_69ec, 5); mov(esi, 0x192);                        /* mov esi, 0x192 */
            ii(0x1017_69f1, 5); mov(edx, 0x197);                        /* mov edx, 0x197 */
            ii(0x1017_69f6, 8); mov(memw[ds, eax * 2 + 0x1020_8a48], di); /* mov [eax*2+0x10208a48], di */
            ii(0x1017_69fe, 5); mov(eax, 0x152);                        /* mov eax, 0x152 */
            ii(0x1017_6a03, 7); mov(memw[ds, 0x1020_8c5c], di);         /* mov [0x10208c5c], di */
            ii(0x1017_6a0a, 7); mov(memw[ds, 0x1020_8c5e], di);         /* mov [0x10208c5e], di */
            ii(0x1017_6a11, 7); mov(memw[ds, 0x1020_8c60], di);         /* mov [0x10208c60], di */
            ii(0x1017_6a18, 7); mov(memw[ds, 0x1020_8c62], di);         /* mov [0x10208c62], di */
            ii(0x1017_6a1f, 7); mov(memw[ds, 0x1020_8c64], di);         /* mov [0x10208c64], di */
            ii(0x1017_6a26, 7); mov(memw[ds, 0x1020_8b62], di);         /* mov [0x10208b62], di */
            ii(0x1017_6a2d, 7); mov(memw[ds, 0x1020_8b64], di);         /* mov [0x10208b64], di */
            ii(0x1017_6a34, 7); mov(memw[ds, 0x1020_8b66], di);         /* mov [0x10208b66], di */
            ii(0x1017_6a3b, 7); mov(memw[ds, 0x1020_8b68], di);         /* mov [0x10208b68], di */
            ii(0x1017_6a42, 7); mov(memw[ds, 0x1020_8b6a], di);         /* mov [0x10208b6a], di */
            ii(0x1017_6a49, 7); mov(memw[ds, 0x1020_8c70], di);         /* mov [0x10208c70], di */
            ii(0x1017_6a50, 7); mov(memw[ds, 0x1020_8c72], di);         /* mov [0x10208c72], di */
            ii(0x1017_6a57, 7); mov(memw[ds, 0x1020_8c74], di);         /* mov [0x10208c74], di */
            ii(0x1017_6a5e, 7); mov(memw[ds, 0x1020_8c76], di);         /* mov [0x10208c76], di */
            ii(0x1017_6a65, 7); mov(memw[ds, 0x1020_8c78], di);         /* mov [0x10208c78], di */
            ii(0x1017_6a6c, 7); mov(memw[ds, 0x1020_8c7a], cx);         /* mov [0x10208c7a], cx */
            ii(0x1017_6a73, 7); mov(memw[ds, 0x1020_8c7c], cx);         /* mov [0x10208c7c], cx */
            ii(0x1017_6a7a, 7); mov(memw[ds, 0x1020_8c7e], cx);         /* mov [0x10208c7e], cx */
            ii(0x1017_6a81, 7); mov(memw[ds, 0x1020_8c80], cx);         /* mov [0x10208c80], cx */
            ii(0x1017_6a88, 7); mov(memw[ds, 0x1020_8c82], cx);         /* mov [0x10208c82], cx */
            ii(0x1017_6a8f, 7); mov(memw[ds, 0x1020_9170], di);         /* mov [0x10209170], di */
            ii(0x1017_6a96, 7); mov(memw[ds, 0x1020_9172], di);         /* mov [0x10209172], di */
            ii(0x1017_6a9d, 7); mov(memw[ds, 0x1020_9174], di);         /* mov [0x10209174], di */
            ii(0x1017_6aa4, 7); mov(memw[ds, 0x1020_9176], di);         /* mov [0x10209176], di */
            ii(0x1017_6aab, 7); mov(memw[ds, 0x1020_9178], di);         /* mov [0x10209178], di */
            ii(0x1017_6ab2, 7); mov(memw[ds, 0x1020_9062], di);         /* mov [0x10209062], di */
            ii(0x1017_6ab9, 7); mov(memw[ds, 0x1020_9064], di);         /* mov [0x10209064], di */
            ii(0x1017_6ac0, 7); mov(memw[ds, 0x1020_9066], di);         /* mov [0x10209066], di */
            ii(0x1017_6ac7, 7); mov(memw[ds, 0x1020_9068], di);         /* mov [0x10209068], di */
            ii(0x1017_6ace, 7); mov(memw[ds, 0x1020_906a], di);         /* mov [0x1020906a], di */
            ii(0x1017_6ad5, 7); mov(memw[ds, 0x1020_9278], bx);         /* mov [0x10209278], bx */
            ii(0x1017_6adc, 7); mov(memw[ds, 0x1020_927a], bx);         /* mov [0x1020927a], bx */
            ii(0x1017_6ae3, 7); mov(memw[ds, 0x1020_927c], si);         /* mov [0x1020927c], si */
            ii(0x1017_6aea, 7); mov(memw[ds, 0x1020_920a], dx);         /* mov [0x1020920a], dx */
            ii(0x1017_6af1, 7); mov(memw[ds, 0x1020_920c], dx);         /* mov [0x1020920c], dx */
            ii(0x1017_6af8, 5); mov(edi, 0x147);                        /* mov edi, 0x147 */
            ii(0x1017_6afd, 5); mov(ecx, 0x177);                        /* mov ecx, 0x177 */
            ii(0x1017_6b02, 5); mov(esi, 0x149);                        /* mov esi, 0x149 */
            ii(0x1017_6b07, 5); mov(ebx, 0x184);                        /* mov ebx, 0x184 */
            ii(0x1017_6b0c, 5); mov(edx, 0x193);                        /* mov edx, 0x193 */
            ii(0x1017_6b11, 6); mov(memw[ds, 0x1020_9274], ax);         /* mov [0x10209274], ax */
            ii(0x1017_6b17, 6); mov(memw[ds, 0x1020_9276], ax);         /* mov [0x10209276], ax */
            ii(0x1017_6b1d, 5); mov(eax, 0x199);                        /* mov eax, 0x199 */
            ii(0x1017_6b22, 7); mov(memw[ds, 0x1020_9206], di);         /* mov [0x10209206], di */
            ii(0x1017_6b29, 7); mov(memw[ds, 0x1020_9208], di);         /* mov [0x10209208], di */
            ii(0x1017_6b30, 7); mov(memw[ds, 0x1020_920e], cx);         /* mov [0x1020920e], cx */
            ii(0x1017_6b37, 7); mov(memw[ds, 0x1020_921a], si);         /* mov [0x1020921a], si */
            ii(0x1017_6b3e, 7); mov(memw[ds, 0x1020_921c], si);         /* mov [0x1020921c], si */
            ii(0x1017_6b45, 7); mov(memw[ds, 0x1020_9222], bx);         /* mov [0x10209222], bx */
            ii(0x1017_6b4c, 7); mov(memw[ds, 0x1020_9286], dx);         /* mov [0x10209286], dx */
            ii(0x1017_6b53, 5); mov(ecx, 0x153);                        /* mov ecx, 0x153 */
            ii(0x1017_6b58, 5); mov(edi, 0x1a3);                        /* mov edi, 0x1a3 */
            ii(0x1017_6b5d, 5); mov(ebx, 0x14f);                        /* mov ebx, 0x14f */
            ii(0x1017_6b62, 5); mov(esi, 0x19f);                        /* mov esi, 0x19f */
            ii(0x1017_6b67, 5); mov(edx, 0x151);                        /* mov edx, 0x151 */
            ii(0x1017_6b6c, 6); mov(memw[ds, 0x1020_921e], ax);         /* mov [0x1020921e], ax */
            ii(0x1017_6b72, 6); mov(memw[ds, 0x1020_9220], ax);         /* mov [0x10209220], ax */
            ii(0x1017_6b78, 5); mov(eax, 0x175);                        /* mov eax, 0x175 */
            ii(0x1017_6b7d, 7); mov(memw[ds, 0x1020_927e], cx);         /* mov [0x1020927e], cx */
            ii(0x1017_6b84, 7); mov(memw[ds, 0x1020_9280], cx);         /* mov [0x10209280], cx */
            ii(0x1017_6b8b, 7); mov(memw[ds, 0x1020_9282], di);         /* mov [0x10209282], di */
            ii(0x1017_6b92, 7); mov(memw[ds, 0x1020_9284], di);         /* mov [0x10209284], di */
            ii(0x1017_6b99, 7); mov(memw[ds, 0x1020_9256], bx);         /* mov [0x10209256], bx */
            ii(0x1017_6ba0, 7); mov(memw[ds, 0x1020_9258], bx);         /* mov [0x10209258], bx */
            ii(0x1017_6ba7, 7); mov(memw[ds, 0x1020_925a], si);         /* mov [0x1020925a], si */
            ii(0x1017_6bae, 7); mov(memw[ds, 0x1020_925c], si);         /* mov [0x1020925c], si */
            ii(0x1017_6bb5, 7); mov(memw[ds, 0x1020_926a], dx);         /* mov [0x1020926a], dx */
            ii(0x1017_6bbc, 7); mov(memw[ds, 0x1020_926c], dx);         /* mov [0x1020926c], dx */
            ii(0x1017_6bc3, 5); mov(ecx, 0x1a1);                        /* mov ecx, 0x1a1 */
            ii(0x1017_6bc8, 5); mov(edi, 0x176);                        /* mov edi, 0x176 */
            ii(0x1017_6bcd, 5); mov(ebx, 0x198);                        /* mov ebx, 0x198 */
            ii(0x1017_6bd2, 5); mov(esi, 0x18d);                        /* mov esi, 0x18d */
            ii(0x1017_6bd7, 5); mov(edx, 0x1a0);                        /* mov edx, 0x1a0 */
            ii(0x1017_6bdc, 6); mov(memw[ds, 0x1020_925e], ax);         /* mov [0x1020925e], ax */
            ii(0x1017_6be2, 5); mov(eax, 0x148);                        /* mov eax, 0x148 */
            ii(0x1017_6be7, 7); mov(memw[ds, 0x1020_926e], cx);         /* mov [0x1020926e], cx */
            ii(0x1017_6bee, 7); mov(memw[ds, 0x1020_9270], cx);         /* mov [0x10209270], cx */
            ii(0x1017_6bf5, 7); mov(memw[ds, 0x1020_9272], di);         /* mov [0x10209272], di */
            ii(0x1017_6bfc, 7); mov(memw[ds, 0x1020_9214], bx);         /* mov [0x10209214], bx */
            ii(0x1017_6c03, 7); mov(memw[ds, 0x1020_9216], bx);         /* mov [0x10209216], bx */
            ii(0x1017_6c0a, 7); mov(memw[ds, 0x1020_9218], si);         /* mov [0x10209218], si */
            ii(0x1017_6c11, 7); mov(memw[ds, 0x1020_9264], dx);         /* mov [0x10209264], dx */
            ii(0x1017_6c18, 7); mov(memw[ds, 0x1020_9266], dx);         /* mov [0x10209266], dx */
            ii(0x1017_6c1f, 5); mov(edi, 0x150);                        /* mov edi, 0x150 */
            ii(0x1017_6c24, 5); mov(ecx, 0x191);                        /* mov ecx, 0x191 */
            ii(0x1017_6c29, 5); mov(esi, 0x14b);                        /* mov esi, 0x14b */
            ii(0x1017_6c2e, 6); mov(memw[ds, 0x1020_9210], ax);         /* mov [0x10209210], ax */
            ii(0x1017_6c34, 6); mov(memw[ds, 0x1020_9212], ax);         /* mov [0x10209212], ax */
            ii(0x1017_6c3a, 5); mov(eax, 0x19b);                        /* mov eax, 0x19b */
            ii(0x1017_6c3f, 7); mov(memw[ds, 0x1020_9260], di);         /* mov [0x10209260], di */
            ii(0x1017_6c46, 7); mov(memw[ds, 0x1020_9262], di);         /* mov [0x10209262], di */
            ii(0x1017_6c4d, 7); mov(memw[ds, 0x1020_9268], cx);         /* mov [0x10209268], cx */
            ii(0x1017_6c54, 7); mov(memw[ds, 0x1020_922e], si);         /* mov [0x1020922e], si */
            ii(0x1017_6c5b, 7); mov(memw[ds, 0x1020_9230], si);         /* mov [0x10209230], si */
            ii(0x1017_6c62, 6); mov(memw[ds, 0x1020_9232], ax);         /* mov [0x10209232], ax */
            ii(0x1017_6c68, 5); mov(ebx, 0x173);                        /* mov ebx, 0x173 */
            ii(0x1017_6c6d, 5); mov(ecx, 0x14d);                        /* mov ecx, 0x14d */
            ii(0x1017_6c72, 5); mov(edi, 0x19d);                        /* mov edi, 0x19d */
            ii(0x1017_6c77, 5); mov(edx, 0x174);                        /* mov edx, 0x174 */
            ii(0x1017_6c7c, 5); mov(esi, 0x147);                        /* mov esi, 0x147 */
            ii(0x1017_6c81, 6); mov(memw[ds, 0x1020_9234], ax);         /* mov [0x10209234], ax */
            ii(0x1017_6c87, 5); mov(eax, 0x2a);                         /* mov eax, 0x2a */
            ii(0x1017_6c8c, 7); mov(memw[ds, 0x1020_9236], bx);         /* mov [0x10209236], bx */
            ii(0x1017_6c93, 7); mov(memw[ds, 0x1020_9242], cx);         /* mov [0x10209242], cx */
            ii(0x1017_6c9a, 7); mov(memw[ds, 0x1020_9244], cx);         /* mov [0x10209244], cx */
            ii(0x1017_6ca1, 7); mov(memw[ds, 0x1020_9246], di);         /* mov [0x10209246], di */
            ii(0x1017_6ca8, 7); mov(memw[ds, 0x1020_9248], di);         /* mov [0x10209248], di */
            ii(0x1017_6caf, 7); mov(memw[ds, 0x1020_924a], dx);         /* mov [0x1020924a], dx */
            ii(0x1017_6cb6, 7); mov(memw[ds, 0x1020_8d06], si);         /* mov [0x10208d06], si */
            ii(0x1017_6cbd, 5); mov(ebx, 0xffff_ffff);                  /* mov ebx, 0xffffffff */
            ii(0x1017_6cc2, 5); mov(edx, 0x2f);                         /* mov edx, 0x2f */
            ii(0x1017_6cc7, 5); mov(edi, 0x3);                          /* mov edi, 0x3 */
            ii(0x1017_6ccc, 5); mov(ecx, 0x148);                        /* mov ecx, 0x148 */
            ii(0x1017_6cd1, 5); mov(esi, 0x38);                         /* mov esi, 0x38 */
            ii(0x1017_6cd6, 6); mov(memw[ds, 0x1020_8c66], ax);         /* mov [0x10208c66], ax */
            ii(0x1017_6cdc, 6); mov(memw[ds, 0x1020_8c68], ax);         /* mov [0x10208c68], ax */
            ii(0x1017_6ce2, 5); mov(eax, 0x197);                        /* mov eax, 0x197 */
            ii(0x1017_6ce7, 7); mov(memw[ds, 0x1020_8cf2], bx);         /* mov [0x10208cf2], bx */
            ii(0x1017_6cee, 7); mov(memw[ds, 0x1020_8cf4], bx);         /* mov [0x10208cf4], bx */
            ii(0x1017_6cf5, 7); mov(memw[ds, 0x1020_8cf6], bx);         /* mov [0x10208cf6], bx */
            ii(0x1017_6cfc, 7); mov(memw[ds, 0x1020_8cf8], bx);         /* mov [0x10208cf8], bx */
            ii(0x1017_6d03, 7); mov(memw[ds, 0x1020_8cfa], bx);         /* mov [0x10208cfa], bx */
            ii(0x1017_6d0a, 7); mov(memw[ds, 0x1020_9152], dx);         /* mov [0x10209152], dx */
            ii(0x1017_6d11, 7); mov(memw[ds, 0x1020_9154], dx);         /* mov [0x10209154], dx */
            ii(0x1017_6d18, 7); mov(memw[ds, 0x1020_9156], bx);         /* mov [0x10209156], bx */
            ii(0x1017_6d1f, 7); mov(memw[ds, 0x1020_9158], bx);         /* mov [0x10209158], bx */
            ii(0x1017_6d26, 7); mov(memw[ds, 0x1020_915a], di);         /* mov [0x1020915a], di */
            ii(0x1017_6d2d, 7); mov(memw[ds, 0x1020_8c6a], bx);         /* mov [0x10208c6a], bx */
            ii(0x1017_6d34, 7); mov(memw[ds, 0x1020_8c6c], bx);         /* mov [0x10208c6c], bx */
            ii(0x1017_6d3b, 7); mov(memw[ds, 0x1020_8c6e], bx);         /* mov [0x10208c6e], bx */
            ii(0x1017_6d42, 7); mov(memw[ds, 0x1020_8d28], bx);         /* mov [0x10208d28], bx */
            ii(0x1017_6d49, 7); mov(memw[ds, 0x1020_8d2a], bx);         /* mov [0x10208d2a], bx */
            ii(0x1017_6d50, 7); mov(memw[ds, 0x1020_8d2c], bx);         /* mov [0x10208d2c], bx */
            ii(0x1017_6d57, 7); mov(memw[ds, 0x1020_8d10], cx);         /* mov [0x10208d10], cx */
            ii(0x1017_6d5e, 7); mov(memw[ds, 0x1020_8d12], si);         /* mov [0x10208d12], si */
            ii(0x1017_6d65, 5); mov(edi, 0x2d);                         /* mov edi, 0x2d */
            ii(0x1017_6d6a, 5); mov(ebx, 0x177);                        /* mov ebx, 0x177 */
            ii(0x1017_6d6f, 5); mov(edx, 0x18d);                        /* mov edx, 0x18d */
            ii(0x1017_6d74, 5); mov(ecx, 0x39);                         /* mov ecx, 0x39 */
            ii(0x1017_6d79, 5); mov(esi, 0x199);                        /* mov esi, 0x199 */
            ii(0x1017_6d7e, 6); mov(memw[ds, 0x1020_8d0a], ax);         /* mov [0x10208d0a], ax */
            ii(0x1017_6d84, 6); mov(memw[ds, 0x1020_8d0c], ax);         /* mov [0x10208d0c], ax */
            ii(0x1017_6d8a, 5); mov(eax, 0x184);                        /* mov eax, 0x184 */
            ii(0x1017_6d8f, 7); mov(memw[ds, 0x1020_8d24], di);         /* mov [0x10208d24], di */
            ii(0x1017_6d96, 7); mov(memw[ds, 0x1020_8d26], di);         /* mov [0x10208d26], di */
            ii(0x1017_6d9d, 7); mov(memw[ds, 0x1020_8d0e], bx);         /* mov [0x10208d0e], bx */
            ii(0x1017_6da4, 7); mov(memw[ds, 0x1020_8d18], dx);         /* mov [0x10208d18], dx */
            ii(0x1017_6dab, 7); mov(memw[ds, 0x1020_8d1c], cx);         /* mov [0x10208d1c], cx */
            ii(0x1017_6db2, 7); mov(memw[ds, 0x1020_8d1e], si);         /* mov [0x10208d1e], si */
            ii(0x1017_6db9, 7); mov(memw[ds, 0x1020_8d20], si);         /* mov [0x10208d20], si */
            ii(0x1017_6dc0, 5); mov(edi, 0x37);                         /* mov edi, 0x37 */
            ii(0x1017_6dc5, 5); mov(ebx, 0x149);                        /* mov ebx, 0x149 */
            ii(0x1017_6dca, 5); mov(edx, 0x2b);                         /* mov edx, 0x2b */
            ii(0x1017_6dcf, 5); mov(ecx, 0xffff_ffff);                  /* mov ecx, 0xffffffff */
            ii(0x1017_6dd4, 5); mov(esi, 0x173);                        /* mov esi, 0x173 */
            ii(0x1017_6dd9, 6); mov(memw[ds, 0x1020_8d22], ax);         /* mov [0x10208d22], ax */
            ii(0x1017_6ddf, 5); mov(eax, 0x14b);                        /* mov eax, 0x14b */
            ii(0x1017_6de4, 7); mov(memw[ds, 0x1020_8d08], di);         /* mov [0x10208d08], di */
            ii(0x1017_6deb, 7); mov(memw[ds, 0x1020_8d1a], bx);         /* mov [0x10208d1a], bx */
            ii(0x1017_6df2, 7); mov(memw[ds, 0x1020_8d4c], dx);         /* mov [0x10208d4c], dx */
            ii(0x1017_6df9, 7); mov(memw[ds, 0x1020_8d4e], dx);         /* mov [0x10208d4e], dx */
            ii(0x1017_6e00, 7); mov(memw[ds, 0x1020_8d50], cx);         /* mov [0x10208d50], cx */
            ii(0x1017_6e07, 7); mov(memw[ds, 0x1020_8d52], cx);         /* mov [0x10208d52], cx */
            ii(0x1017_6e0e, 7); mov(memw[ds, 0x1020_8d54], cx);         /* mov [0x10208d54], cx */
            ii(0x1017_6e15, 7); mov(memw[ds, 0x1020_8d36], si);         /* mov [0x10208d36], si */
            ii(0x1017_6e1c, 5); mov(edi, 0x198);                        /* mov edi, 0x198 */
            ii(0x1017_6e21, 5); mov(edx, 0x34);                         /* mov edx, 0x34 */
            ii(0x1017_6e26, 5); mov(ebx, 0x19b);                        /* mov ebx, 0x19b */
            ii(0x1017_6e2b, 5); mov(ecx, 0x18f);                        /* mov ecx, 0x18f */
            ii(0x1017_6e30, 5); mov(esi, 0x14d);                        /* mov esi, 0x14d */
            ii(0x1017_6e35, 6); mov(memw[ds, 0x1020_8d2e], ax);         /* mov [0x10208d2e], ax */
            ii(0x1017_6e3b, 5); mov(eax, 0x35);                         /* mov eax, 0x35 */
            ii(0x1017_6e40, 7); mov(memw[ds, 0x1020_8d14], di);         /* mov [0x10208d14], di */
            ii(0x1017_6e47, 7); mov(memw[ds, 0x1020_8d16], di);         /* mov [0x10208d16], di */
            ii(0x1017_6e4e, 7); mov(memw[ds, 0x1020_8d30], dx);         /* mov [0x10208d30], dx */
            ii(0x1017_6e55, 7); mov(memw[ds, 0x1020_8d32], bx);         /* mov [0x10208d32], bx */
            ii(0x1017_6e5c, 7); mov(memw[ds, 0x1020_8d34], bx);         /* mov [0x10208d34], bx */
            ii(0x1017_6e63, 7); mov(memw[ds, 0x1020_8d40], cx);         /* mov [0x10208d40], cx */
            ii(0x1017_6e6a, 7); mov(memw[ds, 0x1020_8d42], si);         /* mov [0x10208d42], si */
            ii(0x1017_6e71, 5); mov(edi, 0x14c);                        /* mov edi, 0x14c */
            ii(0x1017_6e76, 5); mov(edx, 0x270f);                       /* mov edx, 0x270f */
            ii(0x1017_6e7b, 5); mov(ebx, 0x174);                        /* mov ebx, 0x174 */
            ii(0x1017_6e80, 5); mov(ecx, 0x14f);                        /* mov ecx, 0x14f */
            ii(0x1017_6e85, 5); mov(esi, 0x31);                         /* mov esi, 0x31 */
            ii(0x1017_6e8a, 6); mov(memw[ds, 0x1020_8d3a], ax);         /* mov [0x10208d3a], ax */
            ii(0x1017_6e90, 5); mov(eax, 0x19d);                        /* mov eax, 0x19d */
            ii(0x1017_6e95, 7); mov(memw[ds, 0x1020_8d38], di);         /* mov [0x10208d38], di */
            ii(0x1017_6e9c, 7); mov(memw[ds, 0x1020_8d3c], dx);         /* mov [0x10208d3c], dx */
            ii(0x1017_6ea3, 7); mov(memw[ds, 0x1020_8d3e], dx);         /* mov [0x10208d3e], dx */
            ii(0x1017_6eaa, 7); mov(memw[ds, 0x1020_8d4a], bx);         /* mov [0x10208d4a], bx */
            ii(0x1017_6eb1, 7); mov(memw[ds, 0x1020_8d56], cx);         /* mov [0x10208d56], cx */
            ii(0x1017_6eb8, 7); mov(memw[ds, 0x1020_8d58], si);         /* mov [0x10208d58], si */
            ii(0x1017_6ebf, 5); mov(edi, 0x36);                         /* mov edi, 0x36 */
            ii(0x1017_6ec4, 5); mov(edx, 0x175);                        /* mov edx, 0x175 */
            ii(0x1017_6ec9, 5); mov(ebx, 0x150);                        /* mov ebx, 0x150 */
            ii(0x1017_6ece, 5); mov(ecx, 0x32);                         /* mov ecx, 0x32 */
            ii(0x1017_6ed3, 5); mov(esi, 0x1a0);                        /* mov esi, 0x1a0 */
            ii(0x1017_6ed8, 6); mov(memw[ds, 0x1020_8d46], ax);         /* mov [0x10208d46], ax */
            ii(0x1017_6ede, 6); mov(memw[ds, 0x1020_8d48], ax);         /* mov [0x10208d48], ax */
            ii(0x1017_6ee4, 5); mov(eax, 0x191);                        /* mov eax, 0x191 */
            ii(0x1017_6ee9, 7); mov(memw[ds, 0x1020_8d44], di);         /* mov [0x10208d44], di */
            ii(0x1017_6ef0, 7); mov(memw[ds, 0x1020_8d5e], dx);         /* mov [0x10208d5e], dx */
            ii(0x1017_6ef7, 7); mov(memw[ds, 0x1020_8d60], bx);         /* mov [0x10208d60], bx */
            ii(0x1017_6efe, 7); mov(memw[ds, 0x1020_8d62], cx);         /* mov [0x10208d62], cx */
            ii(0x1017_6f05, 7); mov(memw[ds, 0x1020_8d64], si);         /* mov [0x10208d64], si */
            ii(0x1017_6f0c, 7); mov(memw[ds, 0x1020_8d66], si);         /* mov [0x10208d66], si */
            ii(0x1017_6f13, 5); mov(edi, 0x19f);                        /* mov edi, 0x19f */
            ii(0x1017_6f18, 5); mov(edx, 0x151);                        /* mov edx, 0x151 */
            ii(0x1017_6f1d, 5); mov(ebx, 0x33);                         /* mov ebx, 0x33 */
            ii(0x1017_6f22, 5); mov(ecx, 0x1a1);                        /* mov ecx, 0x1a1 */
            ii(0x1017_6f27, 6); mov(memw[ds, 0x1020_8d68], ax);         /* mov [0x10208d68], ax */
            ii(0x1017_6f2d, 7); mov(memw[ds, 0x1020_8d5a], di);         /* mov [0x10208d5a], di */
            ii(0x1017_6f34, 7); mov(memw[ds, 0x1020_8d5c], di);         /* mov [0x10208d5c], di */
            ii(0x1017_6f3b, 7); mov(memw[ds, 0x1020_8d6a], dx);         /* mov [0x10208d6a], dx */
            ii(0x1017_6f42, 7); mov(memw[ds, 0x1020_8d6c], bx);         /* mov [0x10208d6c], bx */
            ii(0x1017_6f49, 7); mov(memw[ds, 0x1020_8d6e], cx);         /* mov [0x10208d6e], cx */
            ii(0x1017_6f50, 7); mov(memw[ds, 0x1020_8d70], cx);         /* mov [0x10208d70], cx */
            ii(0x1017_6f57, 5); mov(edi, 0x176);                        /* mov edi, 0x176 */
            ii(0x1017_6f5c, 5); mov(eax, 0xd);                          /* mov eax, 0xd */
            ii(0x1017_6f61, 5); mov(ebx, 0xffff_ffff);                  /* mov ebx, 0xffffffff */
            ii(0x1017_6f66, 5); mov(edx, 0x1a2);                        /* mov edx, 0x1a2 */
            ii(0x1017_6f6b, 5); mov(ecx, 0x192);                        /* mov ecx, 0x192 */
            ii(0x1017_6f70, 5); mov(esi, 0x153);                        /* mov esi, 0x153 */
            ii(0x1017_6f75, 7); mov(memw[ds, 0x1020_8d72], di);         /* mov [0x10208d72], di */
            ii(0x1017_6f7c, 6); mov(memw[ds, 0x1020_9058], ax);         /* mov [0x10209058], ax */
            ii(0x1017_6f82, 6); mov(memw[ds, 0x1020_905a], ax);         /* mov [0x1020905a], ax */
            ii(0x1017_6f88, 7); mov(memw[ds, 0x1020_905c], bx);         /* mov [0x1020905c], bx */
            ii(0x1017_6f8f, 7); mov(memw[ds, 0x1020_905e], bx);         /* mov [0x1020905e], bx */
            ii(0x1017_6f96, 7); mov(memw[ds, 0x1020_9060], bx);         /* mov [0x10209060], bx */
            ii(0x1017_6f9d, 7); mov(memw[ds, 0x1020_8d78], dx);         /* mov [0x10208d78], dx */
            ii(0x1017_6fa4, 7); mov(memw[ds, 0x1020_8d7a], dx);         /* mov [0x10208d7a], dx */
            ii(0x1017_6fab, 7); mov(memw[ds, 0x1020_8d7c], cx);         /* mov [0x10208d7c], cx */
            ii(0x1017_6fb2, 7); mov(memw[ds, 0x1020_8d7e], si);         /* mov [0x10208d7e], si */
            ii(0x1017_6fb9, 7); mov(memw[ds, 0x1020_8d82], bx);         /* mov [0x10208d82], bx */
            ii(0x1017_6fc0, 5); mov(edi, 0x152);                        /* mov edi, 0x152 */
            ii(0x1017_6fc5, 5); mov(eax, 0x30);                         /* mov eax, 0x30 */
            ii(0x1017_6fca, 5); mov(edx, 0x1a3);                        /* mov edx, 0x1a3 */
            ii(0x1017_6fcf, 5); mov(ebx, 0x193);                        /* mov ebx, 0x193 */
            ii(0x1017_6fd4, 7); mov(memw[ds, 0x1020_8d74], di);         /* mov [0x10208d74], di */
            ii(0x1017_6fdb, 6); mov(memw[ds, 0x1020_8d76], ax);         /* mov [0x10208d76], ax */
            ii(0x1017_6fe1, 7); mov(memw[ds, 0x1020_8d84], dx);         /* mov [0x10208d84], dx */
            ii(0x1017_6fe8, 5); mov(edi, 0x2e);                         /* mov edi, 0x2e */
            ii(0x1017_6fed, 7); mov(memw[ds, 0x1020_8d86], bx);         /* mov [0x10208d86], bx */
            ii(0x1017_6ff4, 7); mov(memw[ds, 0x1020_8d80], di);         /* mov [0x10208d80], di */
            ii(0x1017_6ffb, 1); pop(ebp);                               /* pop ebp */
            ii(0x1017_6ffc, 1); pop(edi);                               /* pop edi */
            ii(0x1017_6ffd, 1); pop(esi);                               /* pop esi */
            ii(0x1017_6ffe, 1); pop(edx);                               /* pop edx */
            ii(0x1017_6fff, 1); pop(ecx);                               /* pop ecx */
            ii(0x1017_7000, 1); pop(ebx);                               /* pop ebx */
            ii(0x1017_7001, 1); ret();                                  /* ret */
        }
    }
}
