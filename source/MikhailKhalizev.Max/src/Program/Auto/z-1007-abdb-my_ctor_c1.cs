using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_abdb-8bfa156")]
        public void my_ctor_c1()
        {
            ii(0x1007_abdb, 5);  push(0x3c);                           /* push 0x3c */
            ii(0x1007_abe0, 5);  call(Definitions.sys_check_available_stack_size, 0xe_b16d);/* call 0x10165d52 */
            ii(0x1007_abe5, 1);  push(esi);                            /* push esi */
            ii(0x1007_abe6, 1);  push(edi);                            /* push edi */
            ii(0x1007_abe7, 1);  push(ebp);                            /* push ebp */
            ii(0x1007_abe8, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1007_abea, 6);  sub(esp, 0x2c);                       /* sub esp, 0x2c */
            ii(0x1007_abf0, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1007_abf3, 3);  mov(memd[ss, ebp - 12], edx);         /* mov [ebp-0xc], edx */
            ii(0x1007_abf6, 3);  mov(memd[ss, ebp - 8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x1007_abf9, 3);  mov(memd[ss, ebp - 4], ecx);          /* mov [ebp-0x4], ecx */
            ii(0x1007_abfc, 4);  movsx(ecx, memw[ss, ebp - 4]);        /* movsx ecx, word [ebp-0x4] */
            ii(0x1007_ac00, 3);  mov(ebx, memd[ss, ebp - 12]);         /* mov ebx, [ebp-0xc] */
            ii(0x1007_ac03, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_ac06, 5);  call(0x1008_a3a8, 0xf79d);            /* call 0x1008a3a8 */
            ii(0x1007_ac0b, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x1007_ac0e, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_ac11, 5);  call(0x100a_26d1, 0x2_7abb);          /* call 0x100a26d1 */
            ii(0x1007_ac16, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1007_ac19, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x1007_ac1c, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1007_ac1f, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_ac22, 3);  add(eax, 0x15);                       /* add eax, 0x15 */
            ii(0x1007_ac25, 5);  call(0x1008_a330, 0xf706);            /* call 0x1008a330 */
            ii(0x1007_ac2a, 3);  sub(eax, 0x15);                       /* sub eax, 0x15 */
            ii(0x1007_ac2d, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1007_ac30, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x1007_ac33, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x1007_ac36, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_ac39, 3);  add(eax, 0x19);                       /* add eax, 0x19 */
            ii(0x1007_ac3c, 5);  call(Definitions.my_ctor_0x101b_56fc, 0xe03b);/* call 0x10088c7c */
            ii(0x1007_ac41, 3);  sub(eax, 0x19);                       /* sub eax, 0x19 */
            ii(0x1007_ac44, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1007_ac47, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x1007_ac4a, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1007_ac4d, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_ac50, 3);  add(eax, 0x29);                       /* add eax, 0x29 */
            ii(0x1007_ac53, 5);  call(Definitions.my_ctor_0x101b_38f8, -0x4568);/* call 0x100766f0 */
            ii(0x1007_ac58, 3);  sub(eax, 0x29);                       /* sub eax, 0x29 */
            ii(0x1007_ac5b, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1007_ac5e, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x1007_ac61, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x1007_ac64, 5);  call(0x1008_a4fc, 0xf893);            /* call 0x1008a4fc */
            ii(0x1007_ac69, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x1007_ac6c, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_ac6f, 3);  add(eax, 0x2d);                       /* add eax, 0x2d */
            ii(0x1007_ac72, 5);  call(0x100b_84c2, 0x3_d84b);          /* call 0x100b84c2 */
            ii(0x1007_ac77, 3);  sub(eax, 0x2d);                       /* sub eax, 0x2d */
            ii(0x1007_ac7a, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1007_ac7d, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x1007_ac80, 3);  mov(memd[ss, ebp - 36], eax);         /* mov [ebp-0x24], eax */
            ii(0x1007_ac83, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_ac86, 7);  mov(memd[ds, eax + 2], 0x101b_3f00);  /* mov dword [eax+0x2], 0x101b3f00 */
            ii(0x1007_ac8d, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_ac90, 5);  call(0x1008_a370, 0xf6db);            /* call 0x1008a370 */
            ii(0x1007_ac95, 3);  mov(memd[ss, ebp - 40], eax);         /* mov [ebp-0x28], eax */
            ii(0x1007_ac98, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1007_ac9b, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_ac9e, 3);  add(eax, 0x15);                       /* add eax, 0x15 */
            ii(0x1007_aca1, 5);  call(0x1008_a2b4, 0xf60e);            /* call 0x1008a2b4 */
            ii(0x1007_aca6, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_aca9, 6);  mov(memw[ds, eax + 19], 0);           /* mov word [eax+0x13], 0x0 */
            ii(0x1007_acaf, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_acb2, 4);  mov(memb[ds, eax + 49], 1);           /* mov byte [eax+0x31], 0x1 */
            ii(0x1007_acb6, 3);  mov(edx, memd[ss, ebp - 40]);         /* mov edx, [ebp-0x28] */
            ii(0x1007_acb9, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1007_acbb, 3);  mov(al, memb[ds, edx + 77]);          /* mov al, [edx+0x4d] */
            ii(0x1007_acbe, 3);  mov(edx, memd[ss, ebp - 16]);         /* mov edx, [ebp-0x10] */
            ii(0x1007_acc1, 4);  mov(memw[ds, edx + 39], ax);          /* mov [edx+0x27], ax */
            ii(0x1007_acc5, 3);  mov(eax, memd[ss, ebp - 40]);         /* mov eax, [ebp-0x28] */
            ii(0x1007_acc8, 5);  call(0x1007_623c, -0x4a91);           /* call 0x1007623c */
            ii(0x1007_accd, 3);  mov(eax, memd[ds, eax + 25]);         /* mov eax, [eax+0x19] */
            ii(0x1007_acd0, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1007_acd3, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1007_acd5, 2);  if(jz(0x1007_ace7, 0x10)) goto l_0x1007_ace7;/* jz 0x1007ace7 */
            ii(0x1007_acd7, 3);  mov(eax, memd[ss, ebp - 40]);         /* mov eax, [ebp-0x28] */
            ii(0x1007_acda, 3);  mov(al, memb[ds, eax + 38]);          /* mov al, [eax+0x26] */
            ii(0x1007_acdd, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1007_ace2, 3);  cmp(eax, 4);                          /* cmp eax, 0x4 */
            ii(0x1007_ace5, 2);  if(jnz(0x1007_acf2, 0xb)) goto l_0x1007_acf2;/* jnz 0x1007acf2 */
        l_0x1007_ace7:
            ii(0x1007_ace7, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_acea, 6);  mov(memw[ds, eax + 35], 1);           /* mov word [eax+0x23], 0x1 */
            ii(0x1007_acf0, 2);  jmp(0x1007_ad07, 0x15); goto l_0x1007_ad07;/* jmp 0x1007ad07 */
        l_0x1007_acf2:
            ii(0x1007_acf2, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_acf5, 4);  mov(dx, memw[ds, eax + 39]);          /* mov dx, [eax+0x27] */
            ii(0x1007_acf9, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_acfc, 4);  mov(memw[ds, eax + 35], dx);          /* mov [eax+0x23], dx */
            ii(0x1007_ad00, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_ad03, 4);  shl(memw[ds, eax + 39], 1);           /* shl word [eax+0x27], 1 */
        l_0x1007_ad07:
            ii(0x1007_ad07, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_ad0a, 6);  mov(memw[ds, eax + 37], 0);           /* mov word [eax+0x25], 0x0 */
            ii(0x1007_ad10, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_ad13, 3);  mov(memd[ss, ebp - 44], eax);         /* mov [ebp-0x2c], eax */
            ii(0x1007_ad16, 3);  mov(eax, memd[ss, ebp - 44]);         /* mov eax, [ebp-0x2c] */
            ii(0x1007_ad19, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1007_ad1b, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1007_ad1c, 1);  pop(edi);                             /* pop edi */
            ii(0x1007_ad1d, 1);  pop(esi);                             /* pop esi */
            ii(0x1007_ad1e, 1);  ret();                                /* ret */
        }
    }
}
