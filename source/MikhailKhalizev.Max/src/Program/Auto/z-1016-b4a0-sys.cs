using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_b4a0-1ade7253")]
        public void /* sys */ Method_1016_b4a0()
        {
            ii(0x1016_b4a0, 1);  push(ebx);                            /* push ebx */
            ii(0x1016_b4a1, 1);  push(ecx);                            /* push ecx */
            ii(0x1016_b4a2, 1);  push(edx);                            /* push edx */
            ii(0x1016_b4a3, 1);  push(esi);                            /* push esi */
            ii(0x1016_b4a4, 1);  push(edi);                            /* push edi */
            ii(0x1016_b4a5, 1);  push(ebp);                            /* push ebp */
            ii(0x1016_b4a6, 5);  mov(eax, StringDefinitions.Paused);   /* mov eax, 0x101b2df4 */
            ii(0x1016_b4ab, 6);  call_abs(memd[ds, 0x101b_ddf4]);      /* call dword [0x101bddf4] */ /* Вызов '0x1016_a4d0'. */
            ii(0x1016_b4b1, 3);  lea(edi, memd[ds, eax + 32]);         /* lea edi, [eax+0x20] */
            ii(0x1016_b4b4, 6);  call_abs(memd[ds, 0x101b_ddf0]);      /* call dword [0x101bddf0] */ /* Вызов '0x1016_a4c4'. */
            ii(0x1016_b4ba, 7);  lea(esi, memd[ds, eax * 4]);          /* lea esi, [eax*4] */
            ii(0x1016_b4c1, 6);  mov(edx, memd[ds, 0x1020_88e4]);      /* mov edx, [0x102088e4] */
            ii(0x1016_b4c7, 2);  sub(esi, eax);                        /* sub esi, eax */
            ii(0x1016_b4c9, 5);  mov(eax, memd[ds, 0x1020_88ec]);      /* mov eax, [0x102088ec] */
            ii(0x1016_b4ce, 2);  sub(eax, edx);                        /* sub eax, edx */
            ii(0x1016_b4d0, 3);  lea(ebp, memd[ds, esi + 16]);         /* lea ebp, [esi+0x10] */
            ii(0x1016_b4d3, 3);  lea(edx, memd[ds, eax + 1]);          /* lea edx, [eax+0x1] */
            ii(0x1016_b4d6, 2);  sub(edx, ebp);                        /* sub edx, ebp */
            ii(0x1016_b4d8, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x1016_b4da, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x1016_b4dd, 2);  sub(eax, edx);                        /* sub eax, edx */
            ii(0x1016_b4df, 2);  sar(eax, 1);                          /* sar eax, 1 */
            ii(0x1016_b4e1, 6);  mov(ebx, memd[ds, 0x1020_88e0]);      /* mov ebx, [0x102088e0] */
            ii(0x1016_b4e7, 6);  mov(edx, memd[ds, 0x1020_88e8]);      /* mov edx, [0x102088e8] */
            ii(0x1016_b4ed, 2);  sub(edx, ebx);                        /* sub edx, ebx */
            ii(0x1016_b4ef, 1);  inc(edx);                             /* inc edx */
            ii(0x1016_b4f0, 2);  sub(edx, edi);                        /* sub edx, edi */
            ii(0x1016_b4f2, 2);  mov(esi, eax);                        /* mov esi, eax */
            ii(0x1016_b4f4, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x1016_b4f6, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x1016_b4f9, 2);  sub(eax, edx);                        /* sub eax, edx */
            ii(0x1016_b4fb, 2);  sar(eax, 1);                          /* sar eax, 1 */
            ii(0x1016_b4fd, 2);  push(0x14);                           /* push 0x14 */
            ii(0x1016_b4ff, 5);  push(0x100);                          /* push 0x100 */
            ii(0x1016_b504, 2);  mov(ecx, ebp);                        /* mov ecx, ebp */
            ii(0x1016_b506, 2);  mov(ebx, edi);                        /* mov ebx, edi */
            ii(0x1016_b508, 2);  mov(edx, esi);                        /* mov edx, esi */
            ii(0x1016_b50a, 5);  call(/* sys */ 0x1016_6764, -0x4dab); /* call 0x10166764 */
            ii(0x1016_b50f, 2);  mov(esi, eax);                        /* mov esi, eax */
            ii(0x1016_b511, 3);  cmp(eax, -1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x1016_b514, 2);  if(jz(0x1016_b593, 0x7d)) goto l_0x1016_b593;/* jz 0x1016b593 */
            ii(0x1016_b516, 5);  call(/* sys */ 0x1016_6a90, -0x4a8b); /* call 0x10166a90 */
            ii(0x1016_b51b, 7);  lea(edx, memd[ds, edi * 8]);          /* lea edx, [edi*8] */
            ii(0x1016_b522, 2);  mov(eax, esi);                        /* mov eax, esi */
            ii(0x1016_b524, 3);  lea(ebx, memd[ds, edx + 16]);         /* lea ebx, [edx+0x10] */
            ii(0x1016_b527, 5);  call(/* sys */ 0x1016_7dd4, -0x3758); /* call 0x10167dd4 */
            ii(0x1016_b52c, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1016_b52e, 2);  mov(ecx, edi);                        /* mov ecx, edi */
            ii(0x1016_b530, 6);  mov(dl, memb[ds, 0x1020_8120]);       /* mov dl, [0x10208120] */
            ii(0x1016_b536, 2);  add(eax, ebx);                        /* add eax, ebx */
            ii(0x1016_b538, 1);  push(edx);                            /* push edx */
            ii(0x1016_b539, 2);  mov(ebx, edi);                        /* mov ebx, edi */
            ii(0x1016_b53b, 5);  mov(edx, StringDefinitions.Paused);   /* mov edx, 0x101b2df4 */
            ii(0x1016_b540, 6);  call_abs(memd[ds, 0x101b_ddec]);      /* call dword [0x101bddec] */ /* Вызов '0x1016_a320'. */
            ii(0x1016_b546, 2);  push(0);                              /* push 0x0 */
            ii(0x1016_b548, 5);  push(StringDefinitions.Done11);       /* push 0x101b2dfc */
            ii(0x1016_b54d, 2);  push(0x1b);                           /* push 0x1b */
            ii(0x1016_b54f, 2);  push(-1 /* 0xff */);                  /* push 0xffffffff */
            ii(0x1016_b551, 2);  push(-1 /* 0xff */);                  /* push 0xffffffff */
            ii(0x1016_b553, 3);  lea(ebx, memd[ss, ebp - 8]);          /* lea ebx, [ebp-0x8] */
            ii(0x1016_b556, 6);  call_abs(memd[ds, 0x101b_ddf0]);      /* call dword [0x101bddf0] */ /* Вызов '0x1016_a4c4'. */
            ii(0x1016_b55c, 2);  sub(ebx, eax);                        /* sub ebx, eax */
            ii(0x1016_b55e, 5);  mov(eax, StringDefinitions.Done11);   /* mov eax, 0x101b2dfc */
            ii(0x1016_b563, 2);  mov(edx, edi);                        /* mov edx, edi */
            ii(0x1016_b565, 6);  call_abs(memd[ds, 0x101b_ddf4]);      /* call dword [0x101bddf4] */ /* Вызов '0x1016_a4d0'. */
            ii(0x1016_b56b, 2);  sub(edx, eax);                        /* sub edx, eax */
            ii(0x1016_b56d, 3);  sub(edx, 0x10);                       /* sub edx, 0x10 */
            ii(0x1016_b570, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x1016_b572, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x1016_b575, 2);  sub(eax, edx);                        /* sub eax, edx */
            ii(0x1016_b577, 2);  sar(eax, 1);                          /* sar eax, 1 */
            ii(0x1016_b579, 5);  mov(ecx, 0xffff_ffff);                /* mov ecx, 0xffffffff */
            ii(0x1016_b57e, 3);  sub(ebx, 6);                          /* sub ebx, 0x6 */
            ii(0x1016_b581, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1016_b583, 2);  mov(eax, esi);                        /* mov eax, esi */
            ii(0x1016_b585, 5);  call(/* sys */ 0x1016_8754, -0x2e36); /* call 0x10168754 */
            ii(0x1016_b58a, 2);  mov(eax, esi);                        /* mov eax, esi */
            ii(0x1016_b58c, 5);  call(Definitions.sys_display_draw_0, -0x410d);/* call 0x10167484 */
            ii(0x1016_b591, 2);  mov(eax, esi);                        /* mov eax, esi */
        l_0x1016_b593:
            ii(0x1016_b593, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1016_b594, 1);  pop(edi);                             /* pop edi */
            ii(0x1016_b595, 1);  pop(esi);                             /* pop esi */
            ii(0x1016_b596, 1);  pop(edx);                             /* pop edx */
            ii(0x1016_b597, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1016_b598, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1016_b599, 1);  ret();                                /* ret */
        }
    }
}
