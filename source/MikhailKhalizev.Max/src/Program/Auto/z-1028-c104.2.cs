using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1028_c104-bb4346be")]
        public void Method_1028_c104_v2()
        {
            ii(0x1028_c104, 1); pushd(ds);                              /* push ds */
            ii(0x1028_c105, 1); pushd(esi);                             /* push esi */
            ii(0x1028_c106, 6); mov(ecx, memd_a32[ds, 0x1348]);         /* mov ecx, [0x1348] */
            ii(0x1028_c10c, 6); mov(memd_a32[ds, 0x134c], ecx);         /* mov [0x134c], ecx */
            ii(0x1028_c112, 4); movzx(eax, memw_a32[ds, esi + 0x32]);   /* movzx eax, word [esi+0x32] */
            ii(0x1028_c116, 7); imul(memw_a32[ds, 0x1334]);             /* imul word [0x1334] */
            ii(0x1028_c11d, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x1028_c11f, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x1028_c121, 7); mov(es, memw_a32[ds, 0x135c]);          /* mov es, [0x135c] */
            ii(0x1028_c128, 6); mov(ecx, memd_a32[ds, 0x1340]);         /* mov ecx, [0x1340] */
            ii(0x1028_c12e, 3); shr(ecx, 0x2);                          /* shr ecx, 0x2 */
            ii(0x1028_c131, 6); mov(memd_a32[ds, 0x1344], ecx);         /* mov [0x1344], ecx */
            ii(0x1028_c137, 3); lds(esi, ds, esi + 0x8);                /* lds esi, [esi+0x8] */
            ii(0x1028_c13a, 1); cld();                                  /* cld */
            ii(0x1028_c13b, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1028_c13d, 8); cmp(memd_a32[fs, 0x1344], 0);           /* cmp dword [fs:0x1344], 0x0 */
            ii(0x1028_c145, 6); if(jzd(0x1028_c1b1, 0x66)) goto l_0x1028_c1b1; /* jz 0x1028c1b1 */
        l_0x1028_c14b:
            ii(0x1028_c14b, 3); movzx(eax, memw_a32[ds, esi]);          /* movzx eax, word [esi] */
            ii(0x1028_c14e, 3); add(esi, 0x2);                          /* add esi, 0x2 */
            ii(0x1028_c151, 3); imul(bx);                               /* imul bx */
            ii(0x1028_c154, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x1028_c156, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1028_c158, 4); add(ax, memw_a32[es, edi]);             /* add ax, [es:edi] */
            ii(0x1028_c15c, 2); if(jnod(0x1028_c170, 0x12)) goto l_0x1028_c170; /* jno 0x1028c170 */
            ii(0x1028_c15e, 4); cmp(ax, 0);                             /* cmp ax, 0x0 */
            ii(0x1028_c162, 2); if(jld(0x1028_c16b, 0x7)) goto l_0x1028_c16b; /* jl 0x1028c16b */
            ii(0x1028_c164, 5); mov(eax, 0x8000);                       /* mov eax, 0x8000 */
            ii(0x1028_c169, 2); jmpd(0x1028_c170, 0x5); goto l_0x1028_c170; /* jmp 0x1028c170 */
        l_0x1028_c16b:
            ii(0x1028_c16b, 5); mov(eax, 0x7fff);                       /* mov eax, 0x7fff */
        l_0x1028_c170:
            ii(0x1028_c170, 4); mov(memw_a32[es, edi], ax);             /* mov [es:edi], ax */
            ii(0x1028_c174, 3); add(edi, 0x2);                          /* add edi, 0x2 */
            ii(0x1028_c177, 3); movzx(eax, memw_a32[ds, esi]);          /* movzx eax, word [esi] */
            ii(0x1028_c17a, 3); add(esi, 0x2);                          /* add esi, 0x2 */
            ii(0x1028_c17d, 3); imul(bx);                               /* imul bx */
            ii(0x1028_c180, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x1028_c182, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1028_c184, 4); add(ax, memw_a32[es, edi]);             /* add ax, [es:edi] */
            ii(0x1028_c188, 2); if(jnod(0x1028_c19c, 0x12)) goto l_0x1028_c19c; /* jno 0x1028c19c */
            ii(0x1028_c18a, 4); cmp(ax, 0);                             /* cmp ax, 0x0 */
            ii(0x1028_c18e, 2); if(jld(0x1028_c197, 0x7)) goto l_0x1028_c197; /* jl 0x1028c197 */
            ii(0x1028_c190, 5); mov(eax, 0x8000);                       /* mov eax, 0x8000 */
            ii(0x1028_c195, 2); jmpd(0x1028_c19c, 0x5); goto l_0x1028_c19c; /* jmp 0x1028c19c */
        l_0x1028_c197:
            ii(0x1028_c197, 5); mov(eax, 0x7fff);                       /* mov eax, 0x7fff */
        l_0x1028_c19c:
            ii(0x1028_c19c, 4); mov(memw_a32[es, edi], ax);             /* mov [es:edi], ax */
            ii(0x1028_c1a0, 3); add(edi, 0x2);                          /* add edi, 0x2 */
            ii(0x1028_c1a3, 8); sub(memd_a32[fs, 0x1344], 0x1);         /* sub dword [fs:0x1344], 0x1 */
            ii(0x1028_c1ab, 6); if(jnzd(0x1028_c14b, -0x66)) goto l_0x1028_c14b; /* jnz 0x1028c14b */
        l_0x1028_c1b1:
            ii(0x1028_c1b1, 6); mov(eax, memd_a32[fs, 0x134c]);         /* mov eax, [fs:0x134c] */
            ii(0x1028_c1b7, 3); shr(eax, 0x2);                          /* shr eax, 0x2 */
            ii(0x1028_c1ba, 3); adc(eax, 0);                            /* adc eax, 0x0 */
            ii(0x1028_c1bd, 6); mov(memd_a32[fs, 0x134c], eax);         /* mov [fs:0x134c], eax */
            ii(0x1028_c1c3, 2); or(eax, eax);                           /* or eax, eax */
            ii(0x1028_c1c5, 6); if(jzd(0x1028_c233, 0x68)) goto l_0x1028_c233; /* jz 0x1028c233 */
            ii(0x1028_c1cb, 2); xor(edi, edi);                          /* xor edi, edi */
        l_0x1028_c1cd:
            ii(0x1028_c1cd, 3); movzx(eax, memw_a32[ds, esi]);          /* movzx eax, word [esi] */
            ii(0x1028_c1d0, 3); add(esi, 0x2);                          /* add esi, 0x2 */
            ii(0x1028_c1d3, 3); imul(bx);                               /* imul bx */
            ii(0x1028_c1d6, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x1028_c1d8, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1028_c1da, 4); add(ax, memw_a32[es, edi]);             /* add ax, [es:edi] */
            ii(0x1028_c1de, 2); if(jnod(0x1028_c1f2, 0x12)) goto l_0x1028_c1f2; /* jno 0x1028c1f2 */
            ii(0x1028_c1e0, 4); cmp(ax, 0);                             /* cmp ax, 0x0 */
            ii(0x1028_c1e4, 2); if(jld(0x1028_c1ed, 0x7)) goto l_0x1028_c1ed; /* jl 0x1028c1ed */
            ii(0x1028_c1e6, 5); mov(eax, 0x8000);                       /* mov eax, 0x8000 */
            ii(0x1028_c1eb, 2); jmpd(0x1028_c1f2, 0x5); goto l_0x1028_c1f2; /* jmp 0x1028c1f2 */
        l_0x1028_c1ed:
            ii(0x1028_c1ed, 5); mov(eax, 0x7fff);                       /* mov eax, 0x7fff */
        l_0x1028_c1f2:
            ii(0x1028_c1f2, 4); mov(memw_a32[es, edi], ax);             /* mov [es:edi], ax */
            ii(0x1028_c1f6, 3); add(edi, 0x2);                          /* add edi, 0x2 */
            ii(0x1028_c1f9, 3); movzx(eax, memw_a32[ds, esi]);          /* movzx eax, word [esi] */
            ii(0x1028_c1fc, 3); add(esi, 0x2);                          /* add esi, 0x2 */
            ii(0x1028_c1ff, 3); imul(bx);                               /* imul bx */
            ii(0x1028_c202, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x1028_c204, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1028_c206, 4); add(ax, memw_a32[es, edi]);             /* add ax, [es:edi] */
            ii(0x1028_c20a, 2); if(jnod(0x1028_c21e, 0x12)) goto l_0x1028_c21e; /* jno 0x1028c21e */
            ii(0x1028_c20c, 4); cmp(ax, 0);                             /* cmp ax, 0x0 */
            ii(0x1028_c210, 2); if(jld(0x1028_c219, 0x7)) goto l_0x1028_c219; /* jl 0x1028c219 */
            ii(0x1028_c212, 5); mov(eax, 0x8000);                       /* mov eax, 0x8000 */
            ii(0x1028_c217, 2); jmpd(0x1028_c21e, 0x5); goto l_0x1028_c21e; /* jmp 0x1028c21e */
        l_0x1028_c219:
            ii(0x1028_c219, 5); mov(eax, 0x7fff);                       /* mov eax, 0x7fff */
        l_0x1028_c21e:
            ii(0x1028_c21e, 4); mov(memw_a32[es, edi], ax);             /* mov [es:edi], ax */
            ii(0x1028_c222, 3); add(edi, 0x2);                          /* add edi, 0x2 */
            ii(0x1028_c225, 8); sub(memd_a32[fs, 0x134c], 0x1);         /* sub dword [fs:0x134c], 0x1 */
            ii(0x1028_c22d, 6); if(jnzd(0x1028_c1cd, -0x66)) goto l_0x1028_c1cd; /* jnz 0x1028c1cd */
        l_0x1028_c233:
            ii(0x1028_c233, 1); popd(esi);                              /* pop esi */
            ii(0x1028_c234, 1); popd(ds);                               /* pop ds */
            ii(0x1028_c235, 1); retd(); return;                         /* ret */
        }
    }
}
