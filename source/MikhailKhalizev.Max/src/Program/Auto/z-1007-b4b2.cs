using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_b4b2-16ce2165")]
        public void Method_1007_b4b2()
        {
            ii(0x1007_b4b2, 5); push(0x28);                             /* push 0x28 */
            ii(0x1007_b4b7, 5); call(Definitions.sys_check_available_stack_size, 0xe_a896); /* call 0x10165d52 */
            ii(0x1007_b4bc, 1); push(ebx);                              /* push ebx */
            ii(0x1007_b4bd, 1); push(ecx);                              /* push ecx */
            ii(0x1007_b4be, 1); push(edx);                              /* push edx */
            ii(0x1007_b4bf, 1); push(esi);                              /* push esi */
            ii(0x1007_b4c0, 1); push(edi);                              /* push edi */
            ii(0x1007_b4c1, 1); push(ebp);                              /* push ebp */
            ii(0x1007_b4c2, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_b4c4, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1007_b4ca, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1007_b4cd, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_b4cf, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_b4d2, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1007_b4d5, 5); call(0x1013_ad11, 0xb_f837);            /* call 0x1013ad11 */
            ii(0x1007_b4da, 2); test(al, al);                           /* test al, al */
            ii(0x1007_b4dc, 2); if(jnz(0x1007_b4fa, 0x1c)) goto l_0x1007_b4fa; /* jnz 0x1007b4fa */
            ii(0x1007_b4de, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_b4e1, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1007_b4e4, 5); call(0x1008_a228, 0xed3f);              /* call 0x1008a228 */
            ii(0x1007_b4e9, 5); call(0x1008_a370, 0xee82);              /* call 0x1008a370 */
            ii(0x1007_b4ee, 3); mov(al, memb[ds, eax + 0x4d]);          /* mov al, [eax+0x4d] */
            ii(0x1007_b4f1, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1007_b4f6, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_b4f8, 2); if(jg(0x1007_b500, 0x6)) goto l_0x1007_b500; /* jg 0x1007b500 */
        l_0x1007_b4fa:
            ii(0x1007_b4fa, 4); mov(memb[ss, ebp - 0x8], 0x1);          /* mov byte [ebp-0x8], 0x1 */
            ii(0x1007_b4fe, 2); jmp(0x1007_b504, 0x4); goto l_0x1007_b504; /* jmp 0x1007b504 */
        l_0x1007_b500:
            ii(0x1007_b500, 4); mov(memb[ss, ebp - 0x8], 0);            /* mov byte [ebp-0x8], 0x0 */
        l_0x1007_b504:
            ii(0x1007_b504, 3); mov(al, memb[ss, ebp - 0x8]);           /* mov al, [ebp-0x8] */
            ii(0x1007_b507, 3); mov(memb[ss, ebp - 0xc], al);           /* mov [ebp-0xc], al */
            ii(0x1007_b50a, 3); mov(al, memb[ss, ebp - 0xc]);           /* mov al, [ebp-0xc] */
            ii(0x1007_b50d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_b50f, 1); pop(ebp);                               /* pop ebp */
            ii(0x1007_b510, 1); pop(edi);                               /* pop edi */
            ii(0x1007_b511, 1); pop(esi);                               /* pop esi */
            ii(0x1007_b512, 1); pop(edx);                               /* pop edx */
            ii(0x1007_b513, 1); pop(ecx);                               /* pop ecx */
            ii(0x1007_b514, 1); pop(ebx);                               /* pop ebx */
            ii(0x1007_b515, 1); ret();                                  /* ret */
        }
    }
}
