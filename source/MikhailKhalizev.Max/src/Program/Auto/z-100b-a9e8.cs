using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_a9e8-cb93499e")]
        public void Method_100b_a9e8()
        {
            ii(0x100b_a9e8, 5); push(0x34);                             /* push 0x34 */
            ii(0x100b_a9ed, 5); call(Definitions.sys_check_available_stack_size, 0xa_b360); /* call 0x10165d52 */
            ii(0x100b_a9f2, 1); push(ecx);                              /* push ecx */
            ii(0x100b_a9f3, 1); push(esi);                              /* push esi */
            ii(0x100b_a9f4, 1); push(edi);                              /* push edi */
            ii(0x100b_a9f5, 1); push(ebp);                              /* push ebp */
            ii(0x100b_a9f6, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_a9f8, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x100b_a9fe, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100b_aa01, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100b_aa04, 3); mov(memd[ss, ebp - 8], ebx);            /* mov [ebp-0x8], ebx */
            ii(0x100b_aa07, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100b_aa0a, 5); call(0x1007_6338, -0x4_46d7);           /* call 0x10076338 */
            ii(0x100b_aa0f, 3); lea(ebx, memd[ss, ebp - 0x10]);         /* lea ebx, [ebp-0x10] */
            ii(0x100b_aa12, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_aa14, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100b_aa16, 5); call(0x1007_64b8, -0x4_4563);           /* call 0x100764b8 */
            ii(0x100b_aa1b, 7); mov(memd[ss, ebp - 0x14], 0);           /* mov dword [ebp-0x14], 0x0 */
            ii(0x100b_aa22, 7); mov(memd[ss, ebp - 0x18], 0);           /* mov dword [ebp-0x18], 0x0 */
            ii(0x100b_aa29, 7); mov(memd[ss, ebp - 0x1c], 0);           /* mov dword [ebp-0x1c], 0x0 */
            ii(0x100b_aa30, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100b_aa32, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_aa34, 3); lea(eax, memd[ss, ebp - 0x20]);         /* lea eax, [ebp-0x20] */
            ii(0x100b_aa37, 5); call(0x1007_6aac, -0x4_3f90);           /* call 0x10076aac */
            ii(0x100b_aa3c, 2); jmp(0x100b_aa46, 8); goto l_0x100b_aa46; /* jmp 0x100baa46 */
        l_0x100b_aa3e:
            ii(0x100b_aa3e, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x100b_aa41, 5); call(0x1007_6bf8, -0x4_3e4e);           /* call 0x10076bf8 */
        l_0x100b_aa46:
            ii(0x100b_aa46, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_aa48, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x100b_aa4b, 5); call(0x1013_ad71, 0x8_0321);            /* call 0x1013ad71 */
            ii(0x100b_aa50, 2); test(al, al);                           /* test al, al */
            ii(0x100b_aa52, 2); if(jz(0x100b_aa93, 0x3f)) goto l_0x100b_aa93; /* jz 0x100baa93 */
            ii(0x100b_aa54, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x100b_aa57, 5); call(0x1007_63a0, -0x4_46bc);           /* call 0x100763a0 */
            ii(0x100b_aa5c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_aa5e, 3); mov(dl, memb[ds, eax + 0x26]);          /* mov dl, [eax+0x26] */
            ii(0x100b_aa61, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x100b_aa65, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100b_aa67, 2); if(jnz(0x100b_aa91, 0x28)) goto l_0x100b_aa91; /* jnz 0x100baa91 */
            ii(0x100b_aa69, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100b_aa6c, 3); inc(memd[ss, ebp - 0x14]);              /* inc dword [ebp-0x14] */
            ii(0x100b_aa6f, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x100b_aa72, 5); call(0x1007_63a0, -0x4_46d7);           /* call 0x100763a0 */
            ii(0x100b_aa77, 3); mov(eax, memd[ds, eax + 0x18]);         /* mov eax, [eax+0x18] */
            ii(0x100b_aa7a, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_aa7d, 3); add(memd[ss, ebp - 0x18], eax);         /* add [ebp-0x18], eax */
            ii(0x100b_aa80, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x100b_aa83, 5); call(0x1007_63a0, -0x4_46e8);           /* call 0x100763a0 */
            ii(0x100b_aa88, 3); mov(eax, memd[ds, eax + 0x1a]);         /* mov eax, [eax+0x1a] */
            ii(0x100b_aa8b, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_aa8e, 3); add(memd[ss, ebp - 0x1c], eax);         /* add [ebp-0x1c], eax */
        l_0x100b_aa91:
            ii(0x100b_aa91, 2); jmp(0x100b_aa3e, -0x55); goto l_0x100b_aa3e; /* jmp 0x100baa3e */
        l_0x100b_aa93:
            ii(0x100b_aa93, 4); movsx(eax, memw[ss, ebp - 0x14]);       /* movsx eax, word [ebp-0x14] */
            ii(0x100b_aa97, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_aa99, 2); if(jle(0x100b_aac1, 0x26)) goto l_0x100b_aac1; /* jle 0x100baac1 */
            ii(0x100b_aa9b, 4); movsx(ebx, memw[ss, ebp - 0x14]);       /* movsx ebx, word [ebp-0x14] */
            ii(0x100b_aa9f, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x100b_aaa2, 3); mov(edx, memd[ss, ebp - 0x18]);         /* mov edx, [ebp-0x18] */
            ii(0x100b_aaa5, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100b_aaa8, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x100b_aaaa, 4); mov(memw[ss, ebp - 0x20], ax);          /* mov [ebp-0x20], ax */
            ii(0x100b_aaae, 4); movsx(ebx, memw[ss, ebp - 0x14]);       /* movsx ebx, word [ebp-0x14] */
            ii(0x100b_aab2, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x100b_aab5, 3); mov(edx, memd[ss, ebp - 0x1c]);         /* mov edx, [ebp-0x1c] */
            ii(0x100b_aab8, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100b_aabb, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x100b_aabd, 4); mov(memw[ss, ebp - 0x1e], ax);          /* mov [ebp-0x1e], ax */
        l_0x100b_aac1:
            ii(0x100b_aac1, 3); lea(edx, memd[ss, ebp - 0x20]);         /* lea edx, [ebp-0x20] */
            ii(0x100b_aac4, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100b_aac7, 5); call(0x1007_5e64, -0x4_4c68);           /* call 0x10075e64 */
            ii(0x100b_aacc, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_aace, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x100b_aad1, 5); call(0x1007_5f6c, -0x4_4b6a);           /* call 0x10075f6c */
            ii(0x100b_aad6, 2); jmp(0x100b_aae2, 0xa); goto l_0x100b_aae2; /* jmp 0x100baae2 */
        //  ii(0x100b_aad8, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x100b_aada, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
        //  ii(0x100b_aadd, 5); call(0x1007_5f6c, -0x4_4b76);           /* call 0x10075f6c */
        l_0x100b_aae2:
            ii(0x100b_aae2, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100b_aae5, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_aae7, 1); pop(ebp);                               /* pop ebp */
            ii(0x100b_aae8, 1); pop(edi);                               /* pop edi */
            ii(0x100b_aae9, 1); pop(esi);                               /* pop esi */
            ii(0x100b_aaea, 1); pop(ecx);                               /* pop ecx */
            ii(0x100b_aaeb, 1); ret();                                  /* ret */
        }
    }
}
