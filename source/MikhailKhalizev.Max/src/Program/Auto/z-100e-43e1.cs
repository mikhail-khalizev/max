using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_43e1-d912aa3c")]
        public void Method_100e_43e1()
        {
            ii(0x100e_43e1, 5); push(0x40);                             /* push 0x40 */
            ii(0x100e_43e6, 5); call(Definitions.sys_check_available_stack_size, 0x8_1967); /* call 0x10165d52 */
            ii(0x100e_43eb, 1); push(ebx);                              /* push ebx */
            ii(0x100e_43ec, 1); push(ecx);                              /* push ecx */
            ii(0x100e_43ed, 1); push(esi);                              /* push esi */
            ii(0x100e_43ee, 1); push(edi);                              /* push edi */
            ii(0x100e_43ef, 1); push(ebp);                              /* push ebp */
            ii(0x100e_43f0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_43f2, 6); sub(esp, 0x28);                         /* sub esp, 0x28 */
            ii(0x100e_43f8, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100e_43fb, 3); mov(memd[ss, ebp - 12], edx);           /* mov [ebp-0xc], edx */
            ii(0x100e_43fe, 5); mov(ebx, 0x1c);                         /* mov ebx, 0x1c */
            ii(0x100e_4403, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_4405, 3); lea(eax, memd[ss, ebp - 40]);           /* lea eax, [ebp-0x28] */
            ii(0x100e_4408, 5); call(Definitions.sys_memset, 0x8_19d3); /* call 0x10165de0 */
            ii(0x100e_440d, 7); mov(memd[ss, ebp - 40], 0x100);         /* mov dword [ebp-0x28], 0x100 */
            ii(0x100e_4414, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100e_4417, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x100e_441a, 3); sar(eax, 4);                            /* sar eax, 0x4 */
            ii(0x100e_441d, 3); mov(memd[ss, ebp - 36], eax);           /* mov [ebp-0x24], eax */
            ii(0x100e_4420, 3); lea(ebx, memd[ss, ebp - 40]);           /* lea ebx, [ebp-0x28] */
            ii(0x100e_4423, 3); lea(edx, memd[ss, ebp - 40]);           /* lea edx, [ebp-0x28] */
            ii(0x100e_4426, 5); mov(eax, 0x31);                         /* mov eax, 0x31 */
            ii(0x100e_442b, 5); call(/* sys */ 0x1016_c606, 0x8_81d6);  /* call 0x1016c606 */
            ii(0x100e_4430, 4); cmp(memd[ss, ebp - 16], 0);             /* cmp dword [ebp-0x10], 0x0 */
            ii(0x100e_4434, 2); if(jz(0x100e_443f, 9)) goto l_0x100e_443f; /* jz 0x100e443f */
            ii(0x100e_4436, 7); mov(memd[ss, ebp - 4], 0);              /* mov dword [ebp-0x4], 0x0 */
            ii(0x100e_443d, 2); jmp(0x100e_445c, 0x1d); goto l_0x100e_445c; /* jmp 0x100e445c */
        l_0x100e_443f:
            ii(0x100e_443f, 4); cmp(memd[ss, ebp - 12], 0);             /* cmp dword [ebp-0xc], 0x0 */
            ii(0x100e_4443, 2); if(jz(0x100e_444e, 9)) goto l_0x100e_444e; /* jz 0x100e444e */
            ii(0x100e_4445, 3); mov(eax, memd[ss, ebp - 28]);           /* mov eax, [ebp-0x1c] */
            ii(0x100e_4448, 3); mov(edx, memd[ss, ebp - 12]);           /* mov edx, [ebp-0xc] */
            ii(0x100e_444b, 3); mov(memw[ds, edx], ax);                 /* mov [edx], ax */
        l_0x100e_444e:
            ii(0x100e_444e, 3); mov(eax, memd[ss, ebp - 40]);           /* mov eax, [ebp-0x28] */
            ii(0x100e_4451, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x100e_4456, 3); shl(eax, 4);                            /* shl eax, 0x4 */
            ii(0x100e_4459, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
        l_0x100e_445c:
            ii(0x100e_445c, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_445f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_4461, 1); pop(ebp);                               /* pop ebp */
            ii(0x100e_4462, 1); pop(edi);                               /* pop edi */
            ii(0x100e_4463, 1); pop(esi);                               /* pop esi */
            ii(0x100e_4464, 1); pop(ecx);                               /* pop ecx */
            ii(0x100e_4465, 1); pop(ebx);                               /* pop ebx */
            ii(0x100e_4466, 1); ret();                                  /* ret */
        }
    }
}
