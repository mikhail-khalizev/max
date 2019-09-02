using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1028_c104-94da9d86")]
        public void Method_1028_c104()
        {
            ii(0x1028_c104, 1); pushd(ds);                              /* push ds */
            ii(0x1028_c105, 1); push(esi);                              /* push esi */
            ii(0x1028_c106, 6); mov(ecx, memd[ds, 0x1348]);             /* mov ecx, [0x1348] */
            ii(0x1028_c10c, 6); mov(memd[ds, 0x134c], ecx);             /* mov [0x134c], ecx */
            ii(0x1028_c112, 4); movzx(ebp, memw[ds, esi + 0x48]);       /* movzx ebp, word [esi+0x48] */
            ii(0x1028_c116, 4); movzx(eax, memw[ds, esi + 0x44]);       /* movzx eax, word [esi+0x44] */
            ii(0x1028_c11a, 5); mov(memd[ds, 0x138a], eax);             /* mov [0x138a], eax */
            ii(0x1028_c11f, 4); movzx(eax, memw[ds, esi + 0x46]);       /* movzx eax, word [esi+0x46] */
            ii(0x1028_c123, 5); mov(memd[ds, 0x138e], eax);             /* mov [0x138e], eax */
            ii(0x1028_c128, 6); mov(memd[ds, 0x1392], esi);             /* mov [0x1392], esi */
            ii(0x1028_c12e, 4); movzx(eax, memw[ds, esi + 0x32]);       /* movzx eax, word [esi+0x32] */
            ii(0x1028_c132, 7); imul(memw[ds, 0x1334]);                 /* imul word [0x1334] */
            ii(0x1028_c139, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x1028_c13b, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x1028_c13d, 7); mov(es, memw[ds, 0x135c]);              /* mov es, [0x135c] */
            ii(0x1028_c144, 6); mov(ecx, memd[ds, 0x1340]);             /* mov ecx, [0x1340] */
            ii(0x1028_c14a, 3); shr(ecx, 2);                            /* shr ecx, 0x2 */
            ii(0x1028_c14d, 6); mov(memd[ds, 0x1344], ecx);             /* mov [0x1344], ecx */
            ii(0x1028_c153, 3); lds(esi, memd[ds, esi + 8]);            /* lds esi, [esi+0x8] */
            ii(0x1028_c156, 1); cld();                                  /* cld */
            ii(0x1028_c157, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1028_c159, 8); cmp(memd[fs, 0x1344], 0);               /* cmp dword [fs:0x1344], 0x0 */
            ii(0x1028_c161, 6); if(jz(0x1028_c1d9, 0x72)) goto l_0x1028_c1d9; /* jz 0x1028c1d9 */
        l_0x1028_c167:
            ii(0x1028_c167, 4); movzx(eax, memw[ds, esi + ecx * 2]);    /* movzx eax, word [esi+ecx*2] */
            ii(0x1028_c16b, 8); add(bp, memw[fs, 0x138a]);              /* add bp, [fs:0x138a] */
            ii(0x1028_c173, 7); adc(ecx, memd[fs, 0x138e]);             /* adc ecx, [fs:0x138e] */
            ii(0x1028_c17a, 4); add(ax, memw[es, edi]);                 /* add ax, [es:edi] */
            ii(0x1028_c17e, 2); if(jno(0x1028_c192, 0x12)) goto l_0x1028_c192; /* jno 0x1028c192 */
            ii(0x1028_c180, 4); cmp(ax, 0);                             /* cmp ax, 0x0 */
            ii(0x1028_c184, 2); if(jl(0x1028_c18d, 7)) goto l_0x1028_c18d; /* jl 0x1028c18d */
            ii(0x1028_c186, 5); mov(eax, 0x8000);                       /* mov eax, 0x8000 */
            ii(0x1028_c18b, 2); jmp(0x1028_c192, 5); goto l_0x1028_c192; /* jmp 0x1028c192 */
        l_0x1028_c18d:
            ii(0x1028_c18d, 5); mov(eax, 0x7fff);                       /* mov eax, 0x7fff */
        l_0x1028_c192:
            ii(0x1028_c192, 4); mov(memw[es, edi], ax);                 /* mov [es:edi], ax */
            ii(0x1028_c196, 3); add(edi, 2);                            /* add edi, 0x2 */
            ii(0x1028_c199, 4); movzx(eax, memw[ds, esi + ecx * 2]);    /* movzx eax, word [esi+ecx*2] */
            ii(0x1028_c19d, 8); add(bp, memw[fs, 0x138a]);              /* add bp, [fs:0x138a] */
            ii(0x1028_c1a5, 7); adc(ecx, memd[fs, 0x138e]);             /* adc ecx, [fs:0x138e] */
            ii(0x1028_c1ac, 4); add(ax, memw[es, edi]);                 /* add ax, [es:edi] */
            ii(0x1028_c1b0, 2); if(jno(0x1028_c1c4, 0x12)) goto l_0x1028_c1c4; /* jno 0x1028c1c4 */
            ii(0x1028_c1b2, 4); cmp(ax, 0);                             /* cmp ax, 0x0 */
            ii(0x1028_c1b6, 2); if(jl(0x1028_c1bf, 7)) goto l_0x1028_c1bf; /* jl 0x1028c1bf */
            ii(0x1028_c1b8, 5); mov(eax, 0x8000);                       /* mov eax, 0x8000 */
            ii(0x1028_c1bd, 2); jmp(0x1028_c1c4, 5); goto l_0x1028_c1c4; /* jmp 0x1028c1c4 */
        l_0x1028_c1bf:
            ii(0x1028_c1bf, 5); mov(eax, 0x7fff);                       /* mov eax, 0x7fff */
        l_0x1028_c1c4:
            ii(0x1028_c1c4, 4); mov(memw[es, edi], ax);                 /* mov [es:edi], ax */
            ii(0x1028_c1c8, 3); add(edi, 2);                            /* add edi, 0x2 */
            ii(0x1028_c1cb, 8); sub(memd[fs, 0x1344], 1);               /* sub dword [fs:0x1344], 0x1 */
            ii(0x1028_c1d3, 6); if(jnz(0x1028_c167, -0x72)) goto l_0x1028_c167; /* jnz 0x1028c167 */
        l_0x1028_c1d9:
            ii(0x1028_c1d9, 6); mov(eax, memd[fs, 0x134c]);             /* mov eax, [fs:0x134c] */
            ii(0x1028_c1df, 3); shr(eax, 2);                            /* shr eax, 0x2 */
            ii(0x1028_c1e2, 3); adc(eax, 0);                            /* adc eax, 0x0 */
            ii(0x1028_c1e5, 6); mov(memd[fs, 0x134c], eax);             /* mov [fs:0x134c], eax */
            ii(0x1028_c1eb, 2); or(eax, eax);                           /* or eax, eax */
            ii(0x1028_c1ed, 6); if(jz(0x1028_c267, 0x74)) goto l_0x1028_c267; /* jz 0x1028c267 */
            ii(0x1028_c1f3, 2); xor(edi, edi);                          /* xor edi, edi */
        l_0x1028_c1f5:
            ii(0x1028_c1f5, 4); movzx(eax, memw[ds, esi + ecx * 2]);    /* movzx eax, word [esi+ecx*2] */
            ii(0x1028_c1f9, 8); add(bp, memw[fs, 0x138a]);              /* add bp, [fs:0x138a] */
            ii(0x1028_c201, 7); adc(ecx, memd[fs, 0x138e]);             /* adc ecx, [fs:0x138e] */
            ii(0x1028_c208, 4); add(ax, memw[es, edi]);                 /* add ax, [es:edi] */
            ii(0x1028_c20c, 2); if(jno(0x1028_c220, 0x12)) goto l_0x1028_c220; /* jno 0x1028c220 */
            ii(0x1028_c20e, 4); cmp(ax, 0);                             /* cmp ax, 0x0 */
            ii(0x1028_c212, 2); if(jl(0x1028_c21b, 7)) goto l_0x1028_c21b; /* jl 0x1028c21b */
            ii(0x1028_c214, 5); mov(eax, 0x8000);                       /* mov eax, 0x8000 */
            ii(0x1028_c219, 2); jmp(0x1028_c220, 5); goto l_0x1028_c220; /* jmp 0x1028c220 */
        l_0x1028_c21b:
            ii(0x1028_c21b, 5); mov(eax, 0x7fff);                       /* mov eax, 0x7fff */
        l_0x1028_c220:
            ii(0x1028_c220, 4); mov(memw[es, edi], ax);                 /* mov [es:edi], ax */
            ii(0x1028_c224, 3); add(edi, 2);                            /* add edi, 0x2 */
            ii(0x1028_c227, 4); movzx(eax, memw[ds, esi + ecx * 2]);    /* movzx eax, word [esi+ecx*2] */
            ii(0x1028_c22b, 8); add(bp, memw[fs, 0x138a]);              /* add bp, [fs:0x138a] */
            ii(0x1028_c233, 7); adc(ecx, memd[fs, 0x138e]);             /* adc ecx, [fs:0x138e] */
            ii(0x1028_c23a, 4); add(ax, memw[es, edi]);                 /* add ax, [es:edi] */
            ii(0x1028_c23e, 2); if(jno(0x1028_c252, 0x12)) goto l_0x1028_c252; /* jno 0x1028c252 */
            ii(0x1028_c240, 4); cmp(ax, 0);                             /* cmp ax, 0x0 */
            ii(0x1028_c244, 2); if(jl(0x1028_c24d, 7)) goto l_0x1028_c24d; /* jl 0x1028c24d */
            ii(0x1028_c246, 5); mov(eax, 0x8000);                       /* mov eax, 0x8000 */
            ii(0x1028_c24b, 2); jmp(0x1028_c252, 5); goto l_0x1028_c252; /* jmp 0x1028c252 */
        l_0x1028_c24d:
            ii(0x1028_c24d, 5); mov(eax, 0x7fff);                       /* mov eax, 0x7fff */
        l_0x1028_c252:
            ii(0x1028_c252, 4); mov(memw[es, edi], ax);                 /* mov [es:edi], ax */
            ii(0x1028_c256, 3); add(edi, 2);                            /* add edi, 0x2 */
            ii(0x1028_c259, 8); sub(memd[fs, 0x134c], 1);               /* sub dword [fs:0x134c], 0x1 */
            ii(0x1028_c261, 6); if(jnz(0x1028_c1f5, -0x72)) goto l_0x1028_c1f5; /* jnz 0x1028c1f5 */
        l_0x1028_c267:
            ii(0x1028_c267, 7); mov(ebx, memd[fs, 0x1392]);             /* mov ebx, [fs:0x1392] */
            ii(0x1028_c26e, 5); mov(memw[fs, ebx + 0x48], bp);          /* mov [fs:ebx+0x48], bp */
            ii(0x1028_c273, 2); add(ecx, ecx);                          /* add ecx, ecx */
            ii(0x1028_c275, 2); add(esi, ecx);                          /* add esi, ecx */
            ii(0x1028_c277, 4); mov(memd[fs, ebx + 8], esi);            /* mov [fs:ebx+0x8], esi */
            ii(0x1028_c27b, 1); pop(esi);                               /* pop esi */
            ii(0x1028_c27c, 1); popd(ds);                               /* pop ds */
            ii(0x1028_c27d, 1); ret();                                  /* ret */
        }
    }
}
