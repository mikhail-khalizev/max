using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("5e7ef4b8-9189-49aa-ad39-60402de4b93f")]
        public void Method_1015_2b8c()
        {
            ii(0x1015_2b8c, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1015_2b91, 5); calld(Definitions.sys_check_available_stack_size, 0x131bc); /* call 0x10165d52 */
            ii(0x1015_2b96, 1); pushd(ebx);                             /* push ebx */
            ii(0x1015_2b97, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_2b98, 1); pushd(edx);                             /* push edx */
            ii(0x1015_2b99, 1); pushd(esi);                             /* push esi */
            ii(0x1015_2b9a, 1); pushd(edi);                             /* push edi */
            ii(0x1015_2b9b, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_2b9c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_2b9e, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1015_2ba4, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1015_2ba7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_2baa, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1015_2bad, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_2bb0, 3); cmp(eax, 0x27);                         /* cmp eax, 0x27 */
            ii(0x1015_2bb3, 2); if(jzd(0x1015_2bbb, 0x6)) goto l_0x1015_2bbb; /* jz 0x10152bbb */
            ii(0x1015_2bb5, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
            ii(0x1015_2bb9, 2); jmpd(0x1015_2bde, 0x23); goto l_0x1015_2bde; /* jmp 0x10152bde */
        l_0x1015_2bbb:
            ii(0x1015_2bbb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_2bbe, 7); mov(dx, memw_a32[ds, eax + 0xd5]);      /* mov dx, [eax+0xd5] */
            ii(0x1015_2bc5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_2bc8, 4); cmp(dx, memw_a32[ds, eax + 0x33]);      /* cmp dx, [eax+0x33] */
            ii(0x1015_2bcc, 2); if(jzd(0x1015_2bd4, 0x6)) goto l_0x1015_2bd4; /* jz 0x10152bd4 */
            ii(0x1015_2bce, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x1015_2bd2, 2); jmpd(0x1015_2bd8, 0x4); goto l_0x1015_2bd8; /* jmp 0x10152bd8 */
        l_0x1015_2bd4:
            ii(0x1015_2bd4, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
        l_0x1015_2bd8:
            ii(0x1015_2bd8, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x1015_2bdb, 3); mov(memb_a32[ss, ebp - 0x8], al);       /* mov [ebp-0x8], al */
        l_0x1015_2bde:
            ii(0x1015_2bde, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x1015_2be1, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_2be3, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_2be4, 1); popd(edi);                              /* pop edi */
            ii(0x1015_2be5, 1); popd(esi);                              /* pop esi */
            ii(0x1015_2be6, 1); popd(edx);                              /* pop edx */
            ii(0x1015_2be7, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_2be8, 1); popd(ebx);                              /* pop ebx */
            ii(0x1015_2be9, 1); retd(); return;                         /* ret */
        }
    }
}
