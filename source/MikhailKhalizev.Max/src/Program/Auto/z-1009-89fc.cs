using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_89fc-752b363b")]
        public void Method_1009_89fc()
        {
            ii(0x1009_89fc, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1009_8a01, 5); calld(Definitions.sys_check_available_stack_size, 0xc_d34c); /* call 0x10165d52 */
            ii(0x1009_8a06, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_8a07, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_8a08, 1); pushd(edx);                             /* push edx */
            ii(0x1009_8a09, 1); pushd(esi);                             /* push esi */
            ii(0x1009_8a0a, 1); pushd(edi);                             /* push edi */
            ii(0x1009_8a0b, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_8a0c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_8a0e, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1009_8a14, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1009_8a17, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_8a1a, 3); mov(eax, memd_a32[ds, eax + 0x1a]);     /* mov eax, [eax+0x1a] */
            ii(0x1009_8a1d, 3); sar(eax, 0x18);                         /* sar eax, 0x18 */
            ii(0x1009_8a20, 3); cmp(eax, 0x3);                          /* cmp eax, 0x3 */
            ii(0x1009_8a23, 2); if(jld(0x1009_8a2b, 0x6)) goto l_0x1009_8a2b; /* jl 0x10098a2b */
            ii(0x1009_8a25, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
            ii(0x1009_8a29, 2); jmpd(0x1009_8a2f, 0x4); goto l_0x1009_8a2f; /* jmp 0x10098a2f */
        l_0x1009_8a2b:
            ii(0x1009_8a2b, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
        l_0x1009_8a2f:
            ii(0x1009_8a2f, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x1009_8a32, 3); mov(memb_a32[ss, ebp - 0xc], al);       /* mov [ebp-0xc], al */
            ii(0x1009_8a35, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x1009_8a38, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_8a3a, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_8a3b, 1); popd(edi);                              /* pop edi */
            ii(0x1009_8a3c, 1); popd(esi);                              /* pop esi */
            ii(0x1009_8a3d, 1); popd(edx);                              /* pop edx */
            ii(0x1009_8a3e, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_8a3f, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_8a40, 1); retd(); return;                         /* ret */
        }
    }
}
