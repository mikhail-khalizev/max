using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_70d3-77b3940c")]
        public void Method_100b_70d3()
        {
            ii(0x100b_70d3, 5); push(0x24);                             /* push 0x24 */
            ii(0x100b_70d8, 5); call(Definitions.sys_check_available_stack_size, 0xa_ec75); /* call 0x10165d52 */
            ii(0x100b_70dd, 1); push(ecx);                              /* push ecx */
            ii(0x100b_70de, 1); push(esi);                              /* push esi */
            ii(0x100b_70df, 1); push(edi);                              /* push edi */
            ii(0x100b_70e0, 1); push(ebp);                              /* push ebp */
            ii(0x100b_70e1, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_70e3, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100b_70e9, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x100b_70ec, 3); mov(memd[ss, ebp - 8], edx);            /* mov [ebp-0x8], edx */
            ii(0x100b_70ef, 3); mov(memd[ss, ebp - 4], ebx);            /* mov [ebp-0x4], ebx */
            ii(0x100b_70f2, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_70f5, 5); call(0x1015_26ac, 0x9_b5b2);            /* call 0x101526ac */
            ii(0x100b_70fa, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_70fc, 2); if(jz(0x100b_7119, 0x1b)) goto l_0x100b_7119; /* jz 0x100b7119 */
            ii(0x100b_70fe, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_7101, 5); call(0x1015_26ac, 0x9_b5a6);            /* call 0x101526ac */
            ii(0x100b_7106, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x100b_7109, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100b_710c, 3); mov(edx, memd[ds, eax + 2]);            /* mov edx, [eax+0x2] */
            ii(0x100b_710f, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100b_7112, 3); call_abs(memd[ds, edx + 32]);           /* call dword [edx+0x20] */
            ii(0x100b_7115, 2); cmp(al, 0x17);                          /* cmp al, 0x17 */
            ii(0x100b_7117, 2); if(jz(0x100b_711b, 2)) goto l_0x100b_711b; /* jz 0x100b711b */
        l_0x100b_7119:
            ii(0x100b_7119, 2); jmp(0x100b_712d, 0x12); goto l_0x100b_712d; /* jmp 0x100b712d */
        l_0x100b_711b:
            ii(0x100b_711b, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x100b_7120, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_7123, 5); call(0x1015_26ac, 0x9_b584);            /* call 0x101526ac */
            ii(0x100b_7128, 5); call(0x100a_c66b, -0xaac2);             /* call 0x100ac66b */
        l_0x100b_712d:
            ii(0x100b_712d, 5); call(0x1008_b0e4, -0x2_c04e);           /* call 0x1008b0e4 */
            ii(0x100b_7132, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_7134, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100b_7136, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100b_7139, 5); call(0x100a_297d, -0x1_47c1);           /* call 0x100a297d */
            ii(0x100b_713e, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x100b_7143, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_7146, 5); call(0x1015_2605, 0x9_b4ba);            /* call 0x10152605 */
            ii(0x100b_714b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_714d, 1); pop(ebp);                               /* pop ebp */
            ii(0x100b_714e, 1); pop(edi);                               /* pop edi */
            ii(0x100b_714f, 1); pop(esi);                               /* pop esi */
            ii(0x100b_7150, 1); pop(ecx);                               /* pop ecx */
            ii(0x100b_7151, 1); ret();                                  /* ret */
        }
    }
}
