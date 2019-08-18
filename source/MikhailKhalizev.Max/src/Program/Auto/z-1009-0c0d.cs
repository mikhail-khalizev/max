using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("4d815e58-eaef-4a8e-a306-31c1df9cc3d8")]
        public void Method_1009_0c0d()
        {
            ii(0x1009_0c0d, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1009_0c12, 5); calld(Definitions.sys_check_available_stack_size, 0xd_513b); /* call 0x10165d52 */
            ii(0x1009_0c17, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_0c18, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_0c19, 1); pushd(esi);                             /* push esi */
            ii(0x1009_0c1a, 1); pushd(edi);                             /* push edi */
            ii(0x1009_0c1b, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_0c1c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_0c1e, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1009_0c24, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_0c27, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1009_0c2a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_0c2d, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1009_0c30, 6); mov(ax, memw_a32[ds, 0x101c_8172]);     /* mov ax, [0x101c8172] */
            ii(0x1009_0c36, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
        l_0x1009_0c39:
            ii(0x1009_0c39, 3); dec(memd_a32[ss, ebp - 0xc]);           /* dec dword [ebp-0xc] */
            ii(0x1009_0c3c, 5); cmp(memw_a32[ss, ebp - 0xc], -0x1 /* 0xff */); /* cmp word [ebp-0xc], 0xffff */
            ii(0x1009_0c41, 2); if(jzd(0x1009_0c53, 0x10)) goto l_0x1009_0c53; /* jz 0x10090c53 */
            ii(0x1009_0c43, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_0c46, 4); add(memd_a32[ss, ebp - 0x10], 0x4);     /* add dword [ebp-0x10], 0x4 */
            ii(0x1009_0c4a, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1009_0c4c, 5); calld(Definitions.sys_delete, 0xd_5313); /* call 0x10165f64 */
            ii(0x1009_0c51, 2); jmpd(0x1009_0c39, -0x1a); goto l_0x1009_0c39; /* jmp 0x10090c39 */
        l_0x1009_0c53:
            ii(0x1009_0c53, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_0c56, 5); calld(Definitions.sys_delete, 0xd_5309); /* call 0x10165f64 */
            ii(0x1009_0c5b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_0c5d, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_0c5e, 1); popd(edi);                              /* pop edi */
            ii(0x1009_0c5f, 1); popd(esi);                              /* pop esi */
            ii(0x1009_0c60, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_0c61, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_0c62, 1); retd(); return;                         /* ret */
        }
    }
}
