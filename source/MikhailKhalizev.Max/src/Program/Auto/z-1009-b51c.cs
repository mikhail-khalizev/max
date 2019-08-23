using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_b51c-2e359249")]
        public void Method_1009_b51c()
        {
            ii(0x1009_b51c, 5); push(0x28);                             /* push 0x28 */
            ii(0x1009_b521, 5); call(Definitions.sys_check_available_stack_size, 0xc_a82c); /* call 0x10165d52 */
            ii(0x1009_b526, 1); push(ebx);                              /* push ebx */
            ii(0x1009_b527, 1); push(ecx);                              /* push ecx */
            ii(0x1009_b528, 1); push(edx);                              /* push edx */
            ii(0x1009_b529, 1); push(esi);                              /* push esi */
            ii(0x1009_b52a, 1); push(edi);                              /* push edi */
            ii(0x1009_b52b, 1); push(ebp);                              /* push ebp */
            ii(0x1009_b52c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_b52e, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1009_b534, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1009_b537, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_b53a, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1009_b53d, 5); call(0x1007_6338, -0x2_520a);           /* call 0x10076338 */
            ii(0x1009_b542, 3); lea(ebx, memd[ss, ebp - 0x8]);          /* lea ebx, [ebp-0x8] */
            ii(0x1009_b545, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_b547, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1009_b549, 5); call(0x1007_64b8, -0x2_5096);           /* call 0x100764b8 */
            ii(0x1009_b54e, 2); jmp(0x1009_b558, 0x8); goto l_0x1009_b558; /* jmp 0x1009b558 */
        l_0x1009_b550:
            ii(0x1009_b550, 3); lea(eax, memd[ss, ebp - 0x8]);          /* lea eax, [ebp-0x8] */
            ii(0x1009_b553, 5); call(0x1007_6bf8, -0x2_4960);           /* call 0x10076bf8 */
        l_0x1009_b558:
            ii(0x1009_b558, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_b55a, 3); lea(eax, memd[ss, ebp - 0x8]);          /* lea eax, [ebp-0x8] */
            ii(0x1009_b55d, 5); call(0x1013_ad71, 0x9_f80f);            /* call 0x1013ad71 */
            ii(0x1009_b562, 2); test(al, al);                           /* test al, al */
            ii(0x1009_b564, 2); if(jz(0x1009_b594, 0x2e)) goto l_0x1009_b594; /* jz 0x1009b594 */
            ii(0x1009_b566, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_b569, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1009_b56c, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1009_b56f, 3); mov(ebx, memd[ds, eax + 0x2]);          /* mov ebx, [eax+0x2] */
            ii(0x1009_b572, 3); lea(eax, memd[ss, ebp - 0x8]);          /* lea eax, [ebp-0x8] */
            ii(0x1009_b575, 5); call(0x1007_63d4, -0x2_51a6);           /* call 0x100763d4 */
            ii(0x1009_b57a, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_b57c, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1009_b57f, 3); call_abs(memd[ds, ebx + 0x44]);         /* call dword [ebx+0x44] */
            ii(0x1009_b582, 2); test(al, al);                           /* test al, al */
            ii(0x1009_b584, 2); if(jz(0x1009_b592, 0xc)) goto l_0x1009_b592; /* jz 0x1009b592 */
            ii(0x1009_b586, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_b588, 3); lea(eax, memd[ss, ebp - 0x8]);          /* lea eax, [ebp-0x8] */
            ii(0x1009_b58b, 5); call(0x1007_5f6c, -0x2_5624);           /* call 0x10075f6c */
            ii(0x1009_b590, 2); jmp(0x1009_b59e, 0xc); goto l_0x1009_b59e; /* jmp 0x1009b59e */
        l_0x1009_b592:
            ii(0x1009_b592, 2); jmp(0x1009_b550, -0x44); goto l_0x1009_b550; /* jmp 0x1009b550 */
        l_0x1009_b594:
            ii(0x1009_b594, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_b596, 3); lea(eax, memd[ss, ebp - 0x8]);          /* lea eax, [ebp-0x8] */
            ii(0x1009_b599, 5); call(0x1007_5f6c, -0x2_5632);           /* call 0x10075f6c */
        l_0x1009_b59e:
            ii(0x1009_b59e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_b5a0, 1); pop(ebp);                               /* pop ebp */
            ii(0x1009_b5a1, 1); pop(edi);                               /* pop edi */
            ii(0x1009_b5a2, 1); pop(esi);                               /* pop esi */
            ii(0x1009_b5a3, 1); pop(edx);                               /* pop edx */
            ii(0x1009_b5a4, 1); pop(ecx);                               /* pop ecx */
            ii(0x1009_b5a5, 1); pop(ebx);                               /* pop ebx */
            ii(0x1009_b5a6, 1); ret();                                  /* ret */
        }
    }
}
