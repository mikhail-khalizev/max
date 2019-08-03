using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("83455fc5-7335-4d85-a69f-b9bae553d211")]
        public void Method_1010_9a84()
        {
            ii(0x1010_9a84, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1010_9a89, 5); calld(Definitions.sys_check_available_stack_size, 0x5c2c4); /* call 0x10165d52 */
            ii(0x1010_9a8e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_9a8f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_9a90, 1); pushd(edx);                             /* push edx */
            ii(0x1010_9a91, 1); pushd(esi);                             /* push esi */
            ii(0x1010_9a92, 1); pushd(edi);                             /* push edi */
            ii(0x1010_9a93, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_9a94, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_9a96, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1010_9a9c, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1010_9a9f, 5); mov(eax, memd_a32[ds, 0x101c_4de8]);    /* mov eax, [0x101c4de8] */
            ii(0x1010_9aa4, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_9aa7, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_9aa9, 2); if(jzd(0x1010_9afc, 0x51)) goto l_0x1010_9afc; /* jz 0x10109afc */
            ii(0x1010_9aab, 6); mov(ax, memw_a32[ds, 0x101c_4dea]);     /* mov ax, [0x101c4dea] */
            ii(0x1010_9ab1, 7); sub(ax, memw_a32[ds, 0x101c_4de8]);     /* sub ax, [0x101c4de8] */
            ii(0x1010_9ab8, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1010_9abb, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1010_9abf, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_9ac1, 2); if(jged(0x1010_9aca, 0x7)) goto l_0x1010_9aca; /* jge 0x10109aca */
            ii(0x1010_9ac3, 7); mov(memd_a32[ss, ebp - 0x8], 0);        /* mov dword [ebp-0x8], 0x0 */
        l_0x1010_9aca:
            ii(0x1010_9aca, 5); calld(0x1014_82f4, 0x3e825);            /* call 0x101482f4 */
            ii(0x1010_9acf, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1010_9ad2, 7); dec(memw_a32[ds, 0x101c_4dea]);         /* dec word [0x101c4dea] */
            ii(0x1010_9ad9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_9adc, 5); calld(0x1010_96e0, -0x401);             /* call 0x101096e0 */
        l_0x1010_9ae1:
            ii(0x1010_9ae1, 5); calld(0x1014_82f4, 0x3e80e);            /* call 0x101482f4 */
            ii(0x1010_9ae6, 3); sub(eax, memd_a32[ss, ebp - 0xc]);      /* sub eax, [ebp-0xc] */
            ii(0x1010_9ae9, 5); cmp(eax, 0x308c);                       /* cmp eax, 0x308c */
            ii(0x1010_9aee, 2); if(jbd(0x1010_9ae1, -0xf)) goto l_0x1010_9ae1; /* jb 0x10109ae1 */
            ii(0x1010_9af0, 6); mov(ax, memw_a32[ds, 0x101c_4dea]);     /* mov ax, [0x101c4dea] */
            ii(0x1010_9af6, 4); cmp(ax, memw_a32[ss, ebp - 0x8]);       /* cmp ax, [ebp-0x8] */
            ii(0x1010_9afa, 2); if(jnzd(0x1010_9aca, -0x32)) goto l_0x1010_9aca; /* jnz 0x10109aca */
        l_0x1010_9afc:
            ii(0x1010_9afc, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_9afe, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_9aff, 1); popd(edi);                              /* pop edi */
            ii(0x1010_9b00, 1); popd(esi);                              /* pop esi */
            ii(0x1010_9b01, 1); popd(edx);                              /* pop edx */
            ii(0x1010_9b02, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_9b03, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_9b04, 1); retd(); return;                         /* ret */
        }
    }
}