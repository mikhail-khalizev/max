using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_c999-37c8ffb1")]
        public void Method_1008_c999()
        {
            ii(0x1008_c999, 5);  push(0x3c);                           /* push 0x3c */
            ii(0x1008_c99e, 5);  call(Definitions.sys_check_available_stack_size, 0xd_93af);/* call 0x10165d52 */
            ii(0x1008_c9a3, 1);  push(esi);                            /* push esi */
            ii(0x1008_c9a4, 1);  push(edi);                            /* push edi */
            ii(0x1008_c9a5, 1);  push(ebp);                            /* push ebp */
            ii(0x1008_c9a6, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1008_c9a8, 6);  sub(esp, 0x2c);                       /* sub esp, 0x2c */
            ii(0x1008_c9ae, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1008_c9b1, 3);  mov(memd[ss, ebp - 12], edx);         /* mov [ebp-0xc], edx */
            ii(0x1008_c9b4, 3);  mov(memd[ss, ebp - 8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x1008_c9b7, 3);  mov(memd[ss, ebp - 4], ecx);          /* mov [ebp-0x4], ecx */
            ii(0x1008_c9ba, 4);  movsx(ecx, memw[ss, ebp - 4]);        /* movsx ecx, word [ebp-0x4] */
            ii(0x1008_c9be, 4);  movsx(ebx, memw[ss, ebp - 8]);        /* movsx ebx, word [ebp-0x8] */
            ii(0x1008_c9c2, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1008_c9c5, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1008_c9c8, 5);  call(0x1008_c772, -0x25b);            /* call 0x1008c772 */
            ii(0x1008_c9cd, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1008_c9d0, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x1008_c9d3, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1008_c9d6, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1008_c9d9, 3);  add(eax, 0x19);                       /* add eax, 0x19 */
            ii(0x1008_c9dc, 5);  call(Definitions.my_ctor_0x101b_38f8, -0x1_62f1);/* call 0x100766f0 */
            ii(0x1008_c9e1, 3);  sub(eax, 0x19);                       /* sub eax, 0x19 */
            ii(0x1008_c9e4, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1008_c9e7, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x1008_c9ea, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x1008_c9ed, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1008_c9f0, 3);  add(eax, 0x1d);                       /* add eax, 0x1d */
            ii(0x1008_c9f3, 5);  call(Definitions.my_ctor_0x101b_3b58, -0x1954);/* call 0x1008b0a4 */
            ii(0x1008_c9f8, 3);  sub(eax, 0x1d);                       /* sub eax, 0x1d */
            ii(0x1008_c9fb, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1008_c9fe, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x1008_ca01, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1008_ca04, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1008_ca07, 3);  add(eax, 0x21);                       /* add eax, 0x21 */
            ii(0x1008_ca0a, 5);  call(Definitions.my_ctor_0x101b_4184, -0x1_5f1f);/* call 0x10076af0 */
            ii(0x1008_ca0f, 3);  sub(eax, 0x21);                       /* sub eax, 0x21 */
            ii(0x1008_ca12, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1008_ca15, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1008_ca18, 3);  add(eax, 0x26);                       /* add eax, 0x26 */
            ii(0x1008_ca1b, 5);  call(0x1009_c930, 0xff10);            /* call 0x1009c930 */
            ii(0x1008_ca20, 3);  sub(eax, 0x26);                       /* sub eax, 0x26 */
            ii(0x1008_ca23, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1008_ca26, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x1008_ca29, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x1008_ca2c, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1008_ca2f, 3);  add(eax, 0x2b);                       /* add eax, 0x2b */
            ii(0x1008_ca32, 5);  call(0x1009_ca70, 0x1_0039);          /* call 0x1009ca70 */
            ii(0x1008_ca37, 3);  sub(eax, 0x2b);                       /* sub eax, 0x2b */
            ii(0x1008_ca3a, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1008_ca3d, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x1008_ca40, 3);  mov(memd[ss, ebp - 36], eax);         /* mov [ebp-0x24], eax */
            ii(0x1008_ca43, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1008_ca46, 7);  mov(memd[ds, eax + 2], 0x101b_467c);  /* mov dword [eax+0x2], 0x101b467c */
            ii(0x1008_ca4d, 3);  mov(edx, memd[ss, ebp + 16]);         /* mov edx, [ebp+0x10] */
            ii(0x1008_ca50, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1008_ca53, 3);  add(eax, 0x21);                       /* add eax, 0x21 */
            ii(0x1008_ca56, 5);  call(0x1008_8b44, -0x3f17);           /* call 0x10088b44 */
            ii(0x1008_ca5b, 3);  mov(edx, memd[ss, ebp + 20]);         /* mov edx, [ebp+0x14] */
            ii(0x1008_ca5e, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1008_ca61, 3);  add(eax, 0x1d);                       /* add eax, 0x1d */
            ii(0x1008_ca64, 5);  call(0x1008_afe4, -0x1a85);           /* call 0x1008afe4 */
            ii(0x1008_ca69, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1008_ca6c, 4);  mov(memb[ds, eax + 42], 0);           /* mov byte [eax+0x2a], 0x0 */
            ii(0x1008_ca70, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1008_ca73, 4);  mov(memb[ds, eax + 37], 0);           /* mov byte [eax+0x25], 0x0 */
            ii(0x1008_ca77, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1008_ca7a, 3);  mov(eax, memd[ds, eax + 31]);         /* mov eax, [eax+0x1f] */
            ii(0x1008_ca7d, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1008_ca80, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1008_ca82, 2);  if(jl(0x1008_ca94, 0x10)) goto l_0x1008_ca94;/* jl 0x1008ca94 */
            ii(0x1008_ca84, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1008_ca87, 4);  mov(ax, memw[ds, eax + 33]);          /* mov ax, [eax+0x21] */
            ii(0x1008_ca8b, 7);  cmp(ax, memw[ds, 0x101c_8172]);       /* cmp ax, [0x101c8172] */
            ii(0x1008_ca92, 2);  if(jl(0x1008_ca96, 2)) goto l_0x1008_ca96;/* jl 0x1008ca96 */
        l_0x1008_ca94:
            ii(0x1008_ca94, 2);  jmp(0x1008_caa3, 0xd); goto l_0x1008_caa3;/* jmp 0x1008caa3 */
        l_0x1008_ca96:
            ii(0x1008_ca96, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1008_ca99, 3);  mov(eax, memd[ds, eax + 33]);         /* mov eax, [eax+0x21] */
            ii(0x1008_ca9c, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1008_ca9f, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1008_caa1, 2);  if(jge(0x1008_caa5, 2)) goto l_0x1008_caa5;/* jge 0x1008caa5 */
        l_0x1008_caa3:
            ii(0x1008_caa3, 2);  jmp(0x1008_cab5, 0x10); goto l_0x1008_cab5;/* jmp 0x1008cab5 */
        l_0x1008_caa5:
            ii(0x1008_caa5, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1008_caa8, 4);  mov(ax, memw[ds, eax + 35]);          /* mov ax, [eax+0x23] */
            ii(0x1008_caac, 7);  cmp(ax, memw[ds, 0x101c_8174]);       /* cmp ax, [0x101c8174] */
            ii(0x1008_cab3, 2);  if(jl(0x1008_cab7, 2)) goto l_0x1008_cab7;/* jl 0x1008cab7 */
        l_0x1008_cab5:
            ii(0x1008_cab5, 2);  jmp(0x1008_cac0, 9); goto l_0x1008_cac0;/* jmp 0x1008cac0 */
        l_0x1008_cab7:
            ii(0x1008_cab7, 7);  mov(memd[ss, ebp - 40], 0);           /* mov dword [ebp-0x28], 0x0 */
            ii(0x1008_cabe, 2);  jmp(0x1008_cad9, 0x19); goto l_0x1008_cad9;/* jmp 0x1008cad9 */
        l_0x1008_cac0:
            ii(0x1008_cac0, 5);  mov(ecx, 0x1f4);                      /* mov ecx, 0x1f4 */
            ii(0x1008_cac5, 5);  mov(ebx, StringDefinitions.AiBuildCpp);/* mov ebx, 0x101a0426 */
            ii(0x1008_caca, 5);  mov(edx, StringDefinitions.SiteXGreaterOrEqual0SiteXLessMapxdimSiteYGreaterOrEqual0SiteYLessMapydim);/* mov edx, 0x101a0433 */
            ii(0x1008_cacf, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1008_cad1, 5);  call(Definitions.sys_assert, 0xd_92bc);/* call 0x10165d92 */
            ii(0x1008_cad6, 3);  mov(memd[ss, ebp - 40], eax);         /* mov [ebp-0x28], eax */
        l_0x1008_cad9:
            ii(0x1008_cad9, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1008_cadc, 3);  mov(memd[ss, ebp - 44], eax);         /* mov [ebp-0x2c], eax */
            ii(0x1008_cadf, 3);  mov(eax, memd[ss, ebp - 44]);         /* mov eax, [ebp-0x2c] */
            ii(0x1008_cae2, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1008_cae4, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1008_cae5, 1);  pop(edi);                             /* pop edi */
            ii(0x1008_cae6, 1);  pop(esi);                             /* pop esi */
            ii(0x1008_cae7, 3);  ret(8);                               /* ret 0x8 */
        }
    }
}
