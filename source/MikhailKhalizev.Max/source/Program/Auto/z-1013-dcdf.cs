using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_dcdf-36af3ac4")]
        public void Method_1013_dcdf()
        {
            ii(0x1013_dcdf, 5);  push(0x44);                           /* push 0x44 */
            ii(0x1013_dce4, 5);  call(Definitions.sys_check_available_stack_size, 0x2_8069);/* call 0x10165d52 */
            ii(0x1013_dce9, 1);  push(ebx);                            /* push ebx */
            ii(0x1013_dcea, 1);  push(ecx);                            /* push ecx */
            ii(0x1013_dceb, 1);  push(edx);                            /* push edx */
            ii(0x1013_dcec, 1);  push(esi);                            /* push esi */
            ii(0x1013_dced, 1);  push(edi);                            /* push edi */
            ii(0x1013_dcee, 1);  push(ebp);                            /* push ebp */
            ii(0x1013_dcef, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1013_dcf1, 6);  sub(esp, 0x28);                       /* sub esp, 0x28 */
            ii(0x1013_dcf7, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1013_dcfa, 6);  mov(edx, memd[ds, 0x101c_38dc]);      /* mov edx, [0x101c38dc] */
            ii(0x1013_dd00, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1013_dd03, 5);  mov(eax, memd[ds, 0x101c_38d8]);      /* mov eax, [0x101c38d8] */
            ii(0x1013_dd08, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1013_dd0b, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1013_dd0d, 2);  sar(eax, 1);                          /* sar eax, 1 */
            ii(0x1013_dd0f, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1013_dd12, 6);  mov(edx, memd[ds, 0x101c_38de]);      /* mov edx, [0x101c38de] */
            ii(0x1013_dd18, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1013_dd1b, 5);  mov(eax, memd[ds, 0x101c_38da]);      /* mov eax, [0x101c38da] */
            ii(0x1013_dd20, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1013_dd23, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1013_dd25, 2);  sar(eax, 1);                          /* sar eax, 1 */
            ii(0x1013_dd27, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1013_dd2a, 7);  mov(memd[ss, ebp - 16], 0x14);        /* mov dword [ebp-0x10], 0x14 */
        l_0x1013_dd31:
            ii(0x1013_dd31, 3);  dec(memd[ss, ebp - 16]);              /* dec dword [ebp-0x10] */
            ii(0x1013_dd34, 5);  cmp(memw[ss, ebp - 16], -1 /* 0xff */);/* cmp word [ebp-0x10], 0xffff */
            ii(0x1013_dd39, 6);  if(jz(0x1013_de3b, 0xfc)) goto l_0x1013_de3b;/* jz 0x1013de3b */
            ii(0x1013_dd3f, 4);  movsx(eax, memw[ss, ebp - 16]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1013_dd43, 6);  imul(eax, eax, 0x91);                 /* imul eax, eax, 0x91 */
            ii(0x1013_dd49, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1013_dd4c, 6);  add(edx, 0x251);                      /* add edx, 0x251 */
            ii(0x1013_dd52, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x1013_dd54, 3);  mov(memd[ss, ebp - 20], edx);         /* mov [ebp-0x14], edx */
            ii(0x1013_dd57, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1013_dd5a, 6);  cmp(memd[ds, eax], 0xffff);           /* cmp dword [eax], 0xffff */
            ii(0x1013_dd60, 2);  if(jz(0x1013_dd6b, 9)) goto l_0x1013_dd6b;/* jz 0x1013dd6b */
            ii(0x1013_dd62, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1013_dd65, 4);  cmp(memb[ds, eax + 6], 1);            /* cmp byte [eax+0x6], 0x1 */
            ii(0x1013_dd69, 2);  if(jle(0x1013_dd70, 5)) goto l_0x1013_dd70;/* jle 0x1013dd70 */
        l_0x1013_dd6b:
            ii(0x1013_dd6b, 5);  jmp(0x1013_de36, 0xc6); goto l_0x1013_de36;/* jmp 0x1013de36 */
        l_0x1013_dd70:
            ii(0x1013_dd70, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1013_dd73, 4);  mov(ax, memw[ds, eax + 7]);           /* mov ax, [eax+0x7] */
            ii(0x1013_dd77, 3);  sub(eax, memd[ss, ebp - 8]);          /* sub eax, [ebp-0x8] */
            ii(0x1013_dd7a, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x1013_dd7d, 4);  movsx(eax, memw[ss, ebp - 32]);       /* movsx eax, word [ebp-0x20] */
            ii(0x1013_dd81, 5);  call(/* sys */ 0x1016_5df8, 0x2_8072);/* call 0x10165df8 */
            ii(0x1013_dd86, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1013_dd89, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1013_dd8c, 3);  mov(eax, memd[ds, eax + 7]);          /* mov eax, [eax+0x7] */
            ii(0x1013_dd8f, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1013_dd92, 4);  movsx(edx, memw[ss, ebp - 12]);       /* movsx edx, word [ebp-0xc] */
            ii(0x1013_dd96, 2);  sub(eax, edx);                        /* sub eax, edx */
            ii(0x1013_dd98, 5);  call(/* sys */ 0x1016_5df8, 0x2_805b);/* call 0x10165df8 */
            ii(0x1013_dd9d, 3);  mov(memd[ss, ebp - 36], eax);         /* mov [ebp-0x24], eax */
            ii(0x1013_dda0, 4);  movsx(eax, memw[ss, ebp - 32]);       /* movsx eax, word [ebp-0x20] */
            ii(0x1013_dda4, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1013_dda6, 2);  if(jge(0x1013_ddae, 6)) goto l_0x1013_ddae;/* jge 0x1013ddae */
            ii(0x1013_dda8, 4);  mov(memb[ss, ebp - 24], 1);           /* mov byte [ebp-0x18], 0x1 */
            ii(0x1013_ddac, 2);  jmp(0x1013_ddb2, 4); goto l_0x1013_ddb2;/* jmp 0x1013ddb2 */
        l_0x1013_ddae:
            ii(0x1013_ddae, 4);  mov(memb[ss, ebp - 24], 0);           /* mov byte [ebp-0x18], 0x0 */
        l_0x1013_ddb2:
            ii(0x1013_ddb2, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1013_ddb4, 3);  mov(dl, memb[ss, ebp - 24]);          /* mov dl, [ebp-0x18] */
            ii(0x1013_ddb7, 4);  movsx(eax, memw[ss, ebp - 28]);       /* movsx eax, word [ebp-0x1c] */
            ii(0x1013_ddbb, 5);  call(0x1013_d45e, -0x962);            /* call 0x1013d45e */
            ii(0x1013_ddc0, 2);  mov(ebx, eax);                        /* mov ebx, eax */
            ii(0x1013_ddc2, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1013_ddc5, 2);  mov(edx, memd[ds, eax]);              /* mov edx, [eax] */
            ii(0x1013_ddc7, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_ddca, 3);  mov(eax, memd[ds, eax + 28]);         /* mov eax, [eax+0x1c] */
            ii(0x1013_ddcd, 5);  call(/* sys */ 0x1018_0a4a, 0x4_2c78);/* call 0x10180a4a */
            ii(0x1013_ddd2, 4);  movsx(edx, memw[ss, ebp - 36]);       /* movsx edx, word [ebp-0x24] */
            ii(0x1013_ddd6, 4);  movsx(eax, memw[ss, ebp - 28]);       /* movsx eax, word [ebp-0x1c] */
            ii(0x1013_ddda, 5);  call(0x1007_6e7c, -0xc_6f63);         /* call 0x10076e7c */
            ii(0x1013_dddf, 3);  mov(edx, memd[ss, ebp - 20]);         /* mov edx, [ebp-0x14] */
            ii(0x1013_dde2, 7);  imul(eax, memd[ds, edx + 131]);       /* imul eax, [edx+0x83] */
            ii(0x1013_dde9, 5);  mov(ebx, 0x70);                       /* mov ebx, 0x70 */
            ii(0x1013_ddee, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1013_ddf0, 2);  div(ebx);                             /* div ebx */
            ii(0x1013_ddf2, 3);  mov(edx, memd[ss, ebp - 20]);         /* mov edx, [ebp-0x14] */
            ii(0x1013_ddf5, 6);  mov(edx, memd[ds, edx + 131]);        /* mov edx, [edx+0x83] */
            ii(0x1013_ddfb, 2);  sub(edx, eax);                        /* sub edx, eax */
            ii(0x1013_ddfd, 3);  mov(memd[ss, ebp - 40], edx);         /* mov [ebp-0x28], edx */
            ii(0x1013_de00, 5);  mov(eax, 0x37);                       /* mov eax, 0x37 */
            ii(0x1013_de05, 5);  call(0x1007_5fdc, -0xc_7e2e);         /* call 0x10075fdc */
            ii(0x1013_de0a, 3);  mov(edx, memd[ss, ebp - 40]);         /* mov edx, [ebp-0x28] */
            ii(0x1013_de0d, 3);  imul(edx, eax);                       /* imul edx, eax */
            ii(0x1013_de10, 5);  mov(ebx, 0x64);                       /* mov ebx, 0x64 */
            ii(0x1013_de15, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x1013_de17, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x1013_de1a, 2);  idiv(ebx);                            /* idiv ebx */
            ii(0x1013_de1c, 3);  mov(memd[ss, ebp - 40], eax);         /* mov [ebp-0x28], eax */
            ii(0x1013_de1f, 3);  mov(ebx, memd[ss, ebp - 40]);         /* mov ebx, [ebp-0x28] */
            ii(0x1013_de22, 3);  mov(edx, memd[ss, ebp - 20]);         /* mov edx, [ebp-0x14] */
            ii(0x1013_de25, 2);  mov(eax, memd[ds, edx]);              /* mov eax, [edx] */
            ii(0x1013_de27, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1013_de2a, 3);  mov(ecx, memd[ds, edx + 28]);         /* mov ecx, [edx+0x1c] */
            ii(0x1013_de2d, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1013_de2f, 2);  mov(eax, ecx);                        /* mov eax, ecx */
            ii(0x1013_de31, 5);  call(/* sys */ 0x1018_07a7, 0x4_2971);/* call 0x101807a7 */
        l_0x1013_de36:
            ii(0x1013_de36, 5);  jmp(0x1013_dd31, -0x10a); goto l_0x1013_dd31;/* jmp 0x1013dd31 */
        l_0x1013_de3b:
            ii(0x1013_de3b, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1013_de3d, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1013_de3e, 1);  pop(edi);                             /* pop edi */
            ii(0x1013_de3f, 1);  pop(esi);                             /* pop esi */
            ii(0x1013_de40, 1);  pop(edx);                             /* pop edx */
            ii(0x1013_de41, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1013_de42, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1013_de43, 1);  ret();                                /* ret */
        }
    }
}
