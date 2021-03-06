using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_edef-9c9474d6")]
        public void Method_100d_edef()
        {
            ii(0x100d_edef, 5);  push(0x28);                           /* push 0x28 */
            ii(0x100d_edf4, 5);  call(Definitions.sys_check_available_stack_size, 0x8_6f59);/* call 0x10165d52 */
            ii(0x100d_edf9, 1);  push(ebx);                            /* push ebx */
            ii(0x100d_edfa, 1);  push(ecx);                            /* push ecx */
            ii(0x100d_edfb, 1);  push(esi);                            /* push esi */
            ii(0x100d_edfc, 1);  push(edi);                            /* push edi */
            ii(0x100d_edfd, 1);  push(ebp);                            /* push ebp */
            ii(0x100d_edfe, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100d_ee00, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x100d_ee06, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100d_ee09, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100d_ee0c, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_ee0f, 6);  mov(eax, memd[ds, eax + 837]);        /* mov eax, [eax+0x345] */
            ii(0x100d_ee15, 5);  call(0x100d_0149, -0xecd1);           /* call 0x100d0149 */
            ii(0x100d_ee1a, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100d_ee1d, 7);  mov(memd[ss, ebp - 12], 2);           /* mov dword [ebp-0xc], 0x2 */
            ii(0x100d_ee24, 2);  jmp(0x100d_ee2c, 6); goto l_0x100d_ee2c;/* jmp 0x100dee2c */
        l_0x100d_ee26:
            ii(0x100d_ee26, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100d_ee29, 3);  inc(memd[ss, ebp - 12]);              /* inc dword [ebp-0xc] */
        l_0x100d_ee2c:
            ii(0x100d_ee2c, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_ee2f, 5);  add(eax, 0x3b3);                      /* add eax, 0x3b3 */
            ii(0x100d_ee34, 5);  call(Definitions.my_2_get_count, -0x5_3ad1);/* call 0x1008b368 */
            ii(0x100d_ee39, 4);  cmp(ax, memw[ss, ebp - 12]);          /* cmp ax, [ebp-0xc] */
            ii(0x100d_ee3d, 2);  if(jle(0x100d_ee77, 0x38)) goto l_0x100d_ee77;/* jle 0x100dee77 */
            ii(0x100d_ee3f, 4);  movsx(edx, memw[ss, ebp - 12]);       /* movsx edx, word [ebp-0xc] */
            ii(0x100d_ee43, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_ee46, 5);  add(eax, 0x3b3);                      /* add eax, 0x3b3 */
            ii(0x100d_ee4b, 5);  call(0x1008_b228, -0x5_3c28);         /* call 0x1008b228 */
            ii(0x100d_ee50, 3);  mov(ax, memw[ds, eax]);               /* mov ax, [eax] */
            ii(0x100d_ee53, 4);  cmp(ax, memw[ss, ebp - 16]);          /* cmp ax, [ebp-0x10] */
            ii(0x100d_ee57, 2);  if(jnz(0x100d_ee75, 0x1c)) goto l_0x100d_ee75;/* jnz 0x100dee75 */
            ii(0x100d_ee59, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x100d_ee5e, 5);  mov(eax, 0x19);                       /* mov eax, 0x19 */
            ii(0x100d_ee63, 5);  call(0x1007_1e00, -0x6_d068);         /* call 0x10071e00 */
            ii(0x100d_ee68, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100d_ee6b, 3);  imul(edx, eax);                       /* imul edx, eax */
            ii(0x100d_ee6e, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_ee71, 4);  sub(memw[ds, eax + 79], dx);          /* sub [eax+0x4f], dx */
        l_0x100d_ee75:
            ii(0x100d_ee75, 2);  jmp(0x100d_ee26, -0x51); goto l_0x100d_ee26;/* jmp 0x100dee26 */
        l_0x100d_ee77:
            ii(0x100d_ee77, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100d_ee79, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100d_ee7a, 1);  pop(edi);                             /* pop edi */
            ii(0x100d_ee7b, 1);  pop(esi);                             /* pop esi */
            ii(0x100d_ee7c, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100d_ee7d, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100d_ee7e, 1);  ret();                                /* ret */
        }
    }
}
