using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_e110-af421572")]
        public void Method_1007_e110()
        {
            ii(0x1007_e110, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1007_e115, 5); calld(Definitions.sys_check_available_stack_size, 0xe_7c38); /* call 0x10165d52 */
            ii(0x1007_e11a, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_e11b, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_e11c, 1); pushd(edx);                             /* push edx */
            ii(0x1007_e11d, 1); pushd(esi);                             /* push esi */
            ii(0x1007_e11e, 1); pushd(edi);                             /* push edi */
            ii(0x1007_e11f, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_e120, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_e122, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1007_e128, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1007_e12b, 7); mov(memd_a32[ss, ebp - 0x8], 0);        /* mov dword [ebp-0x8], 0x0 */
            ii(0x1007_e132, 2); jmpd(0x1007_e13a, 0x6); goto l_0x1007_e13a; /* jmp 0x1007e13a */
        l_0x1007_e134:
            ii(0x1007_e134, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_e137, 3); inc(memd_a32[ss, ebp - 0x8]);           /* inc dword [ebp-0x8] */
        l_0x1007_e13a:
            ii(0x1007_e13a, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1007_e13e, 3); cmp(eax, 0x8);                          /* cmp eax, 0x8 */
            ii(0x1007_e141, 2); if(jged(0x1007_e159, 0x16)) goto l_0x1007_e159; /* jge 0x1007e159 */
            ii(0x1007_e143, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1007_e147, 3); imul(edx, eax, 0x16);                   /* imul edx, eax, 0x16 */
            ii(0x1007_e14a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_e14d, 3); add(eax, 0x21);                         /* add eax, 0x21 */
            ii(0x1007_e150, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1007_e152, 5); calld(0x1007_d1d3, -0xf84);             /* call 0x1007d1d3 */
            ii(0x1007_e157, 2); jmpd(0x1007_e134, -0x25); goto l_0x1007_e134; /* jmp 0x1007e134 */
        l_0x1007_e159:
            ii(0x1007_e159, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_e15b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_e15e, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x1007_e161, 5); calld(0x1008_afe4, 0xce7e);             /* call 0x1008afe4 */
            ii(0x1007_e166, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1007_e169, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1007_e16e, 5); calld(0x100a_5e27, 0x2_7cb4);           /* call 0x100a5e27 */
            ii(0x1007_e173, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_e175, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_e176, 1); popd(edi);                              /* pop edi */
            ii(0x1007_e177, 1); popd(esi);                              /* pop esi */
            ii(0x1007_e178, 1); popd(edx);                              /* pop edx */
            ii(0x1007_e179, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_e17a, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_e17b, 1); retd();                                 /* ret */
        }
    }
}
