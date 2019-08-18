using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_5ca0-8c355a69")]
        public void /* sys */ Method_1019_5ca0()
        {
            ii(0x1019_5ca0, 2); test(ecx, ecx);                         /* test ecx, ecx */
            ii(0x1019_5ca2, 2); if(jnzd(0x1019_5ca9, 0x5)) goto l_0x1019_5ca9; /* jnz 0x10195ca9 */
            ii(0x1019_5ca4, 3); mov(memd_a32[ss, esp], ecx);            /* mov [esp], ecx */
            ii(0x1019_5ca7, 2); jmpd(0x1019_5cd4, 0x2b); goto l_0x1019_5cd4; /* jmp 0x10195cd4 */
        l_0x1019_5ca9:
            ii(0x1019_5ca9, 3); cmp(ecx, memd_a32[ds, esi + 0x9]);      /* cmp ecx, [esi+0x9] */
            ii(0x1019_5cac, 2); if(jzd(0x1019_5cd4, 0x26)) goto l_0x1019_5cd4; /* jz 0x10195cd4 */
            ii(0x1019_5cae, 2); mov(edx, ecx);                          /* mov edx, ecx */
            ii(0x1019_5cb0, 3); mov(eax, memd_a32[ds, edi + 0x4]);      /* mov eax, [edi+0x4] */
            ii(0x1019_5cb3, 5); calld(/* sys */ 0x1019_5c28, -0x90);    /* call 0x10195c28 */
            ii(0x1019_5cb8, 3); mov(memd_a32[ss, esp], eax);            /* mov [esp], eax */
            ii(0x1019_5cbb, 3); cmp(memd_a32[ds, eax], 0);              /* cmp dword [eax], 0x0 */
            ii(0x1019_5cbe, 2); if(jnzd(0x1019_5cd4, 0x14)) goto l_0x1019_5cd4; /* jnz 0x10195cd4 */
            ii(0x1019_5cc0, 3); mov(ebx, memd_a32[ds, eax + 0x4]);      /* mov ebx, [eax+0x4] */
            ii(0x1019_5cc3, 3); mov(ax, memw_a32[ds, ebx]);             /* mov ax, [ebx] */
            ii(0x1019_5cc6, 4); cmp(ax, 0x1);                           /* cmp ax, 0x1 */
            ii(0x1019_5cca, 2); if(jbd(0x1019_5cd4, 0x8)) goto l_0x1019_5cd4; /* jb 0x10195cd4 */
            ii(0x1019_5ccc, 2); if(jbed_func(0x1019_5ce4, 0x16)) return; /* jbe 0x10195ce4 */
            ii(0x1019_5cce, 4); cmp(ax, 0x5);                           /* cmp ax, 0x5 */
            ii(0x1019_5cd2, 2); if(jzd_func(0x1019_5ce9, 0x15)) return; /* jz 0x10195ce9 */
        l_0x1019_5cd4:
            ii(0x1019_5cd4, 3); mov(memd_a32[ds, esi + 0x4], ecx);      /* mov [esi+0x4], ecx */
        }
    }
}
