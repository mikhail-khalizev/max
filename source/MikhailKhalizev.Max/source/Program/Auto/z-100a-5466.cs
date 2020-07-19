using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_5466-84a897eb")]
        public void Method_100a_5466()
        {
            ii(0x100a_5466, 5);  push(0x1e0);                          /* push 0x1e0 */
            ii(0x100a_546b, 5);  call(Definitions.sys_check_available_stack_size, 0xc_08e2);/* call 0x10165d52 */
            ii(0x100a_5470, 1);  push(ebx);                            /* push ebx */
            ii(0x100a_5471, 1);  push(ecx);                            /* push ecx */
            ii(0x100a_5472, 1);  push(esi);                            /* push esi */
            ii(0x100a_5473, 1);  push(edi);                            /* push edi */
            ii(0x100a_5474, 1);  push(ebp);                            /* push ebp */
            ii(0x100a_5475, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100a_5477, 6);  sub(esp, 0x1c8);                      /* sub esp, 0x1c8 */
            ii(0x100a_547d, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100a_5480, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100a_5483, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_5486, 3);  mov(al, memb[ds, eax + 38]);          /* mov al, [eax+0x26] */
            ii(0x100a_5489, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x100a_548e, 6);  imul(eax, eax, 0x247);                /* imul eax, eax, 0x247 */
            ii(0x100a_5494, 6);  mov(al, memb[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x100a_549a, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x100a_549f, 3);  cmp(eax, 2);                          /* cmp eax, 0x2 */
            ii(0x100a_54a2, 2);  if(jz(0x100a_54b1, 0xd)) goto l_0x100a_54b1;/* jz 0x100a54b1 */
            ii(0x100a_54a4, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_54a7, 5);  call(0x1015_287d, 0xa_d3d1);          /* call 0x1015287d */
            ii(0x100a_54ac, 5);  jmp(0x100a_5c61, 0x7b0); goto l_0x100a_5c61;/* jmp 0x100a5c61 */
        l_0x100a_54b1:
            ii(0x100a_54b1, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_54b4, 4);  test(memb[ds, eax + 19], 2);          /* test byte [eax+0x13], 0x2 */
            ii(0x100a_54b8, 2);  if(jz(0x100a_54cc, 0x12)) goto l_0x100a_54cc;/* jz 0x100a54cc */
            ii(0x100a_54ba, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_54bd, 5);  call(0x1007_623c, -0x2_f286);         /* call 0x1007623c */
            ii(0x100a_54c2, 3);  mov(eax, memd[ds, eax + 25]);         /* mov eax, [eax+0x19] */
            ii(0x100a_54c5, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100a_54c8, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100a_54ca, 2);  if(jz(0x100a_54ce, 2)) goto l_0x100a_54ce;/* jz 0x100a54ce */
        l_0x100a_54cc:
            ii(0x100a_54cc, 2);  jmp(0x100a_54d8, 0xa); goto l_0x100a_54d8;/* jmp 0x100a54d8 */
        l_0x100a_54ce:
            ii(0x100a_54ce, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_54d1, 5);  cmp(memw[ds, eax + 8], 0x18);         /* cmp word [eax+0x8], 0x18 */
            ii(0x100a_54d6, 2);  if(jnz(0x100a_54da, 2)) goto l_0x100a_54da;/* jnz 0x100a54da */
        l_0x100a_54d8:
            ii(0x100a_54d8, 2);  jmp(0x100a_54e4, 0xa); goto l_0x100a_54e4;/* jmp 0x100a54e4 */
        l_0x100a_54da:
            ii(0x100a_54da, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_54dd, 5);  cmp(memw[ds, eax + 8], 0x19);         /* cmp word [eax+0x8], 0x19 */
            ii(0x100a_54e2, 2);  if(jnz(0x100a_54e6, 2)) goto l_0x100a_54e6;/* jnz 0x100a54e6 */
        l_0x100a_54e4:
            ii(0x100a_54e4, 2);  jmp(0x100a_54f0, 0xa); goto l_0x100a_54f0;/* jmp 0x100a54f0 */
        l_0x100a_54e6:
            ii(0x100a_54e6, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_54e9, 5);  cmp(memw[ds, eax + 8], 0x17);         /* cmp word [eax+0x8], 0x17 */
            ii(0x100a_54ee, 2);  if(jnz(0x100a_54f2, 2)) goto l_0x100a_54f2;/* jnz 0x100a54f2 */
        l_0x100a_54f0:
            ii(0x100a_54f0, 2);  jmp(0x100a_54fc, 0xa); goto l_0x100a_54fc;/* jmp 0x100a54fc */
        l_0x100a_54f2:
            ii(0x100a_54f2, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_54f5, 5);  cmp(memw[ds, eax + 8], 0x1b);         /* cmp word [eax+0x8], 0x1b */
            ii(0x100a_54fa, 2);  if(jnz(0x100a_54fe, 2)) goto l_0x100a_54fe;/* jnz 0x100a54fe */
        l_0x100a_54fc:
            ii(0x100a_54fc, 2);  jmp(0x100a_5508, 0xa); goto l_0x100a_5508;/* jmp 0x100a5508 */
        l_0x100a_54fe:
            ii(0x100a_54fe, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_5501, 5);  cmp(memw[ds, eax + 8], 0x20);         /* cmp word [eax+0x8], 0x20 */
            ii(0x100a_5506, 2);  if(jnz(0x100a_550a, 2)) goto l_0x100a_550a;/* jnz 0x100a550a */
        l_0x100a_5508:
            ii(0x100a_5508, 2);  jmp(0x100a_550f, 5); goto l_0x100a_550f;/* jmp 0x100a550f */
        l_0x100a_550a:
            ii(0x100a_550a, 5);  jmp(0x100a_5c61, 0x752); goto l_0x100a_5c61;/* jmp 0x100a5c61 */
        l_0x100a_550f:
            ii(0x100a_550f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_5512, 5);  call(0x1015_26ac, 0xa_d195);          /* call 0x101526ac */
            ii(0x100a_5517, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100a_5519, 2);  if(jnz(0x100a_552a, 0xf)) goto l_0x100a_552a;/* jnz 0x100a552a */
            ii(0x100a_551b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_551e, 3);  mov(al, memb[ds, eax + 77]);          /* mov al, [eax+0x4d] */
            ii(0x100a_5521, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x100a_5526, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100a_5528, 2);  if(jg(0x100a_552c, 2)) goto l_0x100a_552c;/* jg 0x100a552c */
        l_0x100a_552a:
            ii(0x100a_552a, 2);  jmp(0x100a_554d, 0x21); goto l_0x100a_554d;/* jmp 0x100a554d */
        l_0x100a_552c:
            ii(0x100a_552c, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_552f, 3);  mov(al, memb[ds, eax + 38]);          /* mov al, [eax+0x26] */
            ii(0x100a_5532, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x100a_5537, 6);  imul(eax, eax, 0x247);                /* imul eax, eax, 0x247 */
            ii(0x100a_553d, 6);  mov(al, memb[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x100a_5543, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x100a_5548, 3);  cmp(eax, 2);                          /* cmp eax, 0x2 */
            ii(0x100a_554b, 2);  if(jz(0x100a_5552, 5)) goto l_0x100a_5552;/* jz 0x100a5552 */
        l_0x100a_554d:
            ii(0x100a_554d, 5);  jmp(0x100a_5c61, 0x70f); goto l_0x100a_5c61;/* jmp 0x100a5c61 */
        l_0x100a_5552:
            ii(0x100a_5552, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_5555, 3);  add(eax, 0xa);                        /* add eax, 0xa */
            ii(0x100a_5558, 5);  call(0x100a_b0ac, 0x5b4f);            /* call 0x100ab0ac */
            ii(0x100a_555d, 3);  lea(ebx, memd[ss, ebp - 16]);         /* lea ebx, [ebp-0x10] */
            ii(0x100a_5560, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100a_5562, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x100a_5564, 5);  call(0x100a_afc0, 0x5a57);            /* call 0x100aafc0 */
            ii(0x100a_5569, 4);  or(memb[ss, ebp - 12], 1);            /* or byte [ebp-0xc], 0x1 */
            ii(0x100a_556d, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100a_5570, 5);  call(0x1008_a958, -0x1_ac1d);         /* call 0x1008a958 */
            ii(0x100a_5575, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x100a_5578, 4);  and(memb[ss, ebp - 12], -2 /* 0xfe */);/* and byte [ebp-0xc], 0xfe */
            ii(0x100a_557c, 6);  lea(edx, memd[ss, ebp - 324]);        /* lea edx, [ebp-0x144] */
            ii(0x100a_5582, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_5585, 5);  call(0x1014_fa43, 0xa_a4b9);          /* call 0x1014fa43 */
            ii(0x100a_558a, 5);  mov(eax, 0x4c);                       /* mov eax, 0x4c */
            ii(0x100a_558f, 5);  call(0x1007_5fdc, -0x2_f5b8);         /* call 0x10075fdc */
            ii(0x100a_5594, 3);  cmp(eax, 1);                          /* cmp eax, 0x1 */
            ii(0x100a_5597, 6);  if(jl(0x100a_5682, 0xe5)) goto l_0x100a_5682;/* jl 0x100a5682 */
            ii(0x100a_559d, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_55a0, 5);  call(0x1007_623c, -0x2_f369);         /* call 0x1007623c */
            ii(0x100a_55a5, 3);  mov(edx, memd[ds, eax + 8]);          /* mov edx, [eax+0x8] */
            ii(0x100a_55a8, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x100a_55ab, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_55ae, 3);  mov(al, memb[ds, eax + 77]);          /* mov al, [eax+0x4d] */
            ii(0x100a_55b1, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x100a_55b6, 2);  cmp(eax, edx);                        /* cmp eax, edx */
            ii(0x100a_55b8, 2);  if(jnz(0x100a_55d3, 0x19)) goto l_0x100a_55d3;/* jnz 0x100a55d3 */
            ii(0x100a_55ba, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_55bd, 4);  cmp(memb[ds, eax + 62], 3);           /* cmp byte [eax+0x3e], 0x3 */
            ii(0x100a_55c1, 2);  if(jnz(0x100a_55d1, 0xe)) goto l_0x100a_55d1;/* jnz 0x100a55d1 */
            ii(0x100a_55c3, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_55c6, 5);  call(0x1007_611c, -0x2_f4af);         /* call 0x1007611c */
            ii(0x100a_55cb, 4);  cmp(memb[ds, eax + 62], 0x1f);        /* cmp byte [eax+0x3e], 0x1f */
            ii(0x100a_55cf, 2);  if(jnz(0x100a_55d3, 2)) goto l_0x100a_55d3;/* jnz 0x100a55d3 */
        l_0x100a_55d1:
            ii(0x100a_55d1, 2);  jmp(0x100a_55dc, 9); goto l_0x100a_55dc;/* jmp 0x100a55dc */
        l_0x100a_55d3:
            ii(0x100a_55d3, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_55d6, 4);  test(memb[ds, eax + 19], 2);          /* test byte [eax+0x13], 0x2 */
            ii(0x100a_55da, 2);  if(jz(0x100a_55e1, 5)) goto l_0x100a_55e1;/* jz 0x100a55e1 */
        l_0x100a_55dc:
            ii(0x100a_55dc, 5);  jmp(0x100a_5682, 0xa1); goto l_0x100a_5682;/* jmp 0x100a5682 */
        l_0x100a_55e1:
            ii(0x100a_55e1, 5);  mov(eax, 0x1b);                       /* mov eax, 0x1b */
            ii(0x100a_55e6, 5);  call(Definitions.sys_new, 0xc_0815);  /* call 0x10165e00 */
            ii(0x100a_55eb, 6);  mov(memd[ss, ebp - 328], eax);        /* mov [ebp-0x148], eax */
            ii(0x100a_55f1, 6);  mov(eax, memd[ss, ebp - 328]);        /* mov eax, [ebp-0x148] */
            ii(0x100a_55f7, 6);  mov(memd[ss, ebp - 332], eax);        /* mov [ebp-0x14c], eax */
            ii(0x100a_55fd, 7);  cmp(memd[ss, ebp - 332], 0);          /* cmp dword [ebp-0x14c], 0x0 */
            ii(0x100a_5604, 2);  if(jz(0x100a_5628, 0x22)) goto l_0x100a_5628;/* jz 0x100a5628 */
            ii(0x100a_5606, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100a_5609, 6);  mov(eax, memd[ss, ebp - 328]);        /* mov eax, [ebp-0x148] */
            ii(0x100a_560f, 5);  call(Definitions.my_ctor_c15, 0x2_6274);/* call 0x100cb888 */
            ii(0x100a_5614, 6);  mov(memd[ss, ebp - 336], eax);        /* mov [ebp-0x150], eax */
            ii(0x100a_561a, 6);  mov(eax, memd[ss, ebp - 336]);        /* mov eax, [ebp-0x150] */
            ii(0x100a_5620, 6);  mov(memd[ss, ebp - 340], eax);        /* mov [ebp-0x154], eax */
            ii(0x100a_5626, 2);  jmp(0x100a_5634, 0xc); goto l_0x100a_5634;/* jmp 0x100a5634 */
        l_0x100a_5628:
            ii(0x100a_5628, 6);  mov(eax, memd[ss, ebp - 332]);        /* mov eax, [ebp-0x14c] */
            ii(0x100a_562e, 6);  mov(memd[ss, ebp - 340], eax);        /* mov [ebp-0x154], eax */
        l_0x100a_5634:
            ii(0x100a_5634, 6);  mov(edx, memd[ss, ebp - 340]);        /* mov edx, [ebp-0x154] */
            ii(0x100a_563a, 6);  lea(eax, memd[ss, ebp - 344]);        /* lea eax, [ebp-0x158] */
            ii(0x100a_5640, 5);  call(0x1008_b060, -0x1_a5e5);         /* call 0x1008b060 */
            ii(0x100a_5645, 6);  lea(eax, memd[ss, ebp - 344]);        /* lea eax, [ebp-0x158] */
            ii(0x100a_564b, 5);  call(0x1008_af84, -0x1_a6cc);         /* call 0x1008af84 */
            ii(0x100a_5650, 3);  mov(ebx, memd[ss, ebp - 8]);          /* mov ebx, [ebp-0x8] */
            ii(0x100a_5653, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100a_5655, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x100a_5657, 5);  call(0x100a_4d50, -0x90c);            /* call 0x100a4d50 */
            ii(0x100a_565c, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100a_565e, 6);  lea(eax, memd[ss, ebp - 344]);        /* lea eax, [ebp-0x158] */
            ii(0x100a_5664, 5);  call(0x1008_8b7c, -0x1_caed);         /* call 0x10088b7c */
            ii(0x100a_5669, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100a_566b, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100a_566e, 5);  call(0x1008_8cbc, -0x1_c9b7);         /* call 0x10088cbc */
            ii(0x100a_5673, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100a_5675, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x100a_5678, 5);  call(0x100a_a070, 0x49f3);            /* call 0x100aa070 */
            ii(0x100a_567d, 5);  jmp(0x100a_5c61, 0x5df); goto l_0x100a_5c61;/* jmp 0x100a5c61 */
        l_0x100a_5682:
            ii(0x100a_5682, 5);  mov(eax, 0x4c);                       /* mov eax, 0x4c */
            ii(0x100a_5687, 5);  call(0x1007_5fdc, -0x2_f6b0);         /* call 0x10075fdc */
            ii(0x100a_568c, 3);  cmp(eax, 3);                          /* cmp eax, 0x3 */
            ii(0x100a_568f, 2);  if(jl(0x100a_569c, 0xb)) goto l_0x100a_569c;/* jl 0x100a569c */
            ii(0x100a_5691, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_5694, 6);  test(memw[ds, eax + 18], 0x1c0);      /* test word [eax+0x12], 0x1c0 */
            ii(0x100a_569a, 2);  if(jnz(0x100a_569e, 2)) goto l_0x100a_569e;/* jnz 0x100a569e */
        l_0x100a_569c:
            ii(0x100a_569c, 2);  jmp(0x100a_56a7, 9); goto l_0x100a_56a7;/* jmp 0x100a56a7 */
        l_0x100a_569e:
            ii(0x100a_569e, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_56a1, 4);  test(memb[ds, eax + 21], 0x10);       /* test byte [eax+0x15], 0x10 */
            ii(0x100a_56a5, 2);  if(jz(0x100a_56a9, 2)) goto l_0x100a_56a9;/* jz 0x100a56a9 */
        l_0x100a_56a7:
            ii(0x100a_56a7, 2);  jmp(0x100a_56cd, 0x24); goto l_0x100a_56cd;/* jmp 0x100a56cd */
        l_0x100a_56a9:
            ii(0x100a_56a9, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100a_56ac, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_56af, 3);  mov(al, memb[ds, eax + 38]);          /* mov al, [eax+0x26] */
            ii(0x100a_56b2, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x100a_56b7, 6);  imul(eax, eax, 0xc5);                 /* imul eax, eax, 0xc5 */
            ii(0x100a_56bd, 5);  mov(ebx, 0x101c_31c4);                /* mov ebx, 0x101c31c4 */
            ii(0x100a_56c2, 2);  add(eax, ebx);                        /* add eax, ebx */
            ii(0x100a_56c4, 5);  call(0x100c_343a, 0x1_dd71);          /* call 0x100c343a */
            ii(0x100a_56c9, 2);  test(al, al);                         /* test al, al */
            ii(0x100a_56cb, 2);  if(jnz(0x100a_56d2, 5)) goto l_0x100a_56d2;/* jnz 0x100a56d2 */
        l_0x100a_56cd:
            ii(0x100a_56cd, 5);  jmp(0x100a_5773, 0xa1); goto l_0x100a_5773;/* jmp 0x100a5773 */
        l_0x100a_56d2:
            ii(0x100a_56d2, 5);  mov(eax, 0x1b);                       /* mov eax, 0x1b */
            ii(0x100a_56d7, 5);  call(Definitions.sys_new, 0xc_0724);  /* call 0x10165e00 */
            ii(0x100a_56dc, 6);  mov(memd[ss, ebp - 348], eax);        /* mov [ebp-0x15c], eax */
            ii(0x100a_56e2, 6);  mov(eax, memd[ss, ebp - 348]);        /* mov eax, [ebp-0x15c] */
            ii(0x100a_56e8, 6);  mov(memd[ss, ebp - 352], eax);        /* mov [ebp-0x160], eax */
            ii(0x100a_56ee, 7);  cmp(memd[ss, ebp - 352], 0);          /* cmp dword [ebp-0x160], 0x0 */
            ii(0x100a_56f5, 2);  if(jz(0x100a_5719, 0x22)) goto l_0x100a_5719;/* jz 0x100a5719 */
            ii(0x100a_56f7, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100a_56fa, 6);  mov(eax, memd[ss, ebp - 348]);        /* mov eax, [ebp-0x15c] */
            ii(0x100a_5700, 5);  call(Definitions.my_ctor_c18, 0x2_7c58);/* call 0x100cd35d */
            ii(0x100a_5705, 6);  mov(memd[ss, ebp - 356], eax);        /* mov [ebp-0x164], eax */
            ii(0x100a_570b, 6);  mov(eax, memd[ss, ebp - 356]);        /* mov eax, [ebp-0x164] */
            ii(0x100a_5711, 6);  mov(memd[ss, ebp - 360], eax);        /* mov [ebp-0x168], eax */
            ii(0x100a_5717, 2);  jmp(0x100a_5725, 0xc); goto l_0x100a_5725;/* jmp 0x100a5725 */
        l_0x100a_5719:
            ii(0x100a_5719, 6);  mov(eax, memd[ss, ebp - 352]);        /* mov eax, [ebp-0x160] */
            ii(0x100a_571f, 6);  mov(memd[ss, ebp - 360], eax);        /* mov [ebp-0x168], eax */
        l_0x100a_5725:
            ii(0x100a_5725, 6);  mov(edx, memd[ss, ebp - 360]);        /* mov edx, [ebp-0x168] */
            ii(0x100a_572b, 6);  lea(eax, memd[ss, ebp - 364]);        /* lea eax, [ebp-0x16c] */
            ii(0x100a_5731, 5);  call(0x1008_b060, -0x1_a6d6);         /* call 0x1008b060 */
            ii(0x100a_5736, 6);  lea(eax, memd[ss, ebp - 364]);        /* lea eax, [ebp-0x16c] */
            ii(0x100a_573c, 5);  call(0x1008_af84, -0x1_a7bd);         /* call 0x1008af84 */
            ii(0x100a_5741, 3);  mov(ebx, memd[ss, ebp - 8]);          /* mov ebx, [ebp-0x8] */
            ii(0x100a_5744, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100a_5746, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x100a_5748, 5);  call(0x100a_4d50, -0x9fd);            /* call 0x100a4d50 */
            ii(0x100a_574d, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100a_574f, 6);  lea(eax, memd[ss, ebp - 364]);        /* lea eax, [ebp-0x16c] */
            ii(0x100a_5755, 5);  call(0x1008_8b7c, -0x1_cbde);         /* call 0x10088b7c */
            ii(0x100a_575a, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100a_575c, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100a_575f, 5);  call(0x1008_8cbc, -0x1_caa8);         /* call 0x10088cbc */
            ii(0x100a_5764, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100a_5766, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x100a_5769, 5);  call(0x100a_a070, 0x4902);            /* call 0x100aa070 */
            ii(0x100a_576e, 5);  jmp(0x100a_5c61, 0x4ee); goto l_0x100a_5c61;/* jmp 0x100a5c61 */
        l_0x100a_5773:
            ii(0x100a_5773, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_5776, 5);  call(0x1007_623c, -0x2_f53f);         /* call 0x1007623c */
            ii(0x100a_577b, 3);  mov(edx, memd[ds, eax + 18]);         /* mov edx, [eax+0x12] */
            ii(0x100a_577e, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x100a_5781, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_5784, 3);  mov(al, memb[ds, eax + 84]);          /* mov al, [eax+0x54] */
            ii(0x100a_5787, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x100a_578c, 2);  cmp(eax, edx);                        /* cmp eax, edx */
            ii(0x100a_578e, 6);  if(jge(0x100a_5835, 0xa1)) goto l_0x100a_5835;/* jge 0x100a5835 */
            ii(0x100a_5794, 5);  mov(eax, 0x1b);                       /* mov eax, 0x1b */
            ii(0x100a_5799, 5);  call(Definitions.sys_new, 0xc_0662);  /* call 0x10165e00 */
            ii(0x100a_579e, 6);  mov(memd[ss, ebp - 368], eax);        /* mov [ebp-0x170], eax */
            ii(0x100a_57a4, 6);  mov(eax, memd[ss, ebp - 368]);        /* mov eax, [ebp-0x170] */
            ii(0x100a_57aa, 6);  mov(memd[ss, ebp - 372], eax);        /* mov [ebp-0x174], eax */
            ii(0x100a_57b0, 7);  cmp(memd[ss, ebp - 372], 0);          /* cmp dword [ebp-0x174], 0x0 */
            ii(0x100a_57b7, 2);  if(jz(0x100a_57db, 0x22)) goto l_0x100a_57db;/* jz 0x100a57db */
            ii(0x100a_57b9, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100a_57bc, 6);  mov(eax, memd[ss, ebp - 368]);        /* mov eax, [ebp-0x170] */
            ii(0x100a_57c2, 5);  call(Definitions.my_ctor_c16, 0x2_7663);/* call 0x100cce2a */
            ii(0x100a_57c7, 6);  mov(memd[ss, ebp - 376], eax);        /* mov [ebp-0x178], eax */
            ii(0x100a_57cd, 6);  mov(eax, memd[ss, ebp - 376]);        /* mov eax, [ebp-0x178] */
            ii(0x100a_57d3, 6);  mov(memd[ss, ebp - 380], eax);        /* mov [ebp-0x17c], eax */
            ii(0x100a_57d9, 2);  jmp(0x100a_57e7, 0xc); goto l_0x100a_57e7;/* jmp 0x100a57e7 */
        l_0x100a_57db:
            ii(0x100a_57db, 6);  mov(eax, memd[ss, ebp - 372]);        /* mov eax, [ebp-0x174] */
            ii(0x100a_57e1, 6);  mov(memd[ss, ebp - 380], eax);        /* mov [ebp-0x17c], eax */
        l_0x100a_57e7:
            ii(0x100a_57e7, 6);  mov(edx, memd[ss, ebp - 380]);        /* mov edx, [ebp-0x17c] */
            ii(0x100a_57ed, 6);  lea(eax, memd[ss, ebp - 384]);        /* lea eax, [ebp-0x180] */
            ii(0x100a_57f3, 5);  call(0x1008_b060, -0x1_a798);         /* call 0x1008b060 */
            ii(0x100a_57f8, 6);  lea(eax, memd[ss, ebp - 384]);        /* lea eax, [ebp-0x180] */
            ii(0x100a_57fe, 5);  call(0x1008_af84, -0x1_a87f);         /* call 0x1008af84 */
            ii(0x100a_5803, 3);  mov(ebx, memd[ss, ebp - 8]);          /* mov ebx, [ebp-0x8] */
            ii(0x100a_5806, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100a_5808, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x100a_580a, 5);  call(0x100a_4d50, -0xabf);            /* call 0x100a4d50 */
            ii(0x100a_580f, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100a_5811, 6);  lea(eax, memd[ss, ebp - 384]);        /* lea eax, [ebp-0x180] */
            ii(0x100a_5817, 5);  call(0x1008_8b7c, -0x1_cca0);         /* call 0x10088b7c */
            ii(0x100a_581c, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100a_581e, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100a_5821, 5);  call(0x1008_8cbc, -0x1_cb6a);         /* call 0x10088cbc */
            ii(0x100a_5826, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100a_5828, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x100a_582b, 5);  call(0x100a_a070, 0x4840);            /* call 0x100aa070 */
            ii(0x100a_5830, 5);  jmp(0x100a_5c61, 0x42c); goto l_0x100a_5c61;/* jmp 0x100a5c61 */
        l_0x100a_5835:
            ii(0x100a_5835, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_5838, 5);  call(0x1008_aef4, -0x1_a949);         /* call 0x1008aef4 */
            ii(0x100a_583d, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100a_583f, 6);  lea(eax, memd[ss, ebp - 388]);        /* lea eax, [ebp-0x184] */
            ii(0x100a_5845, 5);  call(0x1008_ae70, -0x1_a9da);         /* call 0x1008ae70 */
            ii(0x100a_584a, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_584d, 6);  test(memw[ds, eax + 18], 0x1c0);      /* test word [eax+0x12], 0x1c0 */
            ii(0x100a_5853, 6);  if(jz(0x100a_58ef, 0x96)) goto l_0x100a_58ef;/* jz 0x100a58ef */
            ii(0x100a_5859, 2);  jmp(0x100a_5866, 0xb); goto l_0x100a_5866;/* jmp 0x100a5866 */
        l_0x100a_585b:
            ii(0x100a_585b, 6);  lea(eax, memd[ss, ebp - 388]);        /* lea eax, [ebp-0x184] */
            ii(0x100a_5861, 5);  call(0x1007_6bf8, -0x2_ec6e);         /* call 0x10076bf8 */
        l_0x100a_5866:
            ii(0x100a_5866, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100a_5868, 6);  lea(eax, memd[ss, ebp - 388]);        /* lea eax, [ebp-0x184] */
            ii(0x100a_586e, 5);  call(0x1013_ad71, 0x9_54fe);          /* call 0x1013ad71 */
            ii(0x100a_5873, 2);  test(al, al);                         /* test al, al */
            ii(0x100a_5875, 6);  if(jz(0x100a_58ef, 0x74)) goto l_0x100a_58ef;/* jz 0x100a58ef */
            ii(0x100a_587b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_587e, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100a_5880, 3);  mov(dl, memb[ds, eax + 38]);          /* mov dl, [eax+0x26] */
            ii(0x100a_5883, 6);  lea(eax, memd[ss, ebp - 388]);        /* lea eax, [ebp-0x184] */
            ii(0x100a_5889, 5);  call(0x1008_adc4, -0x1_aaca);         /* call 0x1008adc4 */
            ii(0x100a_588e, 5);  call(0x1008_ad90, -0x1_ab03);         /* call 0x1008ad90 */
            ii(0x100a_5893, 1);  cwde();                               /* cwde */
            ii(0x100a_5894, 2);  cmp(eax, edx);                        /* cmp eax, edx */
            ii(0x100a_5896, 2);  if(jnz(0x100a_58c2, 0x2a)) goto l_0x100a_58c2;/* jnz 0x100a58c2 */
            ii(0x100a_5898, 6);  lea(eax, memd[ss, ebp - 388]);        /* lea eax, [ebp-0x184] */
            ii(0x100a_589e, 5);  call(0x1008_adc4, -0x1_aadf);         /* call 0x1008adc4 */
            ii(0x100a_58a3, 6);  mov(memd[ss, ebp - 392], eax);        /* mov [ebp-0x188], eax */
            ii(0x100a_58a9, 6);  mov(eax, memd[ss, ebp - 392]);        /* mov eax, [ebp-0x188] */
            ii(0x100a_58af, 3);  mov(ebx, memd[ds, eax + 2]);          /* mov ebx, [eax+0x2] */
            ii(0x100a_58b2, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100a_58b5, 6);  mov(eax, memd[ss, ebp - 392]);        /* mov eax, [ebp-0x188] */
            ii(0x100a_58bb, 3);  call_abs(memd[ds, ebx + 64]);         /* call dword [ebx+0x40] */
            ii(0x100a_58be, 2);  test(al, al);                         /* test al, al */
            ii(0x100a_58c0, 2);  if(jnz(0x100a_58c4, 2)) goto l_0x100a_58c4;/* jnz 0x100a58c4 */
        l_0x100a_58c2:
            ii(0x100a_58c2, 2);  jmp(0x100a_58ea, 0x26); goto l_0x100a_58ea;/* jmp 0x100a58ea */
        l_0x100a_58c4:
            ii(0x100a_58c4, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100a_58c6, 6);  lea(eax, memd[ss, ebp - 388]);        /* lea eax, [ebp-0x184] */
            ii(0x100a_58cc, 5);  call(0x1008_8bbc, -0x1_cd15);         /* call 0x10088bbc */
            ii(0x100a_58d1, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100a_58d3, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100a_58d6, 5);  call(0x1008_8cbc, -0x1_cc1f);         /* call 0x10088cbc */
            ii(0x100a_58db, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100a_58dd, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x100a_58e0, 5);  call(0x100a_a070, 0x478b);            /* call 0x100aa070 */
            ii(0x100a_58e5, 5);  jmp(0x100a_5c61, 0x377); goto l_0x100a_5c61;/* jmp 0x100a5c61 */
        l_0x100a_58ea:
            ii(0x100a_58ea, 5);  jmp(0x100a_585b, -0x94); goto l_0x100a_585b;/* jmp 0x100a585b */
        l_0x100a_58ef:
            ii(0x100a_58ef, 2);  jmp(0x100a_58f9, 8); goto l_0x100a_58f9;/* jmp 0x100a58f9 */
        l_0x100a_58f1:
            ii(0x100a_58f1, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x100a_58f4, 5);  call(0x1007_6bf8, -0x2_ed01);         /* call 0x10076bf8 */
        l_0x100a_58f9:
            ii(0x100a_58f9, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100a_58fb, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x100a_58fe, 5);  call(0x1013_ad71, 0x9_546e);          /* call 0x1013ad71 */
            ii(0x100a_5903, 2);  test(al, al);                         /* test al, al */
            ii(0x100a_5905, 6);  if(jz(0x100a_59aa, 0x9f)) goto l_0x100a_59aa;/* jz 0x100a59aa */
            ii(0x100a_590b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_590e, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100a_5910, 3);  mov(dl, memb[ds, eax + 38]);          /* mov dl, [eax+0x26] */
            ii(0x100a_5913, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x100a_5916, 5);  call(0x100a_aedc, 0x55c1);            /* call 0x100aaedc */
            ii(0x100a_591b, 5);  call(0x1008_ad90, -0x1_ab90);         /* call 0x1008ad90 */
            ii(0x100a_5920, 1);  cwde();                               /* cwde */
            ii(0x100a_5921, 2);  cmp(eax, edx);                        /* cmp eax, edx */
            ii(0x100a_5923, 6);  if(jnz(0x100a_59a5, 0x7c)) goto l_0x100a_59a5;/* jnz 0x100a59a5 */
            ii(0x100a_5929, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100a_592b, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100a_592e, 5);  call(0x1013_ad11, 0x9_53de);          /* call 0x1013ad11 */
            ii(0x100a_5933, 2);  test(al, al);                         /* test al, al */
            ii(0x100a_5935, 2);  if(jnz(0x100a_5950, 0x19)) goto l_0x100a_5950;/* jnz 0x100a5950 */
            ii(0x100a_5937, 7);  movsx(edx, memw[ss, ebp - 396]);      /* movsx edx, word [ebp-0x18c] */
            ii(0x100a_593e, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x100a_5941, 5);  call(0x100a_aedc, 0x5596);            /* call 0x100aaedc */
            ii(0x100a_5946, 5);  call(0x100a_2bc4, -0x2d87);           /* call 0x100a2bc4 */
            ii(0x100a_594b, 1);  cwde();                               /* cwde */
            ii(0x100a_594c, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100a_594e, 2);  if(jge(0x100a_596b, 0x1b)) goto l_0x100a_596b;/* jge 0x100a596b */
        l_0x100a_5950:
            ii(0x100a_5950, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_5953, 3);  mov(edx, memd[ds, eax + 6]);          /* mov edx, [eax+0x6] */
            ii(0x100a_5956, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x100a_5959, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x100a_595c, 5);  call(0x100a_aedc, 0x557b);            /* call 0x100aaedc */
            ii(0x100a_5961, 5);  call(0x100a_6125, 0x7bf);             /* call 0x100a6125 */
            ii(0x100a_5966, 3);  test(ax, ax);                         /* test ax, ax */
            ii(0x100a_5969, 2);  if(jnz(0x100a_596d, 2)) goto l_0x100a_596d;/* jnz 0x100a596d */
        l_0x100a_596b:
            ii(0x100a_596b, 2);  jmp(0x100a_59a5, 0x38); goto l_0x100a_59a5;/* jmp 0x100a59a5 */
        l_0x100a_596d:
            ii(0x100a_596d, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x100a_5970, 5);  call(0x100a_af10, 0x559b);            /* call 0x100aaf10 */
            ii(0x100a_5975, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100a_5977, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100a_597a, 5);  call(0x1008_a898, -0x1_b0e7);         /* call 0x1008a898 */
            ii(0x100a_597f, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100a_5982, 5);  call(0x1008_a7dc, -0x1_b1ab);         /* call 0x1008a7dc */
            ii(0x100a_5987, 6);  mov(memd[ss, ebp - 400], eax);        /* mov [ebp-0x190], eax */
            ii(0x100a_598d, 6);  mov(eax, memd[ss, ebp - 400]);        /* mov eax, [ebp-0x190] */
            ii(0x100a_5993, 3);  mov(edx, memd[ds, eax + 2]);          /* mov edx, [eax+0x2] */
            ii(0x100a_5996, 6);  mov(eax, memd[ss, ebp - 400]);        /* mov eax, [ebp-0x190] */
            ii(0x100a_599c, 3);  call_abs(memd[ds, edx + 20]);         /* call dword [edx+0x14] */
            ii(0x100a_599f, 6);  mov(memd[ss, ebp - 396], eax);        /* mov [ebp-0x18c], eax */
        l_0x100a_59a5:
            ii(0x100a_59a5, 5);  jmp(0x100a_58f1, -0xb9); goto l_0x100a_58f1;/* jmp 0x100a58f1 */
        l_0x100a_59aa:
            ii(0x100a_59aa, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100a_59ac, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100a_59af, 5);  call(0x1013_ad71, 0x9_53bd);          /* call 0x1013ad71 */
            ii(0x100a_59b4, 2);  test(al, al);                         /* test al, al */
            ii(0x100a_59b6, 2);  if(jz(0x100a_59e0, 0x28)) goto l_0x100a_59e0;/* jz 0x100a59e0 */
            ii(0x100a_59b8, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100a_59bb, 5);  call(0x1008_a7dc, -0x1_b1e4);         /* call 0x1008a7dc */
            ii(0x100a_59c0, 6);  mov(memd[ss, ebp - 404], eax);        /* mov [ebp-0x194], eax */
            ii(0x100a_59c6, 6);  mov(eax, memd[ss, ebp - 404]);        /* mov eax, [ebp-0x194] */
            ii(0x100a_59cc, 3);  mov(ebx, memd[ds, eax + 2]);          /* mov ebx, [eax+0x2] */
            ii(0x100a_59cf, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100a_59d2, 6);  mov(eax, memd[ss, ebp - 404]);        /* mov eax, [ebp-0x194] */
            ii(0x100a_59d8, 3);  call_abs(memd[ds, ebx + 44]);         /* call dword [ebx+0x2c] */
            ii(0x100a_59db, 5);  jmp(0x100a_5c40, 0x260); goto l_0x100a_5c40;/* jmp 0x100a5c40 */
        l_0x100a_59e0:
            ii(0x100a_59e0, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_59e3, 5);  cmp(memw[ds, eax + 8], 0x18);         /* cmp word [eax+0x8], 0x18 */
            ii(0x100a_59e8, 2);  if(jz(0x100a_59f4, 0xa)) goto l_0x100a_59f4;/* jz 0x100a59f4 */
            ii(0x100a_59ea, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_59ed, 5);  cmp(memw[ds, eax + 8], 0x19);         /* cmp word [eax+0x8], 0x19 */
            ii(0x100a_59f2, 2);  if(jnz(0x100a_59f6, 2)) goto l_0x100a_59f6;/* jnz 0x100a59f6 */
        l_0x100a_59f4:
            ii(0x100a_59f4, 2);  jmp(0x100a_5a00, 0xa); goto l_0x100a_5a00;/* jmp 0x100a5a00 */
        l_0x100a_59f6:
            ii(0x100a_59f6, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_59f9, 5);  cmp(memw[ds, eax + 8], 0x17);         /* cmp word [eax+0x8], 0x17 */
            ii(0x100a_59fe, 2);  if(jnz(0x100a_5a02, 2)) goto l_0x100a_5a02;/* jnz 0x100a5a02 */
        l_0x100a_5a00:
            ii(0x100a_5a00, 2);  jmp(0x100a_5a0c, 0xa); goto l_0x100a_5a0c;/* jmp 0x100a5a0c */
        l_0x100a_5a02:
            ii(0x100a_5a02, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_5a05, 5);  cmp(memw[ds, eax + 8], 0x1b);         /* cmp word [eax+0x8], 0x1b */
            ii(0x100a_5a0a, 2);  if(jnz(0x100a_5a0e, 2)) goto l_0x100a_5a0e;/* jnz 0x100a5a0e */
        l_0x100a_5a0c:
            ii(0x100a_5a0c, 2);  jmp(0x100a_5a18, 0xa); goto l_0x100a_5a18;/* jmp 0x100a5a18 */
        l_0x100a_5a0e:
            ii(0x100a_5a0e, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_5a11, 5);  cmp(memw[ds, eax + 8], 0x20);         /* cmp word [eax+0x8], 0x20 */
            ii(0x100a_5a16, 2);  if(jnz(0x100a_5a1a, 2)) goto l_0x100a_5a1a;/* jnz 0x100a5a1a */
        l_0x100a_5a18:
            ii(0x100a_5a18, 2);  jmp(0x100a_5a24, 0xa); goto l_0x100a_5a24;/* jmp 0x100a5a24 */
        l_0x100a_5a1a:
            ii(0x100a_5a1a, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_5a1d, 5);  cmp(memw[ds, eax + 8], 0x31);         /* cmp word [eax+0x8], 0x31 */
            ii(0x100a_5a22, 2);  if(jnz(0x100a_5a26, 2)) goto l_0x100a_5a26;/* jnz 0x100a5a26 */
        l_0x100a_5a24:
            ii(0x100a_5a24, 2);  jmp(0x100a_5a30, 0xa); goto l_0x100a_5a30;/* jmp 0x100a5a30 */
        l_0x100a_5a26:
            ii(0x100a_5a26, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_5a29, 5);  cmp(memw[ds, eax + 8], 0x3d);         /* cmp word [eax+0x8], 0x3d */
            ii(0x100a_5a2e, 2);  if(jnz(0x100a_5a9b, 0x6b)) goto l_0x100a_5a9b;/* jnz 0x100a5a9b */
        l_0x100a_5a30:
            ii(0x100a_5a30, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_5a33, 3);  add(eax, 0xa);                        /* add eax, 0xa */
            ii(0x100a_5a36, 5);  call(0x100a_b0ac, 0x5671);            /* call 0x100ab0ac */
            ii(0x100a_5a3b, 3);  lea(ebx, memd[ss, ebp - 16]);         /* lea ebx, [ebp-0x10] */
            ii(0x100a_5a3e, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100a_5a40, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x100a_5a42, 5);  call(0x100a_af44, 0x54fd);            /* call 0x100aaf44 */
            ii(0x100a_5a47, 2);  jmp(0x100a_5a51, 8); goto l_0x100a_5a51;/* jmp 0x100a5a51 */
        l_0x100a_5a49:
            ii(0x100a_5a49, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x100a_5a4c, 5);  call(0x1007_6bf8, -0x2_ee59);         /* call 0x10076bf8 */
        l_0x100a_5a51:
            ii(0x100a_5a51, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100a_5a53, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x100a_5a56, 5);  call(0x1013_ad71, 0x9_5316);          /* call 0x1013ad71 */
            ii(0x100a_5a5b, 2);  test(al, al);                         /* test al, al */
            ii(0x100a_5a5d, 2);  if(jz(0x100a_5a9b, 0x3c)) goto l_0x100a_5a9b;/* jz 0x100a5a9b */
            ii(0x100a_5a5f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_5a62, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100a_5a64, 3);  mov(dl, memb[ds, eax + 38]);          /* mov dl, [eax+0x26] */
            ii(0x100a_5a67, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x100a_5a6a, 5);  call(0x100a_aedc, 0x546d);            /* call 0x100aaedc */
            ii(0x100a_5a6f, 5);  call(0x1008_ad90, -0x1_ace4);         /* call 0x1008ad90 */
            ii(0x100a_5a74, 1);  cwde();                               /* cwde */
            ii(0x100a_5a75, 2);  cmp(eax, edx);                        /* cmp eax, edx */
            ii(0x100a_5a77, 2);  if(jnz(0x100a_5a99, 0x20)) goto l_0x100a_5a99;/* jnz 0x100a5a99 */
            ii(0x100a_5a79, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x100a_5a7c, 5);  call(0x100a_aedc, 0x545b);            /* call 0x100aaedc */
            ii(0x100a_5a81, 6);  mov(memd[ss, ebp - 408], eax);        /* mov [ebp-0x198], eax */
            ii(0x100a_5a87, 6);  mov(eax, memd[ss, ebp - 408]);        /* mov eax, [ebp-0x198] */
            ii(0x100a_5a8d, 3);  mov(edx, memd[ds, eax + 2]);          /* mov edx, [eax+0x2] */
            ii(0x100a_5a90, 6);  mov(eax, memd[ss, ebp - 408]);        /* mov eax, [ebp-0x198] */
            ii(0x100a_5a96, 3);  call_abs(memd[ds, edx + 48]);         /* call dword [edx+0x30] */
        l_0x100a_5a99:
            ii(0x100a_5a99, 2);  jmp(0x100a_5a49, -0x52); goto l_0x100a_5a49;/* jmp 0x100a5a49 */
        l_0x100a_5a9b:
            ii(0x100a_5a9b, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_5a9e, 5);  call(0x1008_aef4, -0x1_abaf);         /* call 0x1008aef4 */
            ii(0x100a_5aa3, 6);  lea(ebx, memd[ss, ebp - 412]);        /* lea ebx, [ebp-0x19c] */
            ii(0x100a_5aa9, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100a_5aab, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x100a_5aad, 5);  call(0x1008_ae70, -0x1_ac42);         /* call 0x1008ae70 */
            ii(0x100a_5ab2, 4);  or(memb[ss, ebp - 12], 1);            /* or byte [ebp-0xc], 0x1 */
            ii(0x100a_5ab6, 6);  lea(eax, memd[ss, ebp - 416]);        /* lea eax, [ebp-0x1a0] */
            ii(0x100a_5abc, 5);  call(Definitions.my_ctor_0x101b_3b58, -0x1_aa1d);/* call 0x1008b0a4 */
            ii(0x100a_5ac1, 6);  mov(memd[ss, ebp - 420], eax);        /* mov [ebp-0x1a4], eax */
            ii(0x100a_5ac7, 4);  and(memb[ss, ebp - 12], -2 /* 0xfe */);/* and byte [ebp-0xc], 0xfe */
            ii(0x100a_5acb, 2);  jmp(0x100a_5ad8, 0xb); goto l_0x100a_5ad8;/* jmp 0x100a5ad8 */
        l_0x100a_5acd:
            ii(0x100a_5acd, 6);  lea(eax, memd[ss, ebp - 412]);        /* lea eax, [ebp-0x19c] */
            ii(0x100a_5ad3, 5);  call(0x1007_6bf8, -0x2_eee0);         /* call 0x10076bf8 */
        l_0x100a_5ad8:
            ii(0x100a_5ad8, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100a_5ada, 6);  lea(eax, memd[ss, ebp - 412]);        /* lea eax, [ebp-0x19c] */
            ii(0x100a_5ae0, 5);  call(0x1013_ad71, 0x9_528c);          /* call 0x1013ad71 */
            ii(0x100a_5ae5, 2);  test(al, al);                         /* test al, al */
            ii(0x100a_5ae7, 6);  if(jz(0x100a_5bef, 0x102)) goto l_0x100a_5bef;/* jz 0x100a5bef */
            ii(0x100a_5aed, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_5af0, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100a_5af2, 3);  mov(dl, memb[ds, eax + 38]);          /* mov dl, [eax+0x26] */
            ii(0x100a_5af5, 6);  lea(eax, memd[ss, ebp - 412]);        /* lea eax, [ebp-0x19c] */
            ii(0x100a_5afb, 5);  call(0x1008_adc4, -0x1_ad3c);         /* call 0x1008adc4 */
            ii(0x100a_5b00, 5);  call(0x1008_ad90, -0x1_ad75);         /* call 0x1008ad90 */
            ii(0x100a_5b05, 1);  cwde();                               /* cwde */
            ii(0x100a_5b06, 2);  cmp(eax, edx);                        /* cmp eax, edx */
            ii(0x100a_5b08, 2);  if(jnz(0x100a_5b34, 0x2a)) goto l_0x100a_5b34;/* jnz 0x100a5b34 */
            ii(0x100a_5b0a, 6);  lea(eax, memd[ss, ebp - 412]);        /* lea eax, [ebp-0x19c] */
            ii(0x100a_5b10, 5);  call(0x1008_adc4, -0x1_ad51);         /* call 0x1008adc4 */
            ii(0x100a_5b15, 6);  mov(memd[ss, ebp - 424], eax);        /* mov [ebp-0x1a8], eax */
            ii(0x100a_5b1b, 6);  mov(eax, memd[ss, ebp - 424]);        /* mov eax, [ebp-0x1a8] */
            ii(0x100a_5b21, 3);  mov(ebx, memd[ds, eax + 2]);          /* mov ebx, [eax+0x2] */
            ii(0x100a_5b24, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100a_5b27, 6);  mov(eax, memd[ss, ebp - 424]);        /* mov eax, [ebp-0x1a8] */
            ii(0x100a_5b2d, 3);  call_abs(memd[ds, ebx + 8]);          /* call dword [ebx+0x8] */
            ii(0x100a_5b30, 2);  test(al, al);                         /* test al, al */
            ii(0x100a_5b32, 2);  if(jnz(0x100a_5b39, 5)) goto l_0x100a_5b39;/* jnz 0x100a5b39 */
        l_0x100a_5b34:
            ii(0x100a_5b34, 5);  jmp(0x100a_5bea, 0xb1); goto l_0x100a_5bea;/* jmp 0x100a5bea */
        l_0x100a_5b39:
            ii(0x100a_5b39, 6);  lea(eax, memd[ss, ebp - 412]);        /* lea eax, [ebp-0x19c] */
            ii(0x100a_5b3f, 5);  call(0x1008_adc4, -0x1_ad80);         /* call 0x1008adc4 */
            ii(0x100a_5b44, 6);  mov(memd[ss, ebp - 428], eax);        /* mov [ebp-0x1ac], eax */
            ii(0x100a_5b4a, 6);  mov(eax, memd[ss, ebp - 428]);        /* mov eax, [ebp-0x1ac] */
            ii(0x100a_5b50, 3);  mov(ebx, memd[ds, eax + 2]);          /* mov ebx, [eax+0x2] */
            ii(0x100a_5b53, 6);  lea(edx, memd[ss, ebp - 444]);        /* lea edx, [ebp-0x1bc] */
            ii(0x100a_5b59, 6);  mov(eax, memd[ss, ebp - 428]);        /* mov eax, [ebp-0x1ac] */
            ii(0x100a_5b5f, 3);  call_abs(memd[ds, ebx + 28]);         /* call dword [ebx+0x1c] */
            ii(0x100a_5b62, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_5b65, 4);  mov(dx, memw[ds, eax + 28]);          /* mov dx, [eax+0x1c] */
            ii(0x100a_5b69, 6);  sub(edx, memd[ss, ebp - 440]);        /* sub edx, [ebp-0x1b8] */
            ii(0x100a_5b6f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_5b72, 4);  mov(ax, memw[ds, eax + 28]);          /* mov ax, [eax+0x1c] */
            ii(0x100a_5b76, 6);  sub(eax, memd[ss, ebp - 440]);        /* sub eax, [ebp-0x1b8] */
            ii(0x100a_5b7c, 3);  imul(edx, eax);                       /* imul edx, eax */
            ii(0x100a_5b7f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_5b82, 4);  mov(bx, memw[ds, eax + 26]);          /* mov bx, [eax+0x1a] */
            ii(0x100a_5b86, 6);  sub(ebx, memd[ss, ebp - 444]);        /* sub ebx, [ebp-0x1bc] */
            ii(0x100a_5b8c, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_5b8f, 4);  mov(ax, memw[ds, eax + 26]);          /* mov ax, [eax+0x1a] */
            ii(0x100a_5b93, 6);  sub(eax, memd[ss, ebp - 444]);        /* sub eax, [ebp-0x1bc] */
            ii(0x100a_5b99, 3);  imul(eax, ebx);                       /* imul eax, ebx */
            ii(0x100a_5b9c, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x100a_5b9e, 6);  mov(memd[ss, ebp - 448], eax);        /* mov [ebp-0x1c0], eax */
            ii(0x100a_5ba4, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100a_5ba6, 6);  lea(eax, memd[ss, ebp - 416]);        /* lea eax, [ebp-0x1a0] */
            ii(0x100a_5bac, 5);  call(0x1013_ad11, 0x9_5160);          /* call 0x1013ad11 */
            ii(0x100a_5bb1, 2);  test(al, al);                         /* test al, al */
            ii(0x100a_5bb3, 2);  if(jnz(0x100a_5bc4, 0xf)) goto l_0x100a_5bc4;/* jnz 0x100a5bc4 */
            ii(0x100a_5bb5, 6);  mov(eax, memd[ss, ebp - 448]);        /* mov eax, [ebp-0x1c0] */
            ii(0x100a_5bbb, 7);  cmp(ax, memw[ss, ebp - 452]);         /* cmp ax, [ebp-0x1c4] */
            ii(0x100a_5bc2, 2);  if(jge(0x100a_5bea, 0x26)) goto l_0x100a_5bea;/* jge 0x100a5bea */
        l_0x100a_5bc4:
            ii(0x100a_5bc4, 6);  lea(eax, memd[ss, ebp - 412]);        /* lea eax, [ebp-0x19c] */
            ii(0x100a_5bca, 5);  call(0x1008_adf8, -0x1_add7);         /* call 0x1008adf8 */
            ii(0x100a_5bcf, 6);  lea(ebx, memd[ss, ebp - 416]);        /* lea ebx, [ebp-0x1a0] */
            ii(0x100a_5bd5, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100a_5bd7, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x100a_5bd9, 5);  call(0x1008_afe4, -0x1_abfa);         /* call 0x1008afe4 */
            ii(0x100a_5bde, 6);  mov(eax, memd[ss, ebp - 448]);        /* mov eax, [ebp-0x1c0] */
            ii(0x100a_5be4, 6);  mov(memd[ss, ebp - 452], eax);        /* mov [ebp-0x1c4], eax */
        l_0x100a_5bea:
            ii(0x100a_5bea, 5);  jmp(0x100a_5acd, -0x122); goto l_0x100a_5acd;/* jmp 0x100a5acd */
        l_0x100a_5bef:
            ii(0x100a_5bef, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100a_5bf1, 6);  lea(eax, memd[ss, ebp - 416]);        /* lea eax, [ebp-0x1a0] */
            ii(0x100a_5bf7, 5);  call(0x1013_ad71, 0x9_5175);          /* call 0x1013ad71 */
            ii(0x100a_5bfc, 2);  test(al, al);                         /* test al, al */
            ii(0x100a_5bfe, 2);  if(jz(0x100a_5c26, 0x26)) goto l_0x100a_5c26;/* jz 0x100a5c26 */
            ii(0x100a_5c00, 6);  lea(eax, memd[ss, ebp - 416]);        /* lea eax, [ebp-0x1a0] */
            ii(0x100a_5c06, 5);  call(0x1008_af28, -0x1_ace3);         /* call 0x1008af28 */
            ii(0x100a_5c0b, 6);  mov(memd[ss, ebp - 456], eax);        /* mov [ebp-0x1c8], eax */
            ii(0x100a_5c11, 6);  mov(eax, memd[ss, ebp - 456]);        /* mov eax, [ebp-0x1c8] */
            ii(0x100a_5c17, 3);  mov(ebx, memd[ds, eax + 2]);          /* mov ebx, [eax+0x2] */
            ii(0x100a_5c1a, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100a_5c1d, 6);  mov(eax, memd[ss, ebp - 456]);        /* mov eax, [ebp-0x1c8] */
            ii(0x100a_5c23, 3);  call_abs(memd[ds, ebx + 44]);         /* call dword [ebx+0x2c] */
        l_0x100a_5c26:
            ii(0x100a_5c26, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100a_5c28, 6);  lea(eax, memd[ss, ebp - 416]);        /* lea eax, [ebp-0x1a0] */
            ii(0x100a_5c2e, 5);  call(0x1008_8b7c, -0x1_d0b7);         /* call 0x10088b7c */
            ii(0x100a_5c33, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100a_5c35, 6);  lea(eax, memd[ss, ebp - 412]);        /* lea eax, [ebp-0x19c] */
            ii(0x100a_5c3b, 5);  call(0x1008_8bbc, -0x1_d084);         /* call 0x10088bbc */
        l_0x100a_5c40:
            ii(0x100a_5c40, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100a_5c42, 6);  lea(eax, memd[ss, ebp - 388]);        /* lea eax, [ebp-0x184] */
            ii(0x100a_5c48, 5);  call(0x1008_8bbc, -0x1_d091);         /* call 0x10088bbc */
            ii(0x100a_5c4d, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100a_5c4f, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100a_5c52, 5);  call(0x1008_8cbc, -0x1_cf9b);         /* call 0x10088cbc */
            ii(0x100a_5c57, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100a_5c59, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x100a_5c5c, 5);  call(0x100a_a070, 0x440f);            /* call 0x100aa070 */
        l_0x100a_5c61:
            ii(0x100a_5c61, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100a_5c63, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100a_5c64, 1);  pop(edi);                             /* pop edi */
            ii(0x100a_5c65, 1);  pop(esi);                             /* pop esi */
            ii(0x100a_5c66, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100a_5c67, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100a_5c68, 1);  ret();                                /* ret */
        }
    }
}
