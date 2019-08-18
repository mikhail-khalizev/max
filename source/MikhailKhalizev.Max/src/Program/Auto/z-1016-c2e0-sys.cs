using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0883cf22-bbb6-480a-9fd7-914897b0c0c0")]
        public void /* sys */ Method_1016_c2e0()
        {
            ii(0x1016_c2e0, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_c2e1, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_c2e2, 1); pushd(edx);                             /* push edx */
            ii(0x1016_c2e3, 1); pushd(ebp);                             /* push ebp */
            ii(0x1016_c2e4, 5); mov(eax, memd_a32[ds, 0x101c_fbd4]);    /* mov eax, [0x101cfbd4] */
            ii(0x1016_c2e9, 6); mov(edx, memd_a32[ds, 0x101c_fbfc]);    /* mov edx, [0x101cfbfc] */
            ii(0x1016_c2ef, 6); mov(ebx, memd_a32[ds, 0x1020_88e0]);    /* mov ebx, [0x102088e0] */
            ii(0x1016_c2f5, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1016_c2f7, 2); cmp(eax, ebx);                          /* cmp eax, ebx */
            ii(0x1016_c2f9, 2); if(jged(0x1016_c2ff, 0x4)) goto l_0x1016_c2ff; /* jge 0x1016c2ff */
            ii(0x1016_c2fb, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1016_c2fd, 2); jmpd(0x1016_c30b, 0xc); goto l_0x1016_c30b; /* jmp 0x1016c30b */
        l_0x1016_c2ff:
            ii(0x1016_c2ff, 6); mov(ecx, memd_a32[ds, 0x1020_88e8]);    /* mov ecx, [0x102088e8] */
            ii(0x1016_c305, 2); cmp(eax, ecx);                          /* cmp eax, ecx */
            ii(0x1016_c307, 2); if(jled(0x1016_c312, 0x9)) goto l_0x1016_c312; /* jle 0x1016c312 */
            ii(0x1016_c309, 2); mov(eax, ecx);                          /* mov eax, ecx */
        l_0x1016_c30b:
            ii(0x1016_c30b, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1016_c30d, 5); mov(memd_a32[ds, 0x101c_fbd4], eax);    /* mov [0x101cfbd4], eax */
        l_0x1016_c312:
            ii(0x1016_c312, 5); mov(eax, memd_a32[ds, 0x101c_fbd0]);    /* mov eax, [0x101cfbd0] */
            ii(0x1016_c317, 6); mov(ebp, memd_a32[ds, 0x101c_fbf8]);    /* mov ebp, [0x101cfbf8] */
            ii(0x1016_c31d, 6); mov(edx, memd_a32[ds, 0x1020_88e4]);    /* mov edx, [0x102088e4] */
            ii(0x1016_c323, 2); add(eax, ebp);                          /* add eax, ebp */
            ii(0x1016_c325, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x1016_c327, 2); if(jged(0x1016_c32d, 0x4)) goto l_0x1016_c32d; /* jge 0x1016c32d */
            ii(0x1016_c329, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1016_c32b, 2); jmpd(0x1016_c339, 0xc); goto l_0x1016_c339; /* jmp 0x1016c339 */
        l_0x1016_c32d:
            ii(0x1016_c32d, 6); mov(ebx, memd_a32[ds, 0x1020_88ec]);    /* mov ebx, [0x102088ec] */
            ii(0x1016_c333, 2); cmp(eax, ebx);                          /* cmp eax, ebx */
            ii(0x1016_c335, 2); if(jled(0x1016_c340, 0x9)) goto l_0x1016_c340; /* jle 0x1016c340 */
            ii(0x1016_c337, 2); mov(eax, ebx);                          /* mov eax, ebx */
        l_0x1016_c339:
            ii(0x1016_c339, 2); sub(eax, ebp);                          /* sub eax, ebp */
            ii(0x1016_c33b, 5); mov(memd_a32[ds, 0x101c_fbd0], eax);    /* mov [0x101cfbd0], eax */
        l_0x1016_c340:
            ii(0x1016_c340, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_c341, 1); popd(edx);                              /* pop edx */
            ii(0x1016_c342, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_c343, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_c344, 1); retd(); return;                         /* ret */
        }
    }
}
