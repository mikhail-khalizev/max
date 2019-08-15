using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("e7c20a91-ebfa-49ca-a015-8dcf36237f19")]
        public void Method_100a_bc54()
        {
            ii(0x100a_bc54, 5); pushd(0x4c);                            /* push 0x4c */
            ii(0x100a_bc59, 5); calld(Definitions.sys_check_available_stack_size, 0xb_a0f4); /* call 0x10165d52 */
            ii(0x100a_bc5e, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_bc5f, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_bc60, 1); pushd(esi);                             /* push esi */
            ii(0x100a_bc61, 1); pushd(edi);                             /* push edi */
            ii(0x100a_bc62, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_bc63, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_bc65, 6); sub(esp, 0x24);                         /* sub esp, 0x24 */
            ii(0x100a_bc6b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_bc6e, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100a_bc71, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_bc73, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_bc76, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_bc79, 5); calld(0x1013_ad11, 0x8_f093);           /* call 0x1013ad11 */
            ii(0x100a_bc7e, 2); test(al, al);                           /* test al, al */
            ii(0x100a_bc80, 2); if(jzd(0x100a_bc91, 0xf)) goto l_0x100a_bc91; /* jz 0x100abc91 */
            ii(0x100a_bc82, 5); mov(edx, StringDefinitions.FindPathFinished); /* mov edx, 0x101a0da4 */
            ii(0x100a_bc87, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_bc8a, 5); calld(Definitions.sys_strcat, 0xb_a2a2); /* call 0x10165f31 */
            ii(0x100a_bc8f, 2); jmpd(0x100a_bcda, 0x49); goto l_0x100a_bcda; /* jmp 0x100abcda */
        l_0x100a_bc91:
            ii(0x100a_bc91, 3); lea(edx, ebp - 0x10);                   /* lea edx, [ebp-0x10] */
            ii(0x100a_bc94, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_bc97, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_bc9a, 5); calld(0x100b_7f18, 0xc279);             /* call 0x100b7f18 */
            ii(0x100a_bc9f, 5); calld(0x100b_808c, 0xc3e8);             /* call 0x100b808c */
            ii(0x100a_bca4, 5); mov(edx, StringDefinitions.FindPathTo); /* mov edx, 0x101a0db9 */
            ii(0x100a_bca9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_bcac, 5); calld(Definitions.sys_strcpy, 0xb_a21e); /* call 0x10165ecf */
            ii(0x100a_bcb1, 4); movsx(eax, memw_a32[ss, ebp - 0xe]);    /* movsx eax, word [ebp-0xe] */
            ii(0x100a_bcb5, 1); inc(eax);                               /* inc eax */
            ii(0x100a_bcb6, 1); pushd(eax);                             /* push eax */
            ii(0x100a_bcb7, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x100a_bcbb, 1); inc(eax);                               /* inc eax */
            ii(0x100a_bcbc, 1); pushd(eax);                             /* push eax */
            ii(0x100a_bcbd, 5); mov(eax, StringDefinitions.II5);        /* mov eax, 0x101a0dc7 */
            ii(0x100a_bcc2, 1); pushd(eax);                             /* push eax */
            ii(0x100a_bcc3, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100a_bcc6, 1); pushd(eax);                             /* push eax */
            ii(0x100a_bcc7, 5); calld(Definitions.sys_sprintf, 0xb_a235); /* call 0x10165f01 */
            ii(0x100a_bccc, 3); add(esp, 0x10);                         /* add esp, 0x10 */
            ii(0x100a_bccf, 3); lea(edx, ebp - 0x24);                   /* lea edx, [ebp-0x24] */
            ii(0x100a_bcd2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_bcd5, 5); calld(Definitions.sys_strcat, 0xb_a257); /* call 0x10165f31 */
        l_0x100a_bcda:
            ii(0x100a_bcda, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_bcdd, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_bce0, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_bce3, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_bce5, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_bce6, 1); popd(edi);                              /* pop edi */
            ii(0x100a_bce7, 1); popd(esi);                              /* pop esi */
            ii(0x100a_bce8, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_bce9, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_bcea, 1); retd(); return;                         /* ret */
        }
    }
}
