using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1028_c104-b0375282")]
        public void Method_1028_c104_v3()
        {
            ii(0x1028_c104, 1); pushd(ds);                              /* push ds */
            ii(0x1028_c105, 1); pushd(esi);                             /* push esi */
            ii(0x1028_c106, 6); mov(ecx, memd_a32[ds, 0x1348]);         /* mov ecx, [0x1348] */
            ii(0x1028_c10c, 6); mov(memd_a32[ds, 0x134c], ecx);         /* mov [0x134c], ecx */
            ii(0x1028_c112, 4); movzx(ebp, memw_a32[ds, esi + 0x48]);   /* movzx ebp, word [esi+0x48] */
            ii(0x1028_c116, 4); movzx(eax, memw_a32[ds, esi + 0x44]);   /* movzx eax, word [esi+0x44] */
            ii(0x1028_c11a, 5); mov(memd_a32[ds, 0x138a], eax);         /* mov [0x138a], eax */
            ii(0x1028_c11f, 4); movzx(eax, memw_a32[ds, esi + 0x46]);   /* movzx eax, word [esi+0x46] */
            ii(0x1028_c123, 5); mov(memd_a32[ds, 0x138e], eax);         /* mov [0x138e], eax */
            ii(0x1028_c128, 6); mov(memd_a32[ds, 0x1392], esi);         /* mov [0x1392], esi */
            ii(0x1028_c12e, 4); movzx(eax, memw_a32[ds, esi + 0x32]);   /* movzx eax, word [esi+0x32] */
            ii(0x1028_c132, 7); imul(memw_a32[ds, 0x1334]);             /* imul word [0x1334] */
            ii(0x1028_c139, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x1028_c13b, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x1028_c13d, 7); mov(es, memw_a32[ds, 0x135c]);          /* mov es, [0x135c] */
            ii(0x1028_c144, 6); mov(ecx, memd_a32[ds, 0x1340]);         /* mov ecx, [0x1340] */
            ii(0x1028_c14a, 3); shr(ecx, 0x2);                          /* shr ecx, 0x2 */
            ii(0x1028_c14d, 6); mov(memd_a32[ds, 0x1344], ecx);         /* mov [0x1344], ecx */
            ii(0x1028_c153, 3); lds(esi, ds, esi + 0x8);                /* lds esi, [esi+0x8] */
            ii(0x1028_c156, 1); cld();                                  /* cld */
            ii(0x1028_c157, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1028_c159, 8); cmp(memd_a32[fs, 0x1344], 0);           /* cmp dword [fs:0x1344], 0x0 */
            ii(0x1028_c161, 6); if(jzd(0x1028_c1e7, 0x80)) goto l_0x1028_c1e7; /* jz 0x1028c1e7 */
        l_0x1028_c167:
            ii(0x1028_c167, 4); movzx(eax, memw_a32[ds, esi + ecx * 2]); /* movzx eax, word [esi+ecx*2] */
            ii(0x1028_c16b, 8); add(bp, memw_a32[fs, 0x138a]);          /* add bp, [fs:0x138a] */
            ii(0x1028_c173, 7); adc(ecx, memd_a32[fs, 0x138e]);         /* adc ecx, [fs:0x138e] */
            ii(0x1028_c17a, 3); imul(bx);                               /* imul bx */
            ii(0x1028_c17d, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x1028_c17f, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1028_c181, 4); add(ax, memw_a32[es, edi]);             /* add ax, [es:edi] */
            ii(0x1028_c185, 2); if(jnod(0x1028_c199, 0x12)) goto l_0x1028_c199; /* jno 0x1028c199 */
            ii(0x1028_c187, 4); cmp(ax, 0);                             /* cmp ax, 0x0 */
            ii(0x1028_c18b, 2); if(jld(0x1028_c194, 0x7)) goto l_0x1028_c194; /* jl 0x1028c194 */
            ii(0x1028_c18d, 5); mov(eax, 0x8000);                       /* mov eax, 0x8000 */
            ii(0x1028_c192, 2); jmpd(0x1028_c199, 0x5); goto l_0x1028_c199; /* jmp 0x1028c199 */
        l_0x1028_c194:
            ii(0x1028_c194, 5); mov(eax, 0x7fff);                       /* mov eax, 0x7fff */
        l_0x1028_c199:
            ii(0x1028_c199, 4); mov(memw_a32[es, edi], ax);             /* mov [es:edi], ax */
            ii(0x1028_c19d, 3); add(edi, 0x2);                          /* add edi, 0x2 */
            ii(0x1028_c1a0, 4); movzx(eax, memw_a32[ds, esi + ecx * 2]); /* movzx eax, word [esi+ecx*2] */
            ii(0x1028_c1a4, 8); add(bp, memw_a32[fs, 0x138a]);          /* add bp, [fs:0x138a] */
            ii(0x1028_c1ac, 7); adc(ecx, memd_a32[fs, 0x138e]);         /* adc ecx, [fs:0x138e] */
            ii(0x1028_c1b3, 3); imul(bx);                               /* imul bx */
            ii(0x1028_c1b6, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x1028_c1b8, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1028_c1ba, 4); add(ax, memw_a32[es, edi]);             /* add ax, [es:edi] */
            ii(0x1028_c1be, 2); if(jnod(0x1028_c1d2, 0x12)) goto l_0x1028_c1d2; /* jno 0x1028c1d2 */
            ii(0x1028_c1c0, 4); cmp(ax, 0);                             /* cmp ax, 0x0 */
            ii(0x1028_c1c4, 2); if(jld(0x1028_c1cd, 0x7)) goto l_0x1028_c1cd; /* jl 0x1028c1cd */
            ii(0x1028_c1c6, 5); mov(eax, 0x8000);                       /* mov eax, 0x8000 */
            ii(0x1028_c1cb, 2); jmpd(0x1028_c1d2, 0x5); goto l_0x1028_c1d2; /* jmp 0x1028c1d2 */
        l_0x1028_c1cd:
            ii(0x1028_c1cd, 5); mov(eax, 0x7fff);                       /* mov eax, 0x7fff */
        l_0x1028_c1d2:
            ii(0x1028_c1d2, 4); mov(memw_a32[es, edi], ax);             /* mov [es:edi], ax */
            ii(0x1028_c1d6, 3); add(edi, 0x2);                          /* add edi, 0x2 */
            ii(0x1028_c1d9, 8); sub(memd_a32[fs, 0x1344], 0x1);         /* sub dword [fs:0x1344], 0x1 */
            ii(0x1028_c1e1, 6); if(jnzd(0x1028_c167, -0x80)) goto l_0x1028_c167; /* jnz 0x1028c167 */
        l_0x1028_c1e7:
            ii(0x1028_c1e7, 6); mov(eax, memd_a32[fs, 0x134c]);         /* mov eax, [fs:0x134c] */
            ii(0x1028_c1ed, 3); shr(eax, 0x2);                          /* shr eax, 0x2 */
            ii(0x1028_c1f0, 3); adc(eax, 0);                            /* adc eax, 0x0 */
            ii(0x1028_c1f3, 6); mov(memd_a32[fs, 0x134c], eax);         /* mov [fs:0x134c], eax */
            ii(0x1028_c1f9, 2); or(eax, eax);                           /* or eax, eax */
            ii(0x1028_c1fb, 6); if(jzd(0x1028_c283, 0x82)) goto l_0x1028_c283; /* jz 0x1028c283 */
            ii(0x1028_c201, 2); xor(edi, edi);                          /* xor edi, edi */
        l_0x1028_c203:
            ii(0x1028_c203, 4); movzx(eax, memw_a32[ds, esi + ecx * 2]); /* movzx eax, word [esi+ecx*2] */
            ii(0x1028_c207, 8); add(bp, memw_a32[fs, 0x138a]);          /* add bp, [fs:0x138a] */
            ii(0x1028_c20f, 7); adc(ecx, memd_a32[fs, 0x138e]);         /* adc ecx, [fs:0x138e] */
            ii(0x1028_c216, 3); imul(bx);                               /* imul bx */
            ii(0x1028_c219, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x1028_c21b, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1028_c21d, 4); add(ax, memw_a32[es, edi]);             /* add ax, [es:edi] */
            ii(0x1028_c221, 2); if(jnod(0x1028_c235, 0x12)) goto l_0x1028_c235; /* jno 0x1028c235 */
            ii(0x1028_c223, 4); cmp(ax, 0);                             /* cmp ax, 0x0 */
            ii(0x1028_c227, 2); if(jld(0x1028_c230, 0x7)) goto l_0x1028_c230; /* jl 0x1028c230 */
            ii(0x1028_c229, 5); mov(eax, 0x8000);                       /* mov eax, 0x8000 */
            ii(0x1028_c22e, 2); jmpd(0x1028_c235, 0x5); goto l_0x1028_c235; /* jmp 0x1028c235 */
        l_0x1028_c230:
            ii(0x1028_c230, 5); mov(eax, 0x7fff);                       /* mov eax, 0x7fff */
        l_0x1028_c235:
            ii(0x1028_c235, 4); mov(memw_a32[es, edi], ax);             /* mov [es:edi], ax */
            ii(0x1028_c239, 3); add(edi, 0x2);                          /* add edi, 0x2 */
            ii(0x1028_c23c, 4); movzx(eax, memw_a32[ds, esi + ecx * 2]); /* movzx eax, word [esi+ecx*2] */
            ii(0x1028_c240, 8); add(bp, memw_a32[fs, 0x138a]);          /* add bp, [fs:0x138a] */
            ii(0x1028_c248, 7); adc(ecx, memd_a32[fs, 0x138e]);         /* adc ecx, [fs:0x138e] */
            ii(0x1028_c24f, 3); imul(bx);                               /* imul bx */
            ii(0x1028_c252, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x1028_c254, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1028_c256, 4); add(ax, memw_a32[es, edi]);             /* add ax, [es:edi] */
            ii(0x1028_c25a, 2); if(jnod(0x1028_c26e, 0x12)) goto l_0x1028_c26e; /* jno 0x1028c26e */
            ii(0x1028_c25c, 4); cmp(ax, 0);                             /* cmp ax, 0x0 */
            ii(0x1028_c260, 2); if(jld(0x1028_c269, 0x7)) goto l_0x1028_c269; /* jl 0x1028c269 */
            ii(0x1028_c262, 5); mov(eax, 0x8000);                       /* mov eax, 0x8000 */
            ii(0x1028_c267, 2); jmpd(0x1028_c26e, 0x5); goto l_0x1028_c26e; /* jmp 0x1028c26e */
        l_0x1028_c269:
            ii(0x1028_c269, 5); mov(eax, 0x7fff);                       /* mov eax, 0x7fff */
        l_0x1028_c26e:
            ii(0x1028_c26e, 4); mov(memw_a32[es, edi], ax);             /* mov [es:edi], ax */
            ii(0x1028_c272, 3); add(edi, 0x2);                          /* add edi, 0x2 */
            ii(0x1028_c275, 8); sub(memd_a32[fs, 0x134c], 0x1);         /* sub dword [fs:0x134c], 0x1 */
            ii(0x1028_c27d, 6); if(jnzd(0x1028_c203, -0x80)) goto l_0x1028_c203; /* jnz 0x1028c203 */
        l_0x1028_c283:
            ii(0x1028_c283, 7); mov(ebx, memd_a32[fs, 0x1392]);         /* mov ebx, [fs:0x1392] */
            ii(0x1028_c28a, 5); mov(memw_a32[fs, ebx + 0x48], bp);      /* mov [fs:ebx+0x48], bp */
            ii(0x1028_c28f, 2); add(ecx, ecx);                          /* add ecx, ecx */
            ii(0x1028_c291, 2); add(esi, ecx);                          /* add esi, ecx */
            ii(0x1028_c293, 4); mov(memd_a32[fs, ebx + 0x8], esi);      /* mov [fs:ebx+0x8], esi */
            ii(0x1028_c297, 1); popd(esi);                              /* pop esi */
            ii(0x1028_c298, 1); popd(ds);                               /* pop ds */
            ii(0x1028_c299, 1); retd(); return;                         /* ret */
        }
    }
}
