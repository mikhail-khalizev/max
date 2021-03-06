using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_36ad-10855ba7")]
        public void Method_1008_36ad()
        {
            ii(0x1008_36ad, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1008_36b2, 5);  call(Definitions.sys_check_available_stack_size, 0xe_269b);/* call 0x10165d52 */
            ii(0x1008_36b7, 1);  push(ebx);                            /* push ebx */
            ii(0x1008_36b8, 1);  push(ecx);                            /* push ecx */
            ii(0x1008_36b9, 1);  push(edx);                            /* push edx */
            ii(0x1008_36ba, 1);  push(esi);                            /* push esi */
            ii(0x1008_36bb, 1);  push(edi);                            /* push edi */
            ii(0x1008_36bc, 1);  push(ebp);                            /* push ebp */
            ii(0x1008_36bd, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1008_36bf, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1008_36c5, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1008_36c8, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_36cb, 4);  cmp(memb[ds, eax + 21], 2);           /* cmp byte [eax+0x15], 0x2 */
            ii(0x1008_36cf, 2);  if(jle(0x1008_36da, 9)) goto l_0x1008_36da;/* jle 0x100836da */
            ii(0x1008_36d1, 4);  mov(memb[ss, ebp - 8], 0);            /* mov byte [ebp-0x8], 0x0 */
            ii(0x1008_36d5, 5);  jmp(0x1008_3749, 0x6f); goto l_0x1008_3749;/* jmp 0x10083749 */
        l_0x1008_36da:
            ii(0x1008_36da, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_36dd, 5);  call(0x1008_3558, -0x18a);            /* call 0x10083558 */
            ii(0x1008_36e2, 2);  test(al, al);                         /* test al, al */
            ii(0x1008_36e4, 2);  if(jnz(0x1008_36ec, 6)) goto l_0x1008_36ec;/* jnz 0x100836ec */
            ii(0x1008_36e6, 4);  mov(memb[ss, ebp - 8], 1);            /* mov byte [ebp-0x8], 0x1 */
            ii(0x1008_36ea, 2);  jmp(0x1008_3749, 0x5d); goto l_0x1008_3749;/* jmp 0x10083749 */
        l_0x1008_36ec:
            ii(0x1008_36ec, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1008_36ee, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_36f1, 3);  add(eax, 0x2a);                       /* add eax, 0x2a */
            ii(0x1008_36f4, 5);  call(0x1013_ad11, 0xb_7618);          /* call 0x1013ad11 */
            ii(0x1008_36f9, 2);  test(al, al);                         /* test al, al */
            ii(0x1008_36fb, 2);  if(jnz(0x1008_3711, 0x14)) goto l_0x1008_3711;/* jnz 0x10083711 */
            ii(0x1008_36fd, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_3700, 3);  add(eax, 0x2a);                       /* add eax, 0x2a */
            ii(0x1008_3703, 5);  call(0x1008_9d7c, 0x6674);            /* call 0x10089d7c */
            ii(0x1008_3708, 5);  call(0x1008_9f70, 0x6863);            /* call 0x10089f70 */
            ii(0x1008_370d, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1008_370f, 2);  if(jnz(0x1008_3717, 6)) goto l_0x1008_3717;/* jnz 0x10083717 */
        l_0x1008_3711:
            ii(0x1008_3711, 4);  mov(memb[ss, ebp - 8], 0);            /* mov byte [ebp-0x8], 0x0 */
            ii(0x1008_3715, 2);  jmp(0x1008_3749, 0x32); goto l_0x1008_3749;/* jmp 0x10083749 */
        l_0x1008_3717:
            ii(0x1008_3717, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_371a, 3);  mov(edx, memd[ds, eax + 7]);          /* mov edx, [eax+0x7] */
            ii(0x1008_371d, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1008_3720, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_3723, 3);  add(eax, 0x2a);                       /* add eax, 0x2a */
            ii(0x1008_3726, 5);  call(0x1008_9d7c, 0x6651);            /* call 0x10089d7c */
            ii(0x1008_372b, 5);  call(0x1008_9f70, 0x6840);            /* call 0x10089f70 */
            ii(0x1008_3730, 5);  call(0x1007_6074, -0xd6c1);           /* call 0x10076074 */
            ii(0x1008_3735, 2);  test(al, al);                         /* test al, al */
            ii(0x1008_3737, 2);  if(jnz(0x1008_373f, 6)) goto l_0x1008_373f;/* jnz 0x1008373f */
            ii(0x1008_3739, 4);  mov(memb[ss, ebp - 12], 1);           /* mov byte [ebp-0xc], 0x1 */
            ii(0x1008_373d, 2);  jmp(0x1008_3743, 4); goto l_0x1008_3743;/* jmp 0x10083743 */
        l_0x1008_373f:
            ii(0x1008_373f, 4);  mov(memb[ss, ebp - 12], 0);           /* mov byte [ebp-0xc], 0x0 */
        l_0x1008_3743:
            ii(0x1008_3743, 3);  mov(al, memb[ss, ebp - 12]);          /* mov al, [ebp-0xc] */
            ii(0x1008_3746, 3);  mov(memb[ss, ebp - 8], al);           /* mov [ebp-0x8], al */
        l_0x1008_3749:
            ii(0x1008_3749, 3);  mov(al, memb[ss, ebp - 8]);           /* mov al, [ebp-0x8] */
            ii(0x1008_374c, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1008_374e, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1008_374f, 1);  pop(edi);                             /* pop edi */
            ii(0x1008_3750, 1);  pop(esi);                             /* pop esi */
            ii(0x1008_3751, 1);  pop(edx);                             /* pop edx */
            ii(0x1008_3752, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1008_3753, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1008_3754, 1);  ret();                                /* ret */
        }
    }
}
