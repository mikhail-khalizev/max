using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_cc80-60a7fde7")]
        public void Method_100e_cc80()
        {
            ii(0x100e_cc80, 5);  push(0x2c);                           /* push 0x2c */
            ii(0x100e_cc85, 5);  call(Definitions.sys_check_available_stack_size, 0x7_90c8);/* call 0x10165d52 */
            ii(0x100e_cc8a, 1);  push(ebx);                            /* push ebx */
            ii(0x100e_cc8b, 1);  push(ecx);                            /* push ecx */
            ii(0x100e_cc8c, 1);  push(esi);                            /* push esi */
            ii(0x100e_cc8d, 1);  push(edi);                            /* push edi */
            ii(0x100e_cc8e, 1);  push(ebp);                            /* push ebp */
            ii(0x100e_cc8f, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100e_cc91, 6);  sub(esp, 0x14);                       /* sub esp, 0x14 */
            ii(0x100e_cc97, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100e_cc9a, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100e_cc9d, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100e_cca1, 5);  call(0x100e_c3fc, -0x8aa);            /* call 0x100ec3fc */
            ii(0x100e_cca6, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100e_cca8, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100e_ccab, 5);  call(0x1007_64b8, -0x7_67f8);         /* call 0x100764b8 */
            ii(0x100e_ccb0, 7);  mov(memd[ss, ebp - 16], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x100e_ccb7, 2);  jmp(0x100e_ccc1, 8); goto l_0x100e_ccc1;/* jmp 0x100eccc1 */
        l_0x100e_ccb9:
            ii(0x100e_ccb9, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100e_ccbc, 5);  call(0x1007_6bf8, -0x7_60c9);         /* call 0x10076bf8 */
        l_0x100e_ccc1:
            ii(0x100e_ccc1, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100e_ccc3, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100e_ccc6, 5);  call(0x1013_ad71, 0x4_e0a6);          /* call 0x1013ad71 */
            ii(0x100e_cccb, 2);  test(al, al);                         /* test al, al */
            ii(0x100e_cccd, 2);  if(jz(0x100e_cd26, 0x57)) goto l_0x100e_cd26;/* jz 0x100ecd26 */
            ii(0x100e_cccf, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100e_ccd2, 5);  call(0x1007_63a0, -0x7_6937);         /* call 0x100763a0 */
            ii(0x100e_ccd7, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100e_ccd9, 3);  mov(dl, memb[ds, eax + 38]);          /* mov dl, [eax+0x26] */
            ii(0x100e_ccdc, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x100e_cce0, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x100e_cce2, 2);  if(jnz(0x100e_ccf6, 0x12)) goto l_0x100e_ccf6;/* jnz 0x100eccf6 */
            ii(0x100e_cce4, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100e_cce7, 5);  call(0x1007_63a0, -0x7_694c);         /* call 0x100763a0 */
            ii(0x100e_ccec, 4);  mov(ax, memw[ds, eax + 8]);           /* mov ax, [eax+0x8] */
            ii(0x100e_ccf0, 4);  cmp(ax, memw[ss, ebp - 4]);           /* cmp ax, [ebp-0x4] */
            ii(0x100e_ccf4, 2);  if(jz(0x100e_ccf8, 2)) goto l_0x100e_ccf8;/* jz 0x100eccf8 */
        l_0x100e_ccf6:
            ii(0x100e_ccf6, 2);  jmp(0x100e_cd1c, 0x24); goto l_0x100e_cd1c;/* jmp 0x100ecd1c */
        l_0x100e_ccf8:
            ii(0x100e_ccf8, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100e_ccfb, 5);  call(0x1007_63a0, -0x7_6960);         /* call 0x100763a0 */
            ii(0x100e_cd00, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100e_cd02, 3);  mov(dl, memb[ds, eax + 84]);          /* mov dl, [eax+0x54] */
            ii(0x100e_cd05, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100e_cd08, 5);  call(0x1007_63a0, -0x7_696d);         /* call 0x100763a0 */
            ii(0x100e_cd0d, 5);  call(0x1007_623c, -0x7_6ad6);         /* call 0x1007623c */
            ii(0x100e_cd12, 3);  mov(eax, memd[ds, eax + 25]);         /* mov eax, [eax+0x19] */
            ii(0x100e_cd15, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100e_cd18, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x100e_cd1a, 2);  if(jnz(0x100e_cd1e, 2)) goto l_0x100e_cd1e;/* jnz 0x100ecd1e */
        l_0x100e_cd1c:
            ii(0x100e_cd1c, 2);  jmp(0x100e_cd24, 6); goto l_0x100e_cd24;/* jmp 0x100ecd24 */
        l_0x100e_cd1e:
            ii(0x100e_cd1e, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100e_cd21, 3);  inc(memd[ss, ebp - 16]);              /* inc dword [ebp-0x10] */
        l_0x100e_cd24:
            ii(0x100e_cd24, 2);  jmp(0x100e_ccb9, -0x6d); goto l_0x100e_ccb9;/* jmp 0x100eccb9 */
        l_0x100e_cd26:
            ii(0x100e_cd26, 3);  mov(al, memb[ss, ebp - 16]);          /* mov al, [ebp-0x10] */
            ii(0x100e_cd29, 3);  mov(memb[ss, ebp - 12], al);          /* mov [ebp-0xc], al */
            ii(0x100e_cd2c, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100e_cd2e, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100e_cd31, 5);  call(0x1007_5f6c, -0x7_6dca);         /* call 0x10075f6c */
            ii(0x100e_cd36, 2);  jmp(0x100e_cd42, 0xa); goto l_0x100e_cd42;/* jmp 0x100ecd42 */
        //  ii(0x100e_cd38, 10);  Недостижимый код.
        l_0x100e_cd42:
            ii(0x100e_cd42, 3);  mov(al, memb[ss, ebp - 12]);          /* mov al, [ebp-0xc] */
            ii(0x100e_cd45, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100e_cd47, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100e_cd48, 1);  pop(edi);                             /* pop edi */
            ii(0x100e_cd49, 1);  pop(esi);                             /* pop esi */
            ii(0x100e_cd4a, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100e_cd4b, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100e_cd4c, 1);  ret();                                /* ret */
        }
    }
}
