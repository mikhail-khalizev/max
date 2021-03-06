using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_94b1-757f1381")]
        public void Method_1010_94b1()
        {
            ii(0x1010_94b1, 5);  push(0x104);                          /* push 0x104 */
            ii(0x1010_94b6, 5);  call(Definitions.sys_check_available_stack_size, 0x5_c897);/* call 0x10165d52 */
            ii(0x1010_94bb, 1);  push(ebx);                            /* push ebx */
            ii(0x1010_94bc, 1);  push(ecx);                            /* push ecx */
            ii(0x1010_94bd, 1);  push(edx);                            /* push edx */
            ii(0x1010_94be, 1);  push(esi);                            /* push esi */
            ii(0x1010_94bf, 1);  push(edi);                            /* push edi */
            ii(0x1010_94c0, 1);  push(ebp);                            /* push ebp */
            ii(0x1010_94c1, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1010_94c3, 6);  sub(esp, 0xe8);                       /* sub esp, 0xe8 */
            ii(0x1010_94c9, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1010_94cc, 4);  mov(memb[ss, ebp - 8], 0);            /* mov byte [ebp-0x8], 0x0 */
            ii(0x1010_94d0, 4);  movsx(edx, memw[ss, ebp - 4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x1010_94d4, 6);  lea(eax, memd[ss, ebp - 224]);        /* lea eax, [ebp-0xe0] */
            ii(0x1010_94da, 5);  call(0x1010_91fb, -0x2e4);            /* call 0x101091fb */
        l_0x1010_94df:
            ii(0x1010_94df, 7);  cmp(memb[ds, 0x101c_5630], 0);        /* cmp byte [0x101c5630], 0x0 */
            ii(0x1010_94e6, 2);  if(jz(0x1010_94fa, 0x12)) goto l_0x1010_94fa;/* jz 0x101094fa */
            ii(0x1010_94e8, 5);  call(0x1012_ac94, 0x2_17a7);          /* call 0x1012ac94 */
            ii(0x1010_94ed, 7);  cmp(memb[ds, 0x101c_5630], 2);        /* cmp byte [0x101c5630], 0x2 */
            ii(0x1010_94f4, 6);  if(jz(0x1010_9639, 0x13f)) goto l_0x1010_9639;/* jz 0x10109639 */
        l_0x1010_94fa:
            ii(0x1010_94fa, 5);  call(/* sys */ 0x1016_b208, 0x6_1d09);/* call 0x1016b208 */
            ii(0x1010_94ff, 6);  mov(memd[ss, ebp - 211], eax);        /* mov [ebp-0xd3], eax */
            ii(0x1010_9505, 7);  cmp(memd[ss, ebp - 211], 0);          /* cmp dword [ebp-0xd3], 0x0 */
            ii(0x1010_950c, 2);  if(jle(0x1010_951a, 0xc)) goto l_0x1010_951a;/* jle 0x1010951a */
            ii(0x1010_950e, 10);  cmp(memd[ss, ebp - 211], 0x7000);    /* cmp dword [ebp-0xd3], 0x7000 */
            ii(0x1010_9518, 2);  if(jl(0x1010_951c, 2)) goto l_0x1010_951c;/* jl 0x1010951c */
        l_0x1010_951a:
            ii(0x1010_951a, 2);  jmp(0x1010_9520, 4); goto l_0x1010_9520;/* jmp 0x10109520 */
        l_0x1010_951c:
            ii(0x1010_951c, 4);  mov(memb[ss, ebp - 8], 0);            /* mov byte [ebp-0x8], 0x0 */
        l_0x1010_9520:
            ii(0x1010_9520, 10);  mov(memd[ss, ebp - 228], 0);         /* mov dword [ebp-0xe4], 0x0 */
            ii(0x1010_952a, 2);  jmp(0x1010_9538, 0xc); goto l_0x1010_9538;/* jmp 0x10109538 */
        l_0x1010_952c:
            ii(0x1010_952c, 6);  mov(eax, memd[ss, ebp - 228]);        /* mov eax, [ebp-0xe4] */
            ii(0x1010_9532, 6);  inc(memd[ss, ebp - 228]);             /* inc dword [ebp-0xe4] */
        l_0x1010_9538:
            ii(0x1010_9538, 7);  movsx(eax, memw[ss, ebp - 228]);      /* movsx eax, word [ebp-0xe4] */
            ii(0x1010_953f, 3);  cmp(eax, 0xc);                        /* cmp eax, 0xc */
            ii(0x1010_9542, 6);  if(jge(0x1010_962c, 0xe4)) goto l_0x1010_962c;/* jge 0x1010962c */
            ii(0x1010_9548, 7);  movsx(eax, memw[ss, ebp - 228]);      /* movsx eax, word [ebp-0xe4] */
            ii(0x1010_954f, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1010_9552, 8);  cmp(memd[ds, eax + ebp - 203], 0);    /* cmp dword [eax+ebp-0xcb], 0x0 */
            ii(0x1010_955a, 6);  if(jz(0x1010_9627, 0xc7)) goto l_0x1010_9627;/* jz 0x10109627 */
            ii(0x1010_9560, 7);  movsx(eax, memw[ss, ebp - 228]);      /* movsx eax, word [ebp-0xe4] */
            ii(0x1010_9567, 5);  add(eax, 0x7000);                     /* add eax, 0x7000 */
            ii(0x1010_956c, 6);  cmp(eax, memd[ss, ebp - 211]);        /* cmp eax, [ebp-0xd3] */
            ii(0x1010_9572, 2);  if(jnz(0x1010_9599, 0x25)) goto l_0x1010_9599;/* jnz 0x10109599 */
            ii(0x1010_9574, 4);  cmp(memb[ss, ebp - 8], 0);            /* cmp byte [ebp-0x8], 0x0 */
            ii(0x1010_9578, 2);  if(jnz(0x1010_9590, 0x16)) goto l_0x1010_9590;/* jnz 0x10109590 */
            ii(0x1010_957a, 7);  movsx(eax, memw[ss, ebp - 228]);      /* movsx eax, word [ebp-0xe4] */
            ii(0x1010_9581, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1010_9584, 7);  mov(eax, memd[ds, eax + ebp - 203]);  /* mov eax, [eax+ebp-0xcb] */
            ii(0x1010_958b, 5);  call(0x100c_fbbe, -0x3_99d2);         /* call 0x100cfbbe */
        l_0x1010_9590:
            ii(0x1010_9590, 4);  mov(memb[ss, ebp - 8], 1);            /* mov byte [ebp-0x8], 0x1 */
            ii(0x1010_9594, 5);  jmp(0x1010_962c, 0x93); goto l_0x1010_962c;/* jmp 0x1010962c */
        l_0x1010_9599:
            ii(0x1010_9599, 7);  movsx(edx, memw[ss, ebp - 228]);      /* movsx edx, word [ebp-0xe4] */
            ii(0x1010_95a0, 3);  imul(edx, edx, 0xc);                  /* imul edx, edx, 0xc */
            ii(0x1010_95a3, 6);  mov(eax, memd[ss, ebp - 211]);        /* mov eax, [ebp-0xd3] */
            ii(0x1010_95a9, 7);  cmp(eax, memd[ds, edx + ebp - 151]);  /* cmp eax, [edx+ebp-0x97] */
            ii(0x1010_95b0, 2);  if(jnz(0x1010_95c9, 0x17)) goto l_0x1010_95c9;/* jnz 0x101095c9 */
            ii(0x1010_95b2, 7);  movsx(eax, memw[ss, ebp - 228]);      /* movsx eax, word [ebp-0xe4] */
            ii(0x1010_95b9, 3);  imul(eax, eax, 0xc);                  /* imul eax, eax, 0xc */
            ii(0x1010_95bc, 7);  mov(eax, memd[ds, eax + ebp - 155]);  /* mov eax, [eax+ebp-0x9b] */
            ii(0x1010_95c3, 6);  mov(memd[ss, ebp - 211], eax);        /* mov [ebp-0xd3], eax */
        l_0x1010_95c9:
            ii(0x1010_95c9, 7);  movsx(edx, memw[ss, ebp - 228]);      /* movsx edx, word [ebp-0xe4] */
            ii(0x1010_95d0, 3);  imul(edx, edx, 0xc);                  /* imul edx, edx, 0xc */
            ii(0x1010_95d3, 6);  mov(eax, memd[ss, ebp - 211]);        /* mov eax, [ebp-0xd3] */
            ii(0x1010_95d9, 7);  cmp(eax, memd[ds, edx + ebp - 155]);  /* cmp eax, [edx+ebp-0x9b] */
            ii(0x1010_95e0, 2);  if(jnz(0x1010_9627, 0x45)) goto l_0x1010_9627;/* jnz 0x10109627 */
            ii(0x1010_95e2, 7);  movsx(eax, memw[ss, ebp - 228]);      /* movsx eax, word [ebp-0xe4] */
            ii(0x1010_95e9, 3);  cmp(eax, 7);                          /* cmp eax, 0x7 */
            ii(0x1010_95ec, 2);  if(jg(0x1010_9604, 0x16)) goto l_0x1010_9604;/* jg 0x10109604 */
            ii(0x1010_95ee, 7);  movsx(eax, memw[ss, ebp - 228]);      /* movsx eax, word [ebp-0xe4] */
            ii(0x1010_95f5, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1010_95f8, 7);  mov(eax, memd[ds, eax + ebp - 203]);  /* mov eax, [eax+ebp-0xcb] */
            ii(0x1010_95ff, 5);  call(0x100c_fbbe, -0x3_9a46);         /* call 0x100cfbbe */
        l_0x1010_9604:
            ii(0x1010_9604, 10);  add(memd[ss, ebp - 211], 0xffff_fc18);/* add dword [ebp-0xd3], 0xfffffc18 */
            ii(0x1010_960e, 7);  movsx(edx, memw[ss, ebp - 228]);      /* movsx edx, word [ebp-0xe4] */
            ii(0x1010_9615, 3);  imul(edx, edx, 0xc);                  /* imul edx, edx, 0xc */
            ii(0x1010_9618, 6);  lea(eax, memd[ss, ebp - 224]);        /* lea eax, [ebp-0xe0] */
            ii(0x1010_961e, 7);  call_abs(memd[ds, edx + ebp - 147]);  /* call dword [edx+ebp-0x93] */
            ii(0x1010_9625, 2);  jmp(0x1010_962c, 5); goto l_0x1010_962c;/* jmp 0x1010962c */
        l_0x1010_9627:
            ii(0x1010_9627, 5);  jmp(0x1010_952c, -0x100); goto l_0x1010_952c;/* jmp 0x1010952c */
        l_0x1010_962c:
            ii(0x1010_962c, 7);  cmp(memd[ss, ebp - 220], 0);          /* cmp dword [ebp-0xdc], 0x0 */
            ii(0x1010_9633, 6);  if(jz(0x1010_94df, -0x15a)) goto l_0x1010_94df;/* jz 0x101094df */
        l_0x1010_9639:
            ii(0x1010_9639, 6);  lea(eax, memd[ss, ebp - 224]);        /* lea eax, [ebp-0xe0] */
            ii(0x1010_963f, 5);  call(0x1010_9406, -0x23e);            /* call 0x10109406 */
            ii(0x1010_9644, 7);  movsx(edx, memw[ss, ebp - 215]);      /* movsx edx, word [ebp-0xd7] */
            ii(0x1010_964b, 7);  movsx(eax, memb[ss, ebp - 216]);      /* movsx eax, byte [ebp-0xd8] */
            ii(0x1010_9652, 5);  call(0x100c_aafc, -0x3_eb5b);         /* call 0x100caafc */
            ii(0x1010_9657, 4);  movsx(edx, memw[ss, ebp - 4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x1010_965b, 6);  imul(edx, edx, 0x247);                /* imul edx, edx, 0x247 */
            ii(0x1010_9661, 6);  mov(al, memb[ss, ebp - 215]);         /* mov al, [ebp-0xd7] */
            ii(0x1010_9667, 6);  mov(memb[ds, edx + 0x101c_a4ef], al); /* mov [edx+0x101ca4ef], al */
            ii(0x1010_966d, 6);  mov(eax, memd[ss, ebp - 215]);        /* mov eax, [ebp-0xd7] */
            ii(0x1010_9673, 6);  mov(memd[ss, ebp - 232], eax);        /* mov [ebp-0xe8], eax */
            ii(0x1010_9679, 6);  mov(eax, memd[ss, ebp - 232]);        /* mov eax, [ebp-0xe8] */
            ii(0x1010_967f, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1010_9681, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1010_9682, 1);  pop(edi);                             /* pop edi */
            ii(0x1010_9683, 1);  pop(esi);                             /* pop esi */
            ii(0x1010_9684, 1);  pop(edx);                             /* pop edx */
            ii(0x1010_9685, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1010_9686, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1010_9687, 1);  ret();                                /* ret */
        }
    }
}
