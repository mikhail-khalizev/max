using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_3505-fbe1ceba")]
        public void Method_1016_3505()
        {
            ii(0x1016_3505, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1016_350a, 5);  call(Definitions.sys_check_available_stack_size, 0x2843);/* call 0x10165d52 */
            ii(0x1016_350f, 1);  push(ebx);                            /* push ebx */
            ii(0x1016_3510, 1);  push(ecx);                            /* push ecx */
            ii(0x1016_3511, 1);  push(edx);                            /* push edx */
            ii(0x1016_3512, 1);  push(esi);                            /* push esi */
            ii(0x1016_3513, 1);  push(edi);                            /* push edi */
            ii(0x1016_3514, 1);  push(ebp);                            /* push ebp */
            ii(0x1016_3515, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1016_3517, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1016_351d, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1016_3520, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_3523, 5);  call(0x1014_4ef4, -0x1_e634);         /* call 0x10144ef4 */
            ii(0x1016_3528, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1016_352b, 3);  lea(eax, memd[ss, ebp - 4]);          /* lea eax, [ebp-0x4] */
            ii(0x1016_352e, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1016_3531, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_3534, 7);  mov(memd[ds, eax + 2], 0x101b_5780);  /* mov dword [eax+0x2], 0x101b5780 */
            ii(0x1016_353b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_353e, 6);  mov(memw[ds, eax + 8], 0);            /* mov word [eax+0x8], 0x0 */
            ii(0x1016_3544, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_3547, 6);  mov(memw[ds, eax + 10], 0);           /* mov word [eax+0xa], 0x0 */
            ii(0x1016_354d, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_3550, 6);  mov(memw[ds, eax + 12], 0);           /* mov word [eax+0xc], 0x0 */
            ii(0x1016_3556, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_3559, 6);  mov(memw[ds, eax + 14], 0);           /* mov word [eax+0xe], 0x0 */
            ii(0x1016_355f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_3562, 6);  mov(memw[ds, eax + 16], 0);           /* mov word [eax+0x10], 0x0 */
            ii(0x1016_3568, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_356b, 6);  mov(memw[ds, eax + 18], 0);           /* mov word [eax+0x12], 0x0 */
            ii(0x1016_3571, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_3574, 6);  mov(memw[ds, eax + 20], 0);           /* mov word [eax+0x14], 0x0 */
            ii(0x1016_357a, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_357d, 4);  mov(memb[ds, eax + 22], 0);           /* mov byte [eax+0x16], 0x0 */
            ii(0x1016_3581, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_3584, 6);  mov(memw[ds, eax + 23], 0);           /* mov word [eax+0x17], 0x0 */
            ii(0x1016_358a, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_358d, 6);  mov(memw[ds, eax + 25], 0);           /* mov word [eax+0x19], 0x0 */
            ii(0x1016_3593, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_3596, 6);  mov(memw[ds, eax + 27], 0);           /* mov word [eax+0x1b], 0x0 */
            ii(0x1016_359c, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_359f, 6);  mov(memw[ds, eax + 29], 0);           /* mov word [eax+0x1d], 0x0 */
            ii(0x1016_35a5, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_35a8, 6);  mov(memw[ds, eax + 31], 0);           /* mov word [eax+0x1f], 0x0 */
            ii(0x1016_35ae, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_35b1, 4);  mov(memb[ds, eax + 35], 0);           /* mov byte [eax+0x23], 0x0 */
            ii(0x1016_35b5, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_35b8, 6);  mov(memw[ds, eax + 33], 1);           /* mov word [eax+0x21], 0x1 */
            ii(0x1016_35be, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_35c1, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1016_35c4, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1016_35c7, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1016_35c9, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1016_35ca, 1);  pop(edi);                             /* pop edi */
            ii(0x1016_35cb, 1);  pop(esi);                             /* pop esi */
            ii(0x1016_35cc, 1);  pop(edx);                             /* pop edx */
            ii(0x1016_35cd, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1016_35ce, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1016_35cf, 1);  ret();                                /* ret */
        }
    }
}
