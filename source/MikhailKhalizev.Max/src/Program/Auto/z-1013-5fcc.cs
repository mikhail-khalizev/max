using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("212dcb04-f28e-4368-88fc-bb39aae58778")]
        public void Method_1013_5fcc()
        {
            ii(0x1013_5fcc, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1013_5fd1, 5); calld(Definitions.sys_check_available_stack_size, 0x2_fd7c); /* call 0x10165d52 */
            ii(0x1013_5fd6, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_5fd7, 1); pushd(esi);                             /* push esi */
            ii(0x1013_5fd8, 1); pushd(edi);                             /* push edi */
            ii(0x1013_5fd9, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_5fda, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_5fdc, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1013_5fe2, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_5fe5, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1013_5fe8, 3); mov(memd_a32[ss, ebp - 0xc], ebx);      /* mov [ebp-0xc], ebx */
            ii(0x1013_5feb, 4); movsx(ebx, memw_a32[ss, ebp - 0x4]);    /* movsx ebx, word [ebp-0x4] */
            ii(0x1013_5fef, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1013_5ff3, 5); mov(eax, 0x101c_3c4c);                  /* mov eax, 0x101c3c4c */
            ii(0x1013_5ff8, 5); calld(0x1010_65a2, -0x2_fa5b);          /* call 0x101065a2 */
            ii(0x1013_5ffd, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1013_5fff, 2); if(jzd(0x1013_6027, 0x26)) goto l_0x1013_6027; /* jz 0x10136027 */
        l_0x1013_6001:
            ii(0x1013_6001, 3); lea(ebx, ebp - 0x10);                   /* lea ebx, [ebp-0x10] */
            ii(0x1013_6004, 3); lea(edx, ebp - 0x14);                   /* lea edx, [ebp-0x14] */
            ii(0x1013_6007, 5); mov(eax, 0x101c_3c4c);                  /* mov eax, 0x101c3c4c */
            ii(0x1013_600c, 5); calld(0x1010_6615, -0x2_f9fc);          /* call 0x10106615 */
            ii(0x1013_6011, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1013_6013, 2); if(jzd(0x1013_6027, 0x12)) goto l_0x1013_6027; /* jz 0x10136027 */
            ii(0x1013_6015, 4); movsx(ebx, memw_a32[ss, ebp - 0x10]);   /* movsx ebx, word [ebp-0x10] */
            ii(0x1013_6019, 4); movsx(edx, memw_a32[ss, ebp - 0x14]);   /* movsx edx, word [ebp-0x14] */
            ii(0x1013_601d, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_6020, 5); calld(0x1013_5e8c, -0x199);             /* call 0x10135e8c */
            ii(0x1013_6025, 2); jmpd(0x1013_6001, -0x26); goto l_0x1013_6001; /* jmp 0x10136001 */
        l_0x1013_6027:
            ii(0x1013_6027, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_6029, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_602a, 1); popd(edi);                              /* pop edi */
            ii(0x1013_602b, 1); popd(esi);                              /* pop esi */
            ii(0x1013_602c, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_602d, 1); retd(); return;                         /* ret */
        }
    }
}
