using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1028_c304-bb4346be")]
        public void Method_1028_c304()
        {
            ii(0x1028_c304, 1); push(ds);                               /* push ds */
            ii(0x1028_c305, 1); push(esi);                              /* push esi */
            ii(0x1028_c306, 6); mov(ecx, memd[ds, 0x1348]);             /* mov ecx, [0x1348] */
            ii(0x1028_c30c, 6); mov(memd[ds, 0x134c], ecx);             /* mov [0x134c], ecx */
            ii(0x1028_c312, 4); movzx(eax, memw[ds, esi + 0x32]);       /* movzx eax, word [esi+0x32] */
            ii(0x1028_c316, 7); imul(memw[ds, 0x1334]);                 /* imul word [0x1334] */
            ii(0x1028_c31d, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x1028_c31f, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x1028_c321, 7); mov(es, memw[ds, 0x135c]);              /* mov es, [0x135c] */
            ii(0x1028_c328, 6); mov(ecx, memd[ds, 0x1340]);             /* mov ecx, [0x1340] */
            ii(0x1028_c32e, 3); shr(ecx, 0x2);                          /* shr ecx, 0x2 */
            ii(0x1028_c331, 6); mov(memd[ds, 0x1344], ecx);             /* mov [0x1344], ecx */
            ii(0x1028_c337, 3); lds(esi, ds, esi + 0x8);                /* lds esi, [esi+0x8] */
            ii(0x1028_c33a, 1); cld();                                  /* cld */
            ii(0x1028_c33b, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1028_c33d, 8); cmp(memd[fs, 0x1344], 0);               /* cmp dword [fs:0x1344], 0x0 */
            ii(0x1028_c345, 6); if(jz(0x1028_c3b1, 0x66)) goto l_0x1028_c3b1; /* jz 0x1028c3b1 */
        l_0x1028_c34b:
            ii(0x1028_c34b, 3); movzx(eax, memw[ds, esi]);              /* movzx eax, word [esi] */
            ii(0x1028_c34e, 3); add(esi, 0x2);                          /* add esi, 0x2 */
            ii(0x1028_c351, 3); imul(bx);                               /* imul bx */
            ii(0x1028_c354, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x1028_c356, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1028_c358, 4); add(ax, memw[es, edi]);                 /* add ax, [es:edi] */
            ii(0x1028_c35c, 2); if(jno(0x1028_c370, 0x12)) goto l_0x1028_c370; /* jno 0x1028c370 */
            ii(0x1028_c35e, 4); cmp(ax, 0);                             /* cmp ax, 0x0 */
            ii(0x1028_c362, 2); if(jl(0x1028_c36b, 0x7)) goto l_0x1028_c36b; /* jl 0x1028c36b */
            ii(0x1028_c364, 5); mov(eax, 0x8000);                       /* mov eax, 0x8000 */
            ii(0x1028_c369, 2); jmp(0x1028_c370, 0x5); goto l_0x1028_c370; /* jmp 0x1028c370 */
        l_0x1028_c36b:
            ii(0x1028_c36b, 5); mov(eax, 0x7fff);                       /* mov eax, 0x7fff */
        l_0x1028_c370:
            ii(0x1028_c370, 4); mov(memw[es, edi], ax);                 /* mov [es:edi], ax */
            ii(0x1028_c374, 3); add(edi, 0x2);                          /* add edi, 0x2 */
            ii(0x1028_c377, 3); movzx(eax, memw[ds, esi]);              /* movzx eax, word [esi] */
            ii(0x1028_c37a, 3); add(esi, 0x2);                          /* add esi, 0x2 */
            ii(0x1028_c37d, 3); imul(bx);                               /* imul bx */
            ii(0x1028_c380, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x1028_c382, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1028_c384, 4); add(ax, memw[es, edi]);                 /* add ax, [es:edi] */
            ii(0x1028_c388, 2); if(jno(0x1028_c39c, 0x12)) goto l_0x1028_c39c; /* jno 0x1028c39c */
            ii(0x1028_c38a, 4); cmp(ax, 0);                             /* cmp ax, 0x0 */
            ii(0x1028_c38e, 2); if(jl(0x1028_c397, 0x7)) goto l_0x1028_c397; /* jl 0x1028c397 */
            ii(0x1028_c390, 5); mov(eax, 0x8000);                       /* mov eax, 0x8000 */
            ii(0x1028_c395, 2); jmp(0x1028_c39c, 0x5); goto l_0x1028_c39c; /* jmp 0x1028c39c */
        l_0x1028_c397:
            ii(0x1028_c397, 5); mov(eax, 0x7fff);                       /* mov eax, 0x7fff */
        l_0x1028_c39c:
            ii(0x1028_c39c, 4); mov(memw[es, edi], ax);                 /* mov [es:edi], ax */
            ii(0x1028_c3a0, 3); add(edi, 0x2);                          /* add edi, 0x2 */
            ii(0x1028_c3a3, 8); sub(memd[fs, 0x1344], 0x1);             /* sub dword [fs:0x1344], 0x1 */
            ii(0x1028_c3ab, 6); if(jnz(0x1028_c34b, -0x66)) goto l_0x1028_c34b; /* jnz 0x1028c34b */
        l_0x1028_c3b1:
            ii(0x1028_c3b1, 6); mov(eax, memd[fs, 0x134c]);             /* mov eax, [fs:0x134c] */
            ii(0x1028_c3b7, 3); shr(eax, 0x2);                          /* shr eax, 0x2 */
            ii(0x1028_c3ba, 3); adc(eax, 0);                            /* adc eax, 0x0 */
            ii(0x1028_c3bd, 6); mov(memd[fs, 0x134c], eax);             /* mov [fs:0x134c], eax */
            ii(0x1028_c3c3, 2); or(eax, eax);                           /* or eax, eax */
            ii(0x1028_c3c5, 6); if(jz(0x1028_c433, 0x68)) goto l_0x1028_c433; /* jz 0x1028c433 */
            ii(0x1028_c3cb, 2); xor(edi, edi);                          /* xor edi, edi */
        l_0x1028_c3cd:
            ii(0x1028_c3cd, 3); movzx(eax, memw[ds, esi]);              /* movzx eax, word [esi] */
            ii(0x1028_c3d0, 3); add(esi, 0x2);                          /* add esi, 0x2 */
            ii(0x1028_c3d3, 3); imul(bx);                               /* imul bx */
            ii(0x1028_c3d6, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x1028_c3d8, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1028_c3da, 4); add(ax, memw[es, edi]);                 /* add ax, [es:edi] */
            ii(0x1028_c3de, 2); if(jno(0x1028_c3f2, 0x12)) goto l_0x1028_c3f2; /* jno 0x1028c3f2 */
            ii(0x1028_c3e0, 4); cmp(ax, 0);                             /* cmp ax, 0x0 */
            ii(0x1028_c3e4, 2); if(jl(0x1028_c3ed, 0x7)) goto l_0x1028_c3ed; /* jl 0x1028c3ed */
            ii(0x1028_c3e6, 5); mov(eax, 0x8000);                       /* mov eax, 0x8000 */
            ii(0x1028_c3eb, 2); jmp(0x1028_c3f2, 0x5); goto l_0x1028_c3f2; /* jmp 0x1028c3f2 */
        l_0x1028_c3ed:
            ii(0x1028_c3ed, 5); mov(eax, 0x7fff);                       /* mov eax, 0x7fff */
        l_0x1028_c3f2:
            ii(0x1028_c3f2, 4); mov(memw[es, edi], ax);                 /* mov [es:edi], ax */
            ii(0x1028_c3f6, 3); add(edi, 0x2);                          /* add edi, 0x2 */
            ii(0x1028_c3f9, 3); movzx(eax, memw[ds, esi]);              /* movzx eax, word [esi] */
            ii(0x1028_c3fc, 3); add(esi, 0x2);                          /* add esi, 0x2 */
            ii(0x1028_c3ff, 3); imul(bx);                               /* imul bx */
            ii(0x1028_c402, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x1028_c404, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1028_c406, 4); add(ax, memw[es, edi]);                 /* add ax, [es:edi] */
            ii(0x1028_c40a, 2); if(jno(0x1028_c41e, 0x12)) goto l_0x1028_c41e; /* jno 0x1028c41e */
            ii(0x1028_c40c, 4); cmp(ax, 0);                             /* cmp ax, 0x0 */
            ii(0x1028_c410, 2); if(jl(0x1028_c419, 0x7)) goto l_0x1028_c419; /* jl 0x1028c419 */
            ii(0x1028_c412, 5); mov(eax, 0x8000);                       /* mov eax, 0x8000 */
            ii(0x1028_c417, 2); jmp(0x1028_c41e, 0x5); goto l_0x1028_c41e; /* jmp 0x1028c41e */
        l_0x1028_c419:
            ii(0x1028_c419, 5); mov(eax, 0x7fff);                       /* mov eax, 0x7fff */
        l_0x1028_c41e:
            ii(0x1028_c41e, 4); mov(memw[es, edi], ax);                 /* mov [es:edi], ax */
            ii(0x1028_c422, 3); add(edi, 0x2);                          /* add edi, 0x2 */
            ii(0x1028_c425, 8); sub(memd[fs, 0x134c], 0x1);             /* sub dword [fs:0x134c], 0x1 */
            ii(0x1028_c42d, 6); if(jnz(0x1028_c3cd, -0x66)) goto l_0x1028_c3cd; /* jnz 0x1028c3cd */
        l_0x1028_c433:
            ii(0x1028_c433, 1); pop(esi);                               /* pop esi */
            ii(0x1028_c434, 1); pop(ds);                                /* pop ds */
            ii(0x1028_c435, 1); ret();                                  /* ret */
        }
    }
}
