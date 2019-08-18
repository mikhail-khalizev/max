using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_bc34-4dc2d")]
        public void Method_100c_bc34()
        {
            ii(0x100c_bc34, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100c_bc39, 5); calld(Definitions.sys_check_available_stack_size, 0x9_a114); /* call 0x10165d52 */
            ii(0x100c_bc3e, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_bc3f, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_bc40, 1); pushd(edx);                             /* push edx */
            ii(0x100c_bc41, 1); pushd(esi);                             /* push esi */
            ii(0x100c_bc42, 1); pushd(edi);                             /* push edi */
            ii(0x100c_bc43, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_bc44, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_bc46, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100c_bc4c, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100c_bc4f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_bc52, 5); calld(0x100c_bb8b, -0xcc);              /* call 0x100cbb8b */
            ii(0x100c_bc57, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_bc5a, 5); cmp(memw_a32[ss, ebp - 0x8], -0x1 /* 0xff */); /* cmp word [ebp-0x8], 0xffff */
            ii(0x100c_bc5f, 2); if(jzd(0x100c_bc6d, 0xc)) goto l_0x100c_bc6d; /* jz 0x100cbc6d */
            ii(0x100c_bc61, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x100c_bc65, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_bc68, 5); calld(0x100c_bc91, 0x24);               /* call 0x100cbc91 */
        l_0x100c_bc6d:
            ii(0x100c_bc6d, 5); cmp(memw_a32[ss, ebp - 0x8], 0x9);      /* cmp word [ebp-0x8], 0x9 */
            ii(0x100c_bc72, 2); if(jzd(0x100c_bc7b, 0x7)) goto l_0x100c_bc7b; /* jz 0x100cbc7b */
            ii(0x100c_bc74, 5); cmp(memw_a32[ss, ebp - 0x8], -0x1 /* 0xff */); /* cmp word [ebp-0x8], 0xffff */
            ii(0x100c_bc79, 2); if(jnzd(0x100c_bc88, 0xd)) goto l_0x100c_bc88; /* jnz 0x100cbc88 */
        l_0x100c_bc7b:
            ii(0x100c_bc7b, 5); mov(edx, 0x3f);                         /* mov edx, 0x3f */
            ii(0x100c_bc80, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_bc83, 5); calld(0x100c_bc91, 0x9);                /* call 0x100cbc91 */
        l_0x100c_bc88:
            ii(0x100c_bc88, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_bc8a, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_bc8b, 1); popd(edi);                              /* pop edi */
            ii(0x100c_bc8c, 1); popd(esi);                              /* pop esi */
            ii(0x100c_bc8d, 1); popd(edx);                              /* pop edx */
            ii(0x100c_bc8e, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_bc8f, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_bc90, 1); retd(); return;                         /* ret */
        }
    }
}
