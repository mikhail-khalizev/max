using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_d354-a0a42e91")]
        public void /* sys */ Method_1016_d354()
        {
            ii(0x1016_d354, 1); push(ebx);                              /* push ebx */
            ii(0x1016_d355, 1); push(ecx);                              /* push ecx */
            ii(0x1016_d356, 1); push(esi);                              /* push esi */
            ii(0x1016_d357, 1); push(edi);                              /* push edi */
            ii(0x1016_d358, 1); push(ebp);                              /* push ebp */
            ii(0x1016_d359, 3); sub(esp, 0x44);                         /* sub esp, 0x44 */
            ii(0x1016_d35c, 3); mov(memd[ss, esp], eax);                /* mov [esp], eax */
            ii(0x1016_d35f, 4); mov(memb[ss, esp + 64], dl);            /* mov [esp+0x40], dl */
            ii(0x1016_d363, 6); and(edx, 0xff);                         /* and edx, 0xff */
            ii(0x1016_d369, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1016_d36b, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1016_d36d, 5); call(/* sys */ 0x1016_cae8, -0x88a);    /* call 0x1016cae8 */
            ii(0x1016_d372, 4); mov(memd[ss, esp + 60], ecx);           /* mov [esp+0x3c], ecx */
            ii(0x1016_d376, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x1016_d378, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1016_d37a, 6); and(esi, 0x7c00);                       /* and esi, 0x7c00 */
            ii(0x1016_d380, 5); call(/* sys */ 0x1016_cae8, -0x89d);    /* call 0x1016cae8 */
            ii(0x1016_d385, 3); sar(esi, 0xa);                          /* sar esi, 0xa */
            ii(0x1016_d388, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1016_d38a, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1016_d38c, 6); and(ebx, 0x3e0);                        /* and ebx, 0x3e0 */
            ii(0x1016_d392, 5); call(/* sys */ 0x1016_cae8, -0x8af);    /* call 0x1016cae8 */
            ii(0x1016_d397, 3); sar(ebx, 5);                            /* sar ebx, 0x5 */
            ii(0x1016_d39a, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1016_d39c, 3); mov(eax, memd[ss, esp]);                /* mov eax, [esp] */
            ii(0x1016_d39f, 3); and(edx, 0x1f);                         /* and edx, 0x1f */
        l_0x1016_d3a2:
            ii(0x1016_d3a2, 4); mov(edi, memd[ss, esp + 60]);           /* mov edi, [esp+0x3c] */
            ii(0x1016_d3a6, 1); inc(eax);                               /* inc eax */
            ii(0x1016_d3a7, 4); mov(cl, memb[ss, esp + 60]);            /* mov cl, [esp+0x3c] */
            ii(0x1016_d3ab, 1); inc(edi);                               /* inc edi */
            ii(0x1016_d3ac, 3); mov(memb[ds, eax - 1], cl);             /* mov [eax-0x1], cl */
            ii(0x1016_d3af, 4); mov(memd[ss, esp + 60], edi);           /* mov [esp+0x3c], edi */
            ii(0x1016_d3b3, 6); cmp(edi, 0x100);                        /* cmp edi, 0x100 */
            ii(0x1016_d3b9, 2); if(jl(0x1016_d3a2, -0x19)) goto l_0x1016_d3a2; /* jl 0x1016d3a2 */
            ii(0x1016_d3bb, 3); mov(eax, memd[ss, esp]);                /* mov eax, [esp] */
            ii(0x1016_d3be, 4); mov(memd[ss, esp + 8], edx);            /* mov [esp+0x8], edx */
            ii(0x1016_d3c2, 4); mov(memd[ss, esp + 36], edx);           /* mov [esp+0x24], edx */
            ii(0x1016_d3c6, 5); add(eax, 0x100);                        /* add eax, 0x100 */
            ii(0x1016_d3cb, 4); mov(memd[ss, esp + 16], ebx);           /* mov [esp+0x10], ebx */
            ii(0x1016_d3cf, 4); mov(memd[ss, esp + 44], eax);           /* mov [esp+0x2c], eax */
            ii(0x1016_d3d3, 5); mov(eax, 6);                            /* mov eax, 0x6 */
            ii(0x1016_d3d8, 4); mov(memd[ss, esp + 24], ebx);           /* mov [esp+0x18], ebx */
            ii(0x1016_d3dc, 4); mov(memd[ss, esp + 40], eax);           /* mov [esp+0x28], eax */
            ii(0x1016_d3e0, 3); mov(eax, memd[ss, esp]);                /* mov eax, [esp] */
            ii(0x1016_d3e3, 4); mov(memd[ss, esp + 4], esi);            /* mov [esp+0x4], esi */
            ii(0x1016_d3e7, 5); add(eax, 0x800);                        /* add eax, 0x800 */
            ii(0x1016_d3ec, 4); mov(memd[ss, esp + 28], esi);           /* mov [esp+0x1c], esi */
            ii(0x1016_d3f0, 4); mov(memd[ss, esp + 12], eax);           /* mov [esp+0xc], eax */
        l_0x1016_d3f4:
            ii(0x1016_d3f4, 4); mov(ebp, memd[ss, esp + 40]);           /* mov ebp, [esp+0x28] */
            ii(0x1016_d3f8, 4); mov(eax, memd[ss, esp + 28]);           /* mov eax, [esp+0x1c] */
            ii(0x1016_d3fc, 4); mov(edi, memd[ss, esp + 44]);           /* mov edi, [esp+0x2c] */
            ii(0x1016_d400, 4); mov(memd[ss, esp + 56], eax);           /* mov [esp+0x38], eax */
            ii(0x1016_d404, 4); mov(eax, memd[ss, esp + 24]);           /* mov eax, [esp+0x18] */
            ii(0x1016_d408, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_d40a, 4); mov(memd[ss, esp + 48], eax);           /* mov [esp+0x30], eax */
            ii(0x1016_d40e, 4); mov(eax, memd[ss, esp + 36]);           /* mov eax, [esp+0x24] */
            ii(0x1016_d412, 4); mov(memd[ss, esp + 60], edx);           /* mov [esp+0x3c], edx */
            ii(0x1016_d416, 4); mov(memd[ss, esp + 52], eax);           /* mov [esp+0x34], eax */
        l_0x1016_d41a:
            ii(0x1016_d41a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_d41c, 4); mov(dl, memb[ss, esp + 60]);            /* mov dl, [esp+0x3c] */
            ii(0x1016_d420, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1016_d422, 5); call(/* sys */ 0x1016_cae8, -0x93f);    /* call 0x1016cae8 */
            ii(0x1016_d427, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x1016_d429, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1016_d42b, 6); and(esi, 0x7c00);                       /* and esi, 0x7c00 */
            ii(0x1016_d431, 5); call(/* sys */ 0x1016_cae8, -0x94e);    /* call 0x1016cae8 */
            ii(0x1016_d436, 3); sar(esi, 0xa);                          /* sar esi, 0xa */
            ii(0x1016_d439, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1016_d43b, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1016_d43d, 2); mov(edx, ebp);                          /* mov edx, ebp */
            ii(0x1016_d43f, 3); imul(edx, esi);                         /* imul edx, esi */
            ii(0x1016_d442, 5); call(/* sys */ 0x1016_cae8, -0x95f);    /* call 0x1016cae8 */
            ii(0x1016_d447, 4); mov(esi, memd[ss, esp + 56]);           /* mov esi, [esp+0x38] */
            ii(0x1016_d44b, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1016_d44d, 2); add(edx, esi);                          /* add edx, esi */
            ii(0x1016_d44f, 5); mov(esi, 7);                            /* mov esi, 0x7 */
            ii(0x1016_d454, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1016_d456, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1016_d459, 2); idiv(esi);                              /* idiv esi */
            ii(0x1016_d45b, 6); and(ebx, 0x3e0);                        /* and ebx, 0x3e0 */
            ii(0x1016_d461, 3); sar(ebx, 5);                            /* sar ebx, 0x5 */
            ii(0x1016_d464, 2); mov(edx, ebp);                          /* mov edx, ebp */
            ii(0x1016_d466, 3); imul(edx, ebx);                         /* imul edx, ebx */
            ii(0x1016_d469, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x1016_d46b, 4); add(edx, memd[ss, esp + 48]);           /* add edx, [esp+0x30] */
            ii(0x1016_d46f, 5); mov(ebx, 7);                            /* mov ebx, 0x7 */
            ii(0x1016_d474, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1016_d476, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1016_d479, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1016_d47b, 3); and(ecx, 0x1f);                         /* and ecx, 0x1f */
            ii(0x1016_d47e, 2); mov(edx, ebp);                          /* mov edx, ebp */
            ii(0x1016_d480, 3); imul(edx, ecx);                         /* imul edx, ecx */
            ii(0x1016_d483, 4); mov(ecx, memd[ss, esp + 52]);           /* mov ecx, [esp+0x34] */
            ii(0x1016_d487, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1016_d489, 2); add(edx, ecx);                          /* add edx, ecx */
            ii(0x1016_d48b, 5); mov(ecx, 7);                            /* mov ecx, 0x7 */
            ii(0x1016_d490, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1016_d492, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1016_d495, 2); idiv(ecx);                              /* idiv ecx */
            ii(0x1016_d497, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1016_d499, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1016_d49b, 3); shl(esi, 0xa);                          /* shl esi, 0xa */
            ii(0x1016_d49e, 3); shl(eax, 5);                            /* shl eax, 0x5 */
            ii(0x1016_d4a1, 2); or(eax, esi);                           /* or eax, esi */
            ii(0x1016_d4a3, 2); or(eax, ecx);                           /* or eax, ecx */
            ii(0x1016_d4a5, 6); mov(al, memb[ds, eax + 0x1020_0520]);   /* mov al, [eax+0x10200520] */
            ii(0x1016_d4ab, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1016_d4b0, 4); mov(esi, memd[ss, esp + 60]);           /* mov esi, [esp+0x3c] */
            ii(0x1016_d4b4, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1016_d4b9, 1); inc(edi);                               /* inc edi */
            ii(0x1016_d4ba, 1); inc(esi);                               /* inc esi */
            ii(0x1016_d4bb, 3); mov(memb[ds, edi - 1], al);             /* mov [edi-0x1], al */
            ii(0x1016_d4be, 4); mov(memd[ss, esp + 60], esi);           /* mov [esp+0x3c], esi */
            ii(0x1016_d4c2, 6); cmp(esi, 0x100);                        /* cmp esi, 0x100 */
            ii(0x1016_d4c8, 6); if(jl(0x1016_d41a, -0xb4)) goto l_0x1016_d41a; /* jl 0x1016d41a */
            ii(0x1016_d4ce, 4); mov(edx, memd[ss, esp + 44]);           /* mov edx, [esp+0x2c] */
            ii(0x1016_d4d2, 4); mov(eax, memd[ss, esp + 8]);            /* mov eax, [esp+0x8] */
            ii(0x1016_d4d6, 4); mov(ebx, memd[ss, esp + 36]);           /* mov ebx, [esp+0x24] */
            ii(0x1016_d4da, 4); mov(ecx, memd[ss, esp + 24]);           /* mov ecx, [esp+0x18] */
            ii(0x1016_d4de, 4); mov(esi, memd[ss, esp + 28]);           /* mov esi, [esp+0x1c] */
            ii(0x1016_d4e2, 4); mov(edi, memd[ss, esp + 40]);           /* mov edi, [esp+0x28] */
            ii(0x1016_d4e6, 4); mov(ebp, memd[ss, esp + 12]);           /* mov ebp, [esp+0xc] */
            ii(0x1016_d4ea, 6); add(edx, 0x100);                        /* add edx, 0x100 */
            ii(0x1016_d4f0, 1); dec(edi);                               /* dec edi */
            ii(0x1016_d4f1, 2); add(ebx, eax);                          /* add ebx, eax */
            ii(0x1016_d4f3, 4); mov(eax, memd[ss, esp + 16]);           /* mov eax, [esp+0x10] */
            ii(0x1016_d4f7, 4); mov(memd[ss, esp + 44], edx);           /* mov [esp+0x2c], edx */
            ii(0x1016_d4fb, 4); mov(memd[ss, esp + 36], ebx);           /* mov [esp+0x24], ebx */
            ii(0x1016_d4ff, 2); add(ecx, eax);                          /* add ecx, eax */
            ii(0x1016_d501, 4); mov(eax, memd[ss, esp + 4]);            /* mov eax, [esp+0x4] */
            ii(0x1016_d505, 4); mov(memd[ss, esp + 40], edi);           /* mov [esp+0x28], edi */
            ii(0x1016_d509, 2); add(esi, eax);                          /* add esi, eax */
            ii(0x1016_d50b, 4); mov(memd[ss, esp + 24], ecx);           /* mov [esp+0x18], ecx */
            ii(0x1016_d50f, 4); mov(memd[ss, esp + 28], esi);           /* mov [esp+0x1c], esi */
            ii(0x1016_d513, 2); cmp(edx, ebp);                          /* cmp edx, ebp */
            ii(0x1016_d515, 2); if(jz(0x1016_d51c, 5)) goto l_0x1016_d51c; /* jz 0x1016d51c */
            ii(0x1016_d517, 5); jmp(0x1016_d3f4, -0x128); goto l_0x1016_d3f4; /* jmp 0x1016d3f4 */
        l_0x1016_d51c:
            ii(0x1016_d51c, 3); mov(eax, memd[ss, esp]);                /* mov eax, [esp] */
            ii(0x1016_d51f, 5); add(eax, 0x900);                        /* add eax, 0x900 */
            ii(0x1016_d524, 3); mov(ebp, memd[ss, esp]);                /* mov ebp, [esp] */
            ii(0x1016_d527, 4); mov(memd[ss, esp + 32], eax);           /* mov [esp+0x20], eax */
            ii(0x1016_d52b, 3); mov(eax, memd[ss, esp]);                /* mov eax, [esp] */
            ii(0x1016_d52e, 2); xor(edi, edi);                          /* xor edi, edi */
            ii(0x1016_d530, 5); add(eax, 0x1000);                       /* add eax, 0x1000 */
            ii(0x1016_d535, 6); add(ebp, 0x800);                        /* add ebp, 0x800 */
            ii(0x1016_d53b, 4); mov(memd[ss, esp + 20], eax);           /* mov [esp+0x14], eax */
        l_0x1016_d53f:
            ii(0x1016_d53f, 5); mov(ebx, 7);                            /* mov ebx, 0x7 */
            ii(0x1016_d544, 2); mov(edx, edi);                          /* mov edx, edi */
            ii(0x1016_d546, 2); mov(eax, edi);                          /* mov eax, edi */
            ii(0x1016_d548, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1016_d54b, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1016_d54d, 4); mov(esi, memd[ss, esp + 32]);           /* mov esi, [esp+0x20] */
            ii(0x1016_d551, 6); lea(ecx, memd[ds, eax + 0xffff]);       /* lea ecx, [eax+0xffff] */
            ii(0x1016_d557, 2); mov(ebx, ebp);                          /* mov ebx, ebp */
        l_0x1016_d559:
            ii(0x1016_d559, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_d55b, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1016_d55d, 4); mov(dl, memb[ss, esp + 64]);            /* mov dl, [esp+0x40] */
            ii(0x1016_d561, 5); call(/* sys */ 0x1016_cab4, -0xab2);    /* call 0x1016cab4 */
            ii(0x1016_d566, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1016_d56b, 1); inc(ebx);                               /* inc ebx */
            ii(0x1016_d56c, 3); mov(memb[ds, ebx - 1], al);             /* mov [ebx-0x1], al */
            ii(0x1016_d56f, 2); cmp(ebx, esi);                          /* cmp ebx, esi */
            ii(0x1016_d571, 2); if(jnz(0x1016_d559, -0x1a)) goto l_0x1016_d559; /* jnz 0x1016d559 */
            ii(0x1016_d573, 4); mov(eax, memd[ss, esp + 32]);           /* mov eax, [esp+0x20] */
            ii(0x1016_d577, 4); mov(edx, memd[ss, esp + 20]);           /* mov edx, [esp+0x14] */
            ii(0x1016_d57b, 6); add(edi, 0x1_0000);                     /* add edi, 0x10000 */
            ii(0x1016_d581, 5); add(eax, 0x100);                        /* add eax, 0x100 */
            ii(0x1016_d586, 6); add(ebp, 0x100);                        /* add ebp, 0x100 */
            ii(0x1016_d58c, 4); mov(memd[ss, esp + 32], eax);           /* mov [esp+0x20], eax */
            ii(0x1016_d590, 2); cmp(ebp, edx);                          /* cmp ebp, edx */
            ii(0x1016_d592, 2); if(jnz(0x1016_d53f, -0x55)) goto l_0x1016_d53f; /* jnz 0x1016d53f */
            ii(0x1016_d594, 3); add(esp, 0x44);                         /* add esp, 0x44 */
            ii(0x1016_d597, 1); pop(ebp);                               /* pop ebp */
            ii(0x1016_d598, 1); pop(edi);                               /* pop edi */
            ii(0x1016_d599, 1); pop(esi);                               /* pop esi */
            ii(0x1016_d59a, 1); pop(ecx);                               /* pop ecx */
            ii(0x1016_d59b, 1); pop(ebx);                               /* pop ebx */
            ii(0x1016_d59c, 1); ret();                                  /* ret */
        }
    }
}
