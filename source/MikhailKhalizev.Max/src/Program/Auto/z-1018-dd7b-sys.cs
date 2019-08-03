using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("971d252e-edb9-44ec-b6ef-f479d97074bb")]
        public void /* sys */ Method_1018_dd7b()
        {
            ii(0x1018_dd7b, 1); pushd(ebp);                             /* push ebp */
            ii(0x1018_dd7c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1018_dd7e, 1); pushd(esi);                             /* push esi */
            ii(0x1018_dd7f, 1); pushd(edi);                             /* push edi */
            ii(0x1018_dd80, 1); pushd(ebx);                             /* push ebx */
            ii(0x1018_dd81, 3); mov(ecx, memd_a32[ss, ebp + 0x10]);     /* mov ecx, [ebp+0x10] */
            ii(0x1018_dd84, 2); shr(ecx, 0x1);                          /* shr ecx, 1 */
            ii(0x1018_dd86, 2); if(jzd(0x1018_ddb5, 0x2d)) goto l_0x1018_ddb5; /* jz 0x1018ddb5 */
            ii(0x1018_dd88, 3); mov(esi, memd_a32[ss, ebp + 0xc]);      /* mov esi, [ebp+0xc] */
            ii(0x1018_dd8b, 3); mov(edi, memd_a32[ss, ebp + 0x8]);      /* mov edi, [ebp+0x8] */
            ii(0x1018_dd8e, 3); mov(ax, memw_a32[ds, esi]);             /* mov ax, [esi] */
            ii(0x1018_dd91, 3); add(esi, 0x2);                          /* add esi, 0x2 */
            ii(0x1018_dd94, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1018_dd96, 3); mov(memw_a32[ds, edi], ax);             /* mov [edi], ax */
            ii(0x1018_dd99, 3); add(edi, 0x2);                          /* add edi, 0x2 */
            ii(0x1018_dd9c, 1); dec(ecx);                               /* dec ecx */
            ii(0x1018_dd9d, 2); if(jzd(0x1018_ddb5, 0x16)) goto l_0x1018_ddb5; /* jz 0x1018ddb5 */
        l_0x1018_dd9f:
            ii(0x1018_dd9f, 2); mov(bl, memb_a32[ds, esi]);             /* mov bl, [esi] */
            ii(0x1018_dda1, 3); add(esi, 0x1);                          /* add esi, 0x1 */
            ii(0x1018_dda4, 8); add(ax, memw_a32[ds, ebx * 2 + 0x101b_e218]); /* add ax, [ebx*2+0x101be218] */
            ii(0x1018_ddac, 3); mov(memw_a32[ds, edi], ax);             /* mov [edi], ax */
            ii(0x1018_ddaf, 3); add(edi, 0x2);                          /* add edi, 0x2 */
            ii(0x1018_ddb2, 1); dec(ecx);                               /* dec ecx */
            ii(0x1018_ddb3, 2); if(jnzd(0x1018_dd9f, -0x16)) goto l_0x1018_dd9f; /* jnz 0x1018dd9f */
        l_0x1018_ddb5:
            ii(0x1018_ddb5, 1); popd(ebx);                              /* pop ebx */
            ii(0x1018_ddb6, 1); popd(edi);                              /* pop edi */
            ii(0x1018_ddb7, 1); popd(esi);                              /* pop esi */
            ii(0x1018_ddb8, 1); leaved();                               /* leave */
            ii(0x1018_ddb9, 1); retd(); return;                         /* ret */
        }
    }
}
