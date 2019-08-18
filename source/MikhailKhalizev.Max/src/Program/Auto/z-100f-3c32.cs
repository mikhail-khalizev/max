using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("1fc47c25-bf1c-4d58-82db-55430a770259")]
        public void Method_100f_3c32()
        {
            ii(0x100f_3c32, 5); pushd(0x17c);                           /* push 0x17c */
            ii(0x100f_3c37, 5); calld(Definitions.sys_check_available_stack_size, 0x7_2116); /* call 0x10165d52 */
            ii(0x100f_3c3c, 1); pushd(ebx);                             /* push ebx */
            ii(0x100f_3c3d, 1); pushd(ecx);                             /* push ecx */
            ii(0x100f_3c3e, 1); pushd(esi);                             /* push esi */
            ii(0x100f_3c3f, 1); pushd(edi);                             /* push edi */
            ii(0x100f_3c40, 1); pushd(ebp);                             /* push ebp */
            ii(0x100f_3c41, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_3c43, 6); sub(esp, 0x158);                        /* sub esp, 0x158 */
            ii(0x100f_3c49, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100f_3c4c, 3); mov(memb_a32[ss, ebp - 0x4], dl);       /* mov [ebp-0x4], dl */
            ii(0x100f_3c4f, 7); mov(memd_a32[ss, ebp - 0x10], 0xffff_ffff); /* mov dword [ebp-0x10], 0xffffffff */
            ii(0x100f_3c56, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100f_3c59, 5); mov(eax, 0x101c_38b4);                  /* mov eax, 0x101c38b4 */
            ii(0x100f_3c5e, 5); calld(0x1007_6630, -0x7_d633);          /* call 0x10076630 */
            ii(0x100f_3c63, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100f_3c66, 4); mov(ax, memw_a32[ds, eax + 0x1a]);      /* mov ax, [eax+0x1a] */
            ii(0x100f_3c6a, 6); mov(memw_a32[ds, 0x101c_38b8], ax);     /* mov [0x101c38b8], ax */
            ii(0x100f_3c70, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100f_3c73, 4); mov(ax, memw_a32[ds, eax + 0x1c]);      /* mov ax, [eax+0x1c] */
            ii(0x100f_3c77, 6); mov(memw_a32[ds, 0x101c_38ba], ax);     /* mov [0x101c38ba], ax */
            ii(0x100f_3c7d, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x100f_3c80, 3); mov(memb_a32[ss, ebp - 0xc], al);       /* mov [ebp-0xc], al */
            ii(0x100f_3c83, 5); if(jmpd_func(0x100f_3ec0, 0x238)) return; /* jmp 0x100f3ec0 */
        }
    }
}
