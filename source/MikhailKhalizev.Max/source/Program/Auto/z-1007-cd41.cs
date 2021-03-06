using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_cd41-6e0458bd")]
        public void Method_1007_cd41()
        {
            ii(0x1007_cd41, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1007_cd46, 5);  call(Definitions.sys_check_available_stack_size, 0xe_9007);/* call 0x10165d52 */
            ii(0x1007_cd4b, 1);  push(ebx);                            /* push ebx */
            ii(0x1007_cd4c, 1);  push(ecx);                            /* push ecx */
            ii(0x1007_cd4d, 1);  push(esi);                            /* push esi */
            ii(0x1007_cd4e, 1);  push(edi);                            /* push edi */
            ii(0x1007_cd4f, 1);  push(ebp);                            /* push ebp */
            ii(0x1007_cd50, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1007_cd52, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x1007_cd58, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1007_cd5b, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1007_cd5e, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1007_cd61, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_cd64, 5);  call(0x1007_4bde, -0x818b);           /* call 0x10074bde */
            ii(0x1007_cd69, 2);  test(al, al);                         /* test al, al */
            ii(0x1007_cd6b, 2);  if(jnz(0x1007_cd79, 0xc)) goto l_0x1007_cd79;/* jnz 0x1007cd79 */
            ii(0x1007_cd6d, 7);  mov(memd[ss, ebp - 12], 0);           /* mov dword [ebp-0xc], 0x0 */
            ii(0x1007_cd74, 5);  jmp(0x1007_ce0b, 0x92); goto l_0x1007_ce0b;/* jmp 0x1007ce0b */
        l_0x1007_cd79:
            ii(0x1007_cd79, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_cd7c, 3);  mov(al, memb[ds, eax + 77]);          /* mov al, [eax+0x4d] */
            ii(0x1007_cd7f, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1007_cd84, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1007_cd86, 2);  if(jnz(0x1007_cd94, 0xc)) goto l_0x1007_cd94;/* jnz 0x1007cd94 */
            ii(0x1007_cd88, 7);  mov(memd[ss, ebp - 12], 0);           /* mov dword [ebp-0xc], 0x0 */
            ii(0x1007_cd8f, 5);  jmp(0x1007_ce0b, 0x77); goto l_0x1007_ce0b;/* jmp 0x1007ce0b */
        l_0x1007_cd94:
            ii(0x1007_cd94, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_cd97, 5);  call(0x1007_623c, -0x6b60);           /* call 0x1007623c */
            ii(0x1007_cd9c, 3);  mov(ecx, memd[ds, eax + 18]);         /* mov ecx, [eax+0x12] */
            ii(0x1007_cd9f, 3);  sar(ecx, 0x10);                       /* sar ecx, 0x10 */
            ii(0x1007_cda2, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x1007_cda4, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1007_cda7, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_cdaa, 5);  call(0x1015_d211, 0xe_0462);          /* call 0x1015d211 */
            ii(0x1007_cdaf, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x1007_cdb2, 3);  imul(edx, ecx);                       /* imul edx, ecx */
            ii(0x1007_cdb5, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_cdb8, 5);  call(0x1007_623c, -0x6b81);           /* call 0x1007623c */
            ii(0x1007_cdbd, 3);  mov(eax, memd[ds, eax + 6]);          /* mov eax, [eax+0x6] */
            ii(0x1007_cdc0, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1007_cdc3, 3);  imul(edx, eax);                       /* imul edx, eax */
            ii(0x1007_cdc6, 3);  imul(edx, edx, 7);                    /* imul edx, edx, 0x7 */
            ii(0x1007_cdc9, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_cdcc, 3);  mov(al, memb[ds, eax + 77]);          /* mov al, [eax+0x4d] */
            ii(0x1007_cdcf, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1007_cdd4, 3);  imul(ebx, eax, 0xc);                  /* imul ebx, eax, 0xc */
            ii(0x1007_cdd7, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x1007_cdd9, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x1007_cddc, 2);  idiv(ebx);                            /* idiv ebx */
            ii(0x1007_cdde, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1007_cde1, 4);  movsx(eax, memw[ss, ebp - 16]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1007_cde5, 3);  cmp(eax, 1);                          /* cmp eax, 0x1 */
            ii(0x1007_cde8, 2);  if(jge(0x1007_cdf3, 9)) goto l_0x1007_cdf3;/* jge 0x1007cdf3 */
            ii(0x1007_cdea, 7);  mov(memd[ss, ebp - 12], 1);           /* mov dword [ebp-0xc], 0x1 */
            ii(0x1007_cdf1, 2);  jmp(0x1007_ce0b, 0x18); goto l_0x1007_ce0b;/* jmp 0x1007ce0b */
        l_0x1007_cdf3:
            ii(0x1007_cdf3, 4);  movsx(eax, memw[ss, ebp - 16]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1007_cdf7, 3);  cmp(eax, 7);                          /* cmp eax, 0x7 */
            ii(0x1007_cdfa, 2);  if(jle(0x1007_ce05, 9)) goto l_0x1007_ce05;/* jle 0x1007ce05 */
            ii(0x1007_cdfc, 7);  mov(memd[ss, ebp - 12], 7);           /* mov dword [ebp-0xc], 0x7 */
            ii(0x1007_ce03, 2);  jmp(0x1007_ce0b, 6); goto l_0x1007_ce0b;/* jmp 0x1007ce0b */
        l_0x1007_ce05:
            ii(0x1007_ce05, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_ce08, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
        l_0x1007_ce0b:
            ii(0x1007_ce0b, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1007_ce0e, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1007_ce10, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1007_ce11, 1);  pop(edi);                             /* pop edi */
            ii(0x1007_ce12, 1);  pop(esi);                             /* pop esi */
            ii(0x1007_ce13, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1007_ce14, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1007_ce15, 1);  ret();                                /* ret */
        }
    }
}
