using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("8a2f74ea-62d6-40d6-aabb-0514586217bd")]
        public void Method_1012_04dc()
        {
            ii(0x1012_04dc, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1012_04e1, 5); calld(Definitions.sys_check_available_stack_size, 0x4586c); /* call 0x10165d52 */
            ii(0x1012_04e6, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_04e7, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_04e8, 1); pushd(esi);                             /* push esi */
            ii(0x1012_04e9, 1); pushd(edi);                             /* push edi */
            ii(0x1012_04ea, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_04eb, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_04ed, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1012_04f3, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1012_04f6, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1012_04f9, 7); test(memd_a32[ss, ebp - 0x4], 0x4);     /* test dword [ebp-0x4], 0x4 */
            ii(0x1012_0500, 2); if(jzd(0x1012_0516, 0x14)) goto l_0x1012_0516; /* jz 0x10120516 */
            ii(0x1012_0502, 5); mov(edx, 0x101b_6830);                  /* mov edx, 0x101b6830 */
            ii(0x1012_0507, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_050a, 5); calld(Definitions.sys_call_dtor_arr, 0x45aa9); /* call 0x10165fb8 */
            ii(0x1012_050f, 5); calld(Definitions.sys_delete_arr, 0x45ac4); /* call 0x10165fd8 */
            ii(0x1012_0514, 2); jmpd(0x1012_0537, 0x21); goto l_0x1012_0537; /* jmp 0x10120537 */
        l_0x1012_0516:
            ii(0x1012_0516, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1012_051b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_051e, 5); calld(0x100c_d916, -0x52c0d);           /* call 0x100cd916 */
            ii(0x1012_0523, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1012_0526, 7); test(memd_a32[ss, ebp - 0x4], 0x2);     /* test dword [ebp-0x4], 0x2 */
            ii(0x1012_052d, 2); if(jzd(0x1012_0537, 0x8)) goto l_0x1012_0537; /* jz 0x10120537 */
            ii(0x1012_052f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_0532, 5); calld(Definitions.sys_delete, 0x45a2d); /* call 0x10165f64 */
        l_0x1012_0537:
            ii(0x1012_0537, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_053a, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1012_053d, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_0540, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_0542, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_0543, 1); popd(edi);                              /* pop edi */
            ii(0x1012_0544, 1); popd(esi);                              /* pop esi */
            ii(0x1012_0545, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_0546, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_0547, 1); retd(); return;                         /* ret */
        }
    }
}
