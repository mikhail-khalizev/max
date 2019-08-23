using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_ee25-e1afbdc0")]
        public void Method_1007_ee25()
        {
            ii(0x1007_ee25, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1007_ee2a, 5); calld(Definitions.sys_check_available_stack_size, 0xe_6f23); /* call 0x10165d52 */
            ii(0x1007_ee2f, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_ee30, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_ee31, 1); pushd(esi);                             /* push esi */
            ii(0x1007_ee32, 1); pushd(edi);                             /* push edi */
            ii(0x1007_ee33, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_ee34, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_ee36, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1007_ee3c, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1007_ee3f, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1007_ee42, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
            ii(0x1007_ee49, 2); jmpd(0x1007_ee51, 0x6); goto l_0x1007_ee51; /* jmp 0x1007ee51 */
        l_0x1007_ee4b:
            ii(0x1007_ee4b, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_ee4e, 3); inc(memd_a32[ss, ebp - 0xc]);           /* inc dword [ebp-0xc] */
        l_0x1007_ee51:
            ii(0x1007_ee51, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1007_ee55, 3); cmp(eax, 0x8);                          /* cmp eax, 0x8 */
            ii(0x1007_ee58, 2); if(jged(0x1007_ee75, 0x1b)) goto l_0x1007_ee75; /* jge 0x1007ee75 */
            ii(0x1007_ee5a, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1007_ee5d, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1007_ee61, 3); imul(eax, eax, 0x16);                   /* imul eax, eax, 0x16 */
            ii(0x1007_ee64, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x1007_ee67, 3); add(ebx, 0x21);                         /* add ebx, 0x21 */
            ii(0x1007_ee6a, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1007_ee6c, 5); calld(0x1007_d339, -0x1b38);            /* call 0x1007d339 */
            ii(0x1007_ee71, 2); test(al, al);                           /* test al, al */
            ii(0x1007_ee73, 2); if(jzd(0x1007_ee4b, -0x2a)) goto l_0x1007_ee4b; /* jz 0x1007ee4b */
        l_0x1007_ee75:
            ii(0x1007_ee75, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_ee77, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_ee78, 1); popd(edi);                              /* pop edi */
            ii(0x1007_ee79, 1); popd(esi);                              /* pop esi */
            ii(0x1007_ee7a, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_ee7b, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_ee7c, 1); retd();                                 /* ret */
        }
    }
}
