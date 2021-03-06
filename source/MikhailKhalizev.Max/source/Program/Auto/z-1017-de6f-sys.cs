using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_de6f-95178196")]
        public void /* sys */ Method_1017_de6f()
        {
            ii(0x1017_de6f, 1);  push(ebx);                            /* push ebx */
            ii(0x1017_de70, 1);  push(ecx);                            /* push ecx */
            ii(0x1017_de71, 1);  push(edx);                            /* push edx */
            ii(0x1017_de72, 1);  push(esi);                            /* push esi */
            ii(0x1017_de73, 1);  push(edi);                            /* push edi */
            ii(0x1017_de74, 1);  push(ebp);                            /* push ebp */
            ii(0x1017_de75, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1017_de77, 6);  sub(esp, 0);                          /* sub esp, 0x0 */
            ii(0x1017_de7d, 6);  inc(memd[ds, 0x101c_09c8]);           /* inc dword [0x101c09c8] */
            ii(0x1017_de83, 10);  mov(memd[ds, 0x1020_a0d8], 0);       /* mov dword [0x1020a0d8], 0x0 */
        l_0x1017_de8d:
            ii(0x1017_de8d, 7);  cmp(memd[ds, 0x1020_a0d8], 0x10);     /* cmp dword [0x1020a0d8], 0x10 */
            ii(0x1017_de94, 2);  if(jb(0x1017_dea3, 0xd)) goto l_0x1017_dea3;/* jb 0x1017dea3 */
            ii(0x1017_de96, 5);  jmp(0x1017_df2c, 0x91); goto l_0x1017_df2c;/* jmp 0x1017df2c */
        l_0x1017_de9b:
            ii(0x1017_de9b, 6);  inc(memd[ds, 0x1020_a0d8]);           /* inc dword [0x1020a0d8] */
            ii(0x1017_dea1, 2);  jmp(0x1017_de8d, -0x16); goto l_0x1017_de8d;/* jmp 0x1017de8d */
        l_0x1017_dea3:
            ii(0x1017_dea3, 7);  imul(eax, memd[ds, 0x1020_a0d8], 6);  /* imul eax, [0x1020a0d8], 0x6 */
            ii(0x1017_deaa, 7);  cmp(memd[ds, eax + 0x101c_0699], 0);  /* cmp dword [eax+0x101c0699], 0x0 */
            ii(0x1017_deb1, 2);  if(jnz(0x1017_debd, 0xa)) goto l_0x1017_debd;/* jnz 0x1017debd */
            ii(0x1017_deb3, 8);  cmp(memw[ds, eax + 0x101c_069d], 0);  /* cmp word [eax+0x101c069d], 0x0 */
            ii(0x1017_debb, 2);  if(jz(0x1017_df27, 0x6a)) goto l_0x1017_df27;/* jz 0x1017df27 */
        l_0x1017_debd:
            ii(0x1017_debd, 5);  mov(eax, memd[ds, 0x1020_a0d8]);      /* mov eax, [0x1020a0d8] */
            ii(0x1017_dec2, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1017_dec5, 6);  mov(edx, memd[ds, 0x1020_a0d8]);      /* mov edx, [0x1020a0d8] */
            ii(0x1017_decb, 3);  shl(edx, 2);                          /* shl edx, 0x2 */
            ii(0x1017_dece, 6);  mov(edx, memd[ds, edx + 0x101c_0739]);/* mov edx, [edx+0x101c0739] */
            ii(0x1017_ded4, 6);  add(memd[ds, eax + 0x101c_0779], edx);/* add [eax+0x101c0779], edx */
            ii(0x1017_deda, 5);  mov(eax, memd[ds, 0x1020_a0d8]);      /* mov eax, [0x1020a0d8] */
            ii(0x1017_dedf, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1017_dee2, 7);  test(memb[ds, eax + 0x101c_077b], 1); /* test byte [eax+0x101c077b], 0x1 */
            ii(0x1017_dee9, 2);  if(jz(0x1017_df27, 0x3c)) goto l_0x1017_df27;/* jz 0x1017df27 */
            ii(0x1017_deeb, 5);  mov(eax, memd[ds, 0x1020_a0d8]);      /* mov eax, [0x1020a0d8] */
            ii(0x1017_def0, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1017_def3, 9);  mov(memw[ds, eax + 0x101c_077b], 0);  /* mov word [eax+0x101c077b], 0x0 */
            ii(0x1017_defc, 5);  mov(eax, memd[ds, 0x1020_a0d8]);      /* mov eax, [0x1020a0d8] */
            ii(0x1017_df01, 7);  cmp(memb[ds, eax + 0x101c_07b9], -1 /* 0xff */);/* cmp byte [eax+0x101c07b9], 0xff */
            ii(0x1017_df08, 2);  if(jz(0x1017_df1a, 0x10)) goto l_0x1017_df1a;/* jz 0x1017df1a */
            ii(0x1017_df0a, 5);  mov(eax, memd[ds, 0x1020_a0d8]);      /* mov eax, [0x1020a0d8] */
            ii(0x1017_df0f, 6);  mov(al, memb[ds, eax + 0x101c_07b9]); /* mov al, [eax+0x101c07b9] */
            ii(0x1017_df15, 5);  mov(memb[ds, 0x101c_07c9], al);       /* mov [0x101c07c9], al */
        l_0x1017_df1a:
            ii(0x1017_df1a, 7);  imul(eax, memd[ds, 0x1020_a0d8], 6);  /* imul eax, [0x1020a0d8], 0x6 */
            ii(0x1017_df21, 6);  if(call_far_ind_up(memd[ds, eax + 0x101c_0699])) return;/* call far dword [eax+0x101c0699] */
        l_0x1017_df27:
            ii(0x1017_df27, 5);  jmp(0x1017_de9b, -0x91); goto l_0x1017_de9b;/* jmp 0x1017de9b */
        l_0x1017_df2c:
            ii(0x1017_df2c, 6);  dec(memd[ds, 0x101c_09c8]);           /* dec dword [0x101c09c8] */
            ii(0x1017_df32, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1017_df33, 1);  pop(edi);                             /* pop edi */
            ii(0x1017_df34, 1);  pop(esi);                             /* pop esi */
            ii(0x1017_df35, 1);  pop(edx);                             /* pop edx */
            ii(0x1017_df36, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1017_df37, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1017_df38, 1);  retf();                               /* retf */
        }
    }
}
