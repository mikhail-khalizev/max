using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_429e-aac3eba0")]
        public void Method_1015_429e()
        {
            ii(0x1015_429e, 5);  push(0x30);                           /* push 0x30 */
            ii(0x1015_42a3, 5);  call(Definitions.sys_check_available_stack_size, 0x1_1aaa);/* call 0x10165d52 */
            ii(0x1015_42a8, 1);  push(ebx);                            /* push ebx */
            ii(0x1015_42a9, 1);  push(ecx);                            /* push ecx */
            ii(0x1015_42aa, 1);  push(edx);                            /* push edx */
            ii(0x1015_42ab, 1);  push(esi);                            /* push esi */
            ii(0x1015_42ac, 1);  push(edi);                            /* push edi */
            ii(0x1015_42ad, 1);  push(ebp);                            /* push ebp */
            ii(0x1015_42ae, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1015_42b0, 6);  sub(esp, 0x14);                       /* sub esp, 0x14 */
            ii(0x1015_42b6, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1015_42b9, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_42bc, 5);  call(0x1014_1698, -0x1_2c29);         /* call 0x10141698 */
            ii(0x1015_42c1, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1015_42c4, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1015_42c7, 3);  mov(eax, memd[ds, eax + 14]);         /* mov eax, [eax+0xe] */
            ii(0x1015_42ca, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1015_42cd, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1015_42d0, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1015_42d3, 4);  mov(ax, memw[ds, eax + 20]);          /* mov ax, [eax+0x14] */
            ii(0x1015_42d7, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1015_42da, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_42dd, 3);  mov(al, memb[ds, eax + 80]);          /* mov al, [eax+0x50] */
            ii(0x1015_42e0, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1015_42e5, 1);  inc(eax);                             /* inc eax */
            ii(0x1015_42e6, 3);  mov(edx, memd[ss, ebp - 16]);         /* mov edx, [ebp-0x10] */
            ii(0x1015_42e9, 3);  imul(edx, eax);                       /* imul edx, eax */
            ii(0x1015_42ec, 4);  movsx(ebx, memw[ss, ebp - 12]);       /* movsx ebx, word [ebp-0xc] */
            ii(0x1015_42f0, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x1015_42f2, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x1015_42f5, 2);  idiv(ebx);                            /* idiv ebx */
            ii(0x1015_42f7, 2);  mov(ebx, eax);                        /* mov ebx, eax */
            ii(0x1015_42f9, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_42fc, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1015_42fe, 3);  mov(dl, memb[ds, eax + 80]);          /* mov dl, [eax+0x50] */
            ii(0x1015_4301, 4);  imul(edx, memd[ss, ebp - 16]);        /* imul edx, [ebp-0x10] */
            ii(0x1015_4305, 4);  movsx(ecx, memw[ss, ebp - 12]);       /* movsx ecx, word [ebp-0xc] */
            ii(0x1015_4309, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x1015_430b, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x1015_430e, 2);  idiv(ecx);                            /* idiv ecx */
            ii(0x1015_4310, 2);  sub(ebx, eax);                        /* sub ebx, eax */
            ii(0x1015_4312, 4);  mov(memw[ss, ebp - 8], bx);           /* mov [ebp-0x8], bx */
            ii(0x1015_4316, 3);  mov(al, memb[ss, ebp - 8]);           /* mov al, [ebp-0x8] */
            ii(0x1015_4319, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1015_431c, 3);  sub(memb[ds, edx + 78], al);          /* sub [edx+0x4e], al */
            ii(0x1015_431f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_4322, 3);  mov(al, memb[ds, eax + 78]);          /* mov al, [eax+0x4e] */
            ii(0x1015_4325, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1015_432a, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1015_432c, 2);  if(jge(0x1015_4335, 7)) goto l_0x1015_4335;/* jge 0x10154335 */
            ii(0x1015_432e, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_4331, 4);  mov(memb[ds, eax + 78], 0);           /* mov byte [eax+0x4e], 0x0 */
        l_0x1015_4335:
            ii(0x1015_4335, 5);  mov(eax, 0x101c_37bc);                /* mov eax, 0x101c37bc */
            ii(0x1015_433a, 5);  call(0x1007_6600, -0xd_dd3f);         /* call 0x10076600 */
            ii(0x1015_433f, 3);  cmp(eax, memd[ss, ebp - 4]);          /* cmp eax, [ebp-0x4] */
            ii(0x1015_4342, 2);  if(jnz(0x1015_434c, 8)) goto l_0x1015_434c;/* jnz 0x1015434c */
            ii(0x1015_4344, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_4347, 5);  call(0x1010_094d, -0x5_39ff);         /* call 0x1010094d */
        l_0x1015_434c:
            ii(0x1015_434c, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1015_434e, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1015_434f, 1);  pop(edi);                             /* pop edi */
            ii(0x1015_4350, 1);  pop(esi);                             /* pop esi */
            ii(0x1015_4351, 1);  pop(edx);                             /* pop edx */
            ii(0x1015_4352, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1015_4353, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1015_4354, 1);  ret();                                /* ret */
        }
    }
}
