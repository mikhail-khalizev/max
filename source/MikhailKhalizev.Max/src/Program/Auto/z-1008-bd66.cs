using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_bd66-b5183a4e")]
        public void Method_1008_bd66()
        {
            ii(0x1008_bd66, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1008_bd6b, 5); calld(Definitions.sys_check_available_stack_size, 0xd_9fe2); /* call 0x10165d52 */
            ii(0x1008_bd70, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_bd71, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_bd72, 1); pushd(edx);                             /* push edx */
            ii(0x1008_bd73, 1); pushd(esi);                             /* push esi */
            ii(0x1008_bd74, 1); pushd(edi);                             /* push edi */
            ii(0x1008_bd75, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_bd76, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_bd78, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1008_bd7e, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1008_bd81, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_bd83, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_bd86, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x1008_bd89, 5); calld(0x1013_ad71, 0xa_efe3);           /* call 0x1013ad71 */
            ii(0x1008_bd8e, 2); test(al, al);                           /* test al, al */
            ii(0x1008_bd90, 2); if(jzd(0x1008_bdb1, 0x1f)) goto l_0x1008_bdb1; /* jz 0x1008bdb1 */
            ii(0x1008_bd92, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_bd95, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x1008_bd98, 5); calld(0x1008_af28, -0xe75);             /* call 0x1008af28 */
            ii(0x1008_bd9d, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1008_bda0, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_bda3, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x1008_bda6, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_bda9, 3); calld_abs(memd_a32[ds, edx + 0x14]);    /* call dword [edx+0x14] */
            ii(0x1008_bdac, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_bdaf, 2); jmpd(0x1008_bdbb, 0xa); goto l_0x1008_bdbb; /* jmp 0x1008bdbb */
        l_0x1008_bdb1:
            ii(0x1008_bdb1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_bdb4, 4); mov(ax, memw_a32[ds, eax + 0xd]);       /* mov ax, [eax+0xd] */
            ii(0x1008_bdb8, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
        l_0x1008_bdbb:
            ii(0x1008_bdbb, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_bdbe, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_bdc0, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_bdc1, 1); popd(edi);                              /* pop edi */
            ii(0x1008_bdc2, 1); popd(esi);                              /* pop esi */
            ii(0x1008_bdc3, 1); popd(edx);                              /* pop edx */
            ii(0x1008_bdc4, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_bdc5, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_bdc6, 1); retd();                                 /* ret */
        }
    }
}
