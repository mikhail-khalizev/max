using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_aa70-a3cc6a4f")]
        public void Method_1007_aa70()
        {
            ii(0x1007_aa70, 5);  push(0x38);                           /* push 0x38 */
            ii(0x1007_aa75, 5);  call(Definitions.sys_check_available_stack_size, 0xe_b2d8);/* call 0x10165d52 */
            ii(0x1007_aa7a, 1);  push(ebx);                            /* push ebx */
            ii(0x1007_aa7b, 1);  push(ecx);                            /* push ecx */
            ii(0x1007_aa7c, 1);  push(esi);                            /* push esi */
            ii(0x1007_aa7d, 1);  push(edi);                            /* push edi */
            ii(0x1007_aa7e, 1);  push(ebp);                            /* push ebp */
            ii(0x1007_aa7f, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1007_aa81, 6);  sub(esp, 0x20);                       /* sub esp, 0x20 */
            ii(0x1007_aa87, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1007_aa8a, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1007_aa8d, 5);  mov(ebx, 0x2000);                     /* mov ebx, 0x2000 */
            ii(0x1007_aa92, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1007_aa95, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_aa98, 5);  call(0x1007_a473, -0x62a);            /* call 0x1007a473 */
            ii(0x1007_aa9d, 2);  test(al, al);                         /* test al, al */
            ii(0x1007_aa9f, 2);  if(jz(0x1007_aaa7, 6)) goto l_0x1007_aaa7;/* jz 0x1007aaa7 */
            ii(0x1007_aaa1, 4);  mov(memb[ss, ebp - 12], 1);           /* mov byte [ebp-0xc], 0x1 */
            ii(0x1007_aaa5, 2);  jmp(0x1007_ab18, 0x71); goto l_0x1007_ab18;/* jmp 0x1007ab18 */
        l_0x1007_aaa7:
            ii(0x1007_aaa7, 5);  mov(eax, 0x17);                       /* mov eax, 0x17 */
            ii(0x1007_aaac, 5);  call(Definitions.sys_new, 0xe_b34f);  /* call 0x10165e00 */
            ii(0x1007_aab1, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1007_aab4, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_aab7, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1007_aaba, 4);  cmp(memd[ss, ebp - 28], 0);           /* cmp dword [ebp-0x1c], 0x0 */
            ii(0x1007_aabe, 2);  if(jz(0x1007_aad9, 0x19)) goto l_0x1007_aad9;/* jz 0x1007aad9 */
            ii(0x1007_aac0, 3);  mov(ebx, memd[ss, ebp - 8]);          /* mov ebx, [ebp-0x8] */
            ii(0x1007_aac3, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1007_aac6, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_aac9, 5);  call(0x100b_524c, 0x3_a77e);          /* call 0x100b524c */
            ii(0x1007_aace, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1007_aad1, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1007_aad4, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x1007_aad7, 2);  jmp(0x1007_aadf, 6); goto l_0x1007_aadf;/* jmp 0x1007aadf */
        l_0x1007_aad9:
            ii(0x1007_aad9, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x1007_aadc, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
        l_0x1007_aadf:
            ii(0x1007_aadf, 3);  mov(edx, memd[ss, ebp - 32]);         /* mov edx, [ebp-0x20] */
            ii(0x1007_aae2, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_aae5, 5);  call(0x1008_b060, 0x1_0576);          /* call 0x1008b060 */
            ii(0x1007_aaea, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_aaed, 5);  call(0x1008_af84, 0x1_0492);          /* call 0x1008af84 */
            ii(0x1007_aaf2, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1007_aaf4, 5);  mov(eax, 0x101c_3180);                /* mov eax, 0x101c3180 */
            ii(0x1007_aaf9, 5);  call(0x100a_4d50, 0x2_a252);          /* call 0x100a4d50 */
            ii(0x1007_aafe, 4);  mov(memb[ss, ebp - 12], 1);           /* mov byte [ebp-0xc], 0x1 */
            ii(0x1007_ab02, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_ab04, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_ab07, 5);  call(0x1008_8b7c, 0xe070);            /* call 0x10088b7c */
            ii(0x1007_ab0c, 2);  jmp(0x1007_ab18, 0xa); goto l_0x1007_ab18;/* jmp 0x1007ab18 */
        //  ii(0x1007_ab0e, 10);  Недостижимый код.
        l_0x1007_ab18:
            ii(0x1007_ab18, 3);  mov(al, memb[ss, ebp - 12]);          /* mov al, [ebp-0xc] */
            ii(0x1007_ab1b, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1007_ab1d, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1007_ab1e, 1);  pop(edi);                             /* pop edi */
            ii(0x1007_ab1f, 1);  pop(esi);                             /* pop esi */
            ii(0x1007_ab20, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1007_ab21, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1007_ab22, 1);  ret();                                /* ret */
        }
    }
}
