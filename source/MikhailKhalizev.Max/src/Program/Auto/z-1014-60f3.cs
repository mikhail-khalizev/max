using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_60f3-ecb864bb")]
        public void Method_1014_60f3()
        {
            ii(0x1014_60f3, 5); push(0x38);                             /* push 0x38 */
            ii(0x1014_60f8, 5); call(Definitions.sys_check_available_stack_size, 0x1_fc55); /* call 0x10165d52 */
            ii(0x1014_60fd, 1); push(ecx);                              /* push ecx */
            ii(0x1014_60fe, 1); push(esi);                              /* push esi */
            ii(0x1014_60ff, 1); push(edi);                              /* push edi */
            ii(0x1014_6100, 1); push(ebp);                              /* push ebp */
            ii(0x1014_6101, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_6103, 6); sub(esp, 0x24);                         /* sub esp, 0x24 */
            ii(0x1014_6109, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1014_610c, 3); mov(memd[ss, ebp - 8], edx);            /* mov [ebp-0x8], edx */
            ii(0x1014_610f, 3); mov(memd[ss, ebp - 4], ebx);            /* mov [ebp-0x4], ebx */
            ii(0x1014_6112, 4); or(memb[ss, ebp - 16], 1);              /* or byte [ebp-0x10], 0x1 */
            ii(0x1014_6116, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x1014_6119, 5); call(Definitions.my_string_ctor, -0x4636); /* call 0x10141ae8 */
            ii(0x1014_611e, 3); mov(memd[ss, ebp - 24], eax);           /* mov [ebp-0x18], eax */
            ii(0x1014_6121, 4); and(memb[ss, ebp - 16], -2 /* 0xfe */); /* and byte [ebp-0x10], 0xfe */
            ii(0x1014_6125, 3); mov(ebx, memd[ss, ebp - 4]);            /* mov ebx, [ebp-0x4] */
            ii(0x1014_6128, 3); lea(edx, memd[ss, ebp - 20]);           /* lea edx, [ebp-0x14] */
            ii(0x1014_612b, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1014_612e, 5); call(0x1014_630a, 0x1d7);               /* call 0x1014630a */
            ii(0x1014_6133, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_6135, 3); lea(eax, memd[ss, ebp - 20]);           /* lea eax, [ebp-0x14] */
            ii(0x1014_6138, 5); call(0x1013_ad71, -0xb3cc);             /* call 0x1013ad71 */
            ii(0x1014_613d, 2); test(al, al);                           /* test al, al */
            ii(0x1014_613f, 2); if(jz(0x1014_616f, 0x2e)) goto l_0x1014_616f; /* jz 0x1014616f */
            ii(0x1014_6141, 3); lea(eax, memd[ss, ebp - 20]);           /* lea eax, [ebp-0x14] */
            ii(0x1014_6144, 5); call(0x100e_0760, -0x6_59e9);           /* call 0x100e0760 */
            ii(0x1014_6149, 3); mov(memd[ss, ebp - 32], eax);           /* mov [ebp-0x20], eax */
            ii(0x1014_614c, 3); mov(eax, memd[ss, ebp - 32]);           /* mov eax, [ebp-0x20] */
            ii(0x1014_614f, 3); mov(ebx, memd[ds, eax + 2]);            /* mov ebx, [eax+0x2] */
            ii(0x1014_6152, 3); lea(edx, memd[ss, ebp - 36]);           /* lea edx, [ebp-0x24] */
            ii(0x1014_6155, 3); mov(eax, memd[ss, ebp - 32]);           /* mov eax, [ebp-0x20] */
            ii(0x1014_6158, 3); call_abs(memd[ds, ebx + 8]);            /* call dword [ebx+0x8] */
            ii(0x1014_615b, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_615d, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x1014_6160, 5); call(0x1014_2246, -0x3f1f);             /* call 0x10142246 */
            ii(0x1014_6165, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_6167, 3); lea(eax, memd[ss, ebp - 36]);           /* lea eax, [ebp-0x24] */
            ii(0x1014_616a, 5); call(Definitions.my_string_dtor, -0x4645); /* call 0x10141b2a */
        l_0x1014_616f:
            ii(0x1014_616f, 3); lea(edx, memd[ss, ebp - 28]);           /* lea edx, [ebp-0x1c] */
            ii(0x1014_6172, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_6175, 5); call(Definitions.my_string_ctor_string, -0x46d4); /* call 0x10141aa6 */
            ii(0x1014_617a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_617c, 3); lea(eax, memd[ss, ebp - 20]);           /* lea eax, [ebp-0x14] */
            ii(0x1014_617f, 5); call(0x100e_03bc, -0x6_5dc8);           /* call 0x100e03bc */
            ii(0x1014_6184, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_6186, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x1014_6189, 5); call(Definitions.my_string_dtor, -0x4664); /* call 0x10141b2a */
            ii(0x1014_618e, 2); jmp(0x1014_61a4, 0x14); goto l_0x1014_61a4; /* jmp 0x101461a4 */
        //  ii(0x1014_6190, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x1014_6192, 3); lea(eax, memd[ss, ebp - 20]);           /* lea eax, [ebp-0x14] */
        //  ii(0x1014_6195, 5); call(0x100e_03bc, -0x6_5dde);           /* call 0x100e03bc */
        //  ii(0x1014_619a, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x1014_619c, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
        //  ii(0x1014_619f, 5); call(Definitions.my_string_dtor, -0x467a); /* call 0x10141b2a */
        l_0x1014_61a4:
            ii(0x1014_61a4, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_61a7, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_61a9, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_61aa, 1); pop(edi);                               /* pop edi */
            ii(0x1014_61ab, 1); pop(esi);                               /* pop esi */
            ii(0x1014_61ac, 1); pop(ecx);                               /* pop ecx */
            ii(0x1014_61ad, 1); ret();                                  /* ret */
        }
    }
}
