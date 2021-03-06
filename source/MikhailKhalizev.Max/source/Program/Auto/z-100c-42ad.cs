using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_42ad-2ad35f2")]
        public void Method_100c_42ad()
        {
            ii(0x100c_42ad, 5);  push(0x2c);                           /* push 0x2c */
            ii(0x100c_42b2, 5);  call(Definitions.sys_check_available_stack_size, 0xa_1a9b);/* call 0x10165d52 */
            ii(0x100c_42b7, 1);  push(ecx);                            /* push ecx */
            ii(0x100c_42b8, 1);  push(esi);                            /* push esi */
            ii(0x100c_42b9, 1);  push(edi);                            /* push edi */
            ii(0x100c_42ba, 1);  push(ebp);                            /* push ebp */
            ii(0x100c_42bb, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100c_42bd, 6);  sub(esp, 0x18);                       /* sub esp, 0x18 */
            ii(0x100c_42c3, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100c_42c6, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x100c_42c9, 3);  mov(memd[ss, ebp - 4], ebx);          /* mov [ebp-0x4], ebx */
            ii(0x100c_42cc, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100c_42cf, 3);  movsx(eax, memw[ds, eax]);            /* movsx eax, word [eax] */
            ii(0x100c_42d2, 3);  imul(eax, eax, 0x13);                 /* imul eax, eax, 0x13 */
            ii(0x100c_42d5, 5);  mov(edx, 0x101c_35b4);                /* mov edx, 0x101c35b4 */
            ii(0x100c_42da, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x100c_42dc, 3);  mov(memd[ss, ebp - 20], edx);         /* mov [ebp-0x14], edx */
            ii(0x100c_42df, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100c_42e2, 3);  movsx(edx, memw[ds, eax]);            /* movsx edx, word [eax] */
            ii(0x100c_42e5, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x100c_42e9, 5);  call(0x100a_23e4, -0x2_1f0a);         /* call 0x100a23e4 */
            ii(0x100c_42ee, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x100c_42f1, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x100c_42f5, 5);  call(0x100c_dec2, 0x9bc8);            /* call 0x100cdec2 */
            ii(0x100c_42fa, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100c_42fc, 2);  if(jz(0x100c_430c, 0xe)) goto l_0x100c_430c;/* jz 0x100c430c */
            ii(0x100c_42fe, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x100c_4301, 5);  call(Definitions.my_2_get_count, -0x3_8f9e);/* call 0x1008b368 */
            ii(0x100c_4306, 1);  cwde();                               /* cwde */
            ii(0x100c_4307, 3);  cmp(eax, 0x14);                       /* cmp eax, 0x14 */
            ii(0x100c_430a, 2);  if(jl(0x100c_4315, 9)) goto l_0x100c_4315;/* jl 0x100c4315 */
        l_0x100c_430c:
            ii(0x100c_430c, 4);  mov(memb[ss, ebp - 16], 0);           /* mov byte [ebp-0x10], 0x0 */
            ii(0x100c_4310, 5);  jmp(0x100c_4396, 0x81); goto l_0x100c_4396;/* jmp 0x100c4396 */
        l_0x100c_4315:
            ii(0x100c_4315, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x100c_4318, 3);  mov(edx, memd[ss, ebp - 20]);         /* mov edx, [ebp-0x14] */
            ii(0x100c_431b, 4);  cmp(ax, memw[ds, edx + 16]);          /* cmp ax, [edx+0x10] */
            ii(0x100c_431f, 2);  if(jle(0x100c_4327, 6)) goto l_0x100c_4327;/* jle 0x100c4327 */
            ii(0x100c_4321, 4);  mov(memb[ss, ebp - 16], 0);           /* mov byte [ebp-0x10], 0x0 */
            ii(0x100c_4325, 2);  jmp(0x100c_4396, 0x6f); goto l_0x100c_4396;/* jmp 0x100c4396 */
        l_0x100c_4327:
            ii(0x100c_4327, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x100c_432a, 3);  mov(edx, memd[ds, eax + 14]);         /* mov edx, [eax+0xe] */
            ii(0x100c_432d, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x100c_4330, 4);  movsx(eax, memw[ss, ebp - 24]);       /* movsx eax, word [ebp-0x18] */
            ii(0x100c_4334, 2);  sub(edx, eax);                        /* sub edx, eax */
            ii(0x100c_4336, 3);  lea(edx, memd[ds, edx + edx * 4]);    /* lea edx, [edx+edx*4] */
            ii(0x100c_4339, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100c_433d, 2);  cmp(eax, edx);                        /* cmp eax, edx */
            ii(0x100c_433f, 2);  if(jle(0x100c_4351, 0x10)) goto l_0x100c_4351;/* jle 0x100c4351 */
            ii(0x100c_4341, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x100c_4344, 4);  mov(ax, memw[ds, eax + 16]);          /* mov ax, [eax+0x10] */
            ii(0x100c_4348, 3);  sub(eax, memd[ss, ebp - 24]);         /* sub eax, [ebp-0x18] */
            ii(0x100c_434b, 3);  imul(eax, eax, 5);                    /* imul eax, eax, 0x5 */
            ii(0x100c_434e, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
        l_0x100c_4351:
            ii(0x100c_4351, 3);  lea(edx, memd[ss, ebp - 8]);          /* lea edx, [ebp-0x8] */
            ii(0x100c_4354, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x100c_4357, 5);  call(0x1008_b2a8, -0x3_90b4);         /* call 0x1008b2a8 */
            ii(0x100c_435c, 3);  lea(edx, memd[ss, ebp - 4]);          /* lea edx, [ebp-0x4] */
            ii(0x100c_435f, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x100c_4362, 3);  add(eax, 4);                          /* add eax, 0x4 */
            ii(0x100c_4365, 5);  call(0x100c_aa44, 0x66da);            /* call 0x100caa44 */
            ii(0x100c_436a, 4);  movsx(edx, memw[ss, ebp - 4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x100c_436e, 5);  mov(ebx, 5);                          /* mov ebx, 0x5 */
            ii(0x100c_4373, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x100c_4375, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x100c_4378, 2);  idiv(ebx);                            /* idiv ebx */
            ii(0x100c_437a, 4);  movsx(edx, memw[ss, ebp - 24]);       /* movsx edx, word [ebp-0x18] */
            ii(0x100c_437e, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x100c_4380, 3);  mov(edx, memd[ss, ebp - 20]);         /* mov edx, [ebp-0x14] */
            ii(0x100c_4383, 3);  mov(edx, memd[ds, edx + 14]);         /* mov edx, [edx+0xe] */
            ii(0x100c_4386, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x100c_4389, 2);  sub(edx, eax);                        /* sub edx, eax */
            ii(0x100c_438b, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x100c_438e, 4);  mov(memw[ds, eax + 16], dx);          /* mov [eax+0x10], dx */
            ii(0x100c_4392, 4);  mov(memb[ss, ebp - 16], 1);           /* mov byte [ebp-0x10], 0x1 */
        l_0x100c_4396:
            ii(0x100c_4396, 3);  mov(al, memb[ss, ebp - 16]);          /* mov al, [ebp-0x10] */
            ii(0x100c_4399, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100c_439b, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100c_439c, 1);  pop(edi);                             /* pop edi */
            ii(0x100c_439d, 1);  pop(esi);                             /* pop esi */
            ii(0x100c_439e, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100c_439f, 1);  ret();                                /* ret */
        }
    }
}
