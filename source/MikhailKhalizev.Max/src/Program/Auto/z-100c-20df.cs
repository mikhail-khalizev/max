using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_20df-74f4f693")]
        public void Method_100c_20df()
        {
            ii(0x100c_20df, 5); push(0x2c);                             /* push 0x2c */
            ii(0x100c_20e4, 5); call(Definitions.sys_check_available_stack_size, 0xa_3c69); /* call 0x10165d52 */
            ii(0x100c_20e9, 1); push(esi);                              /* push esi */
            ii(0x100c_20ea, 1); push(edi);                              /* push edi */
            ii(0x100c_20eb, 1); push(ebp);                              /* push ebp */
            ii(0x100c_20ec, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_20ee, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x100c_20f4, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100c_20f7, 3); mov(memd[ss, ebp - 0xc], edx);          /* mov [ebp-0xc], edx */
            ii(0x100c_20fa, 3); mov(memd[ss, ebp - 0x8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x100c_20fd, 3); mov(memb[ss, ebp - 0x4], cl);           /* mov [ebp-0x4], cl */
            ii(0x100c_2100, 4); cmp(memb[ss, ebp - 0x4], 0);            /* cmp byte [ebp-0x4], 0x0 */
            ii(0x100c_2104, 2); if(jnz(0x100c_2112, 0xc)) goto l_0x100c_2112; /* jnz 0x100c2112 */
            ii(0x100c_2106, 7); mov(memd[ss, ebp - 0x18], 0);           /* mov dword [ebp-0x18], 0x0 */
            ii(0x100c_210d, 5); jmp(0x100c_21a7, 0x95); goto l_0x100c_21a7; /* jmp 0x100c21a7 */
        l_0x100c_2112:
            ii(0x100c_2112, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100c_2115, 5); call(0x100b_906f, -0x90ab);             /* call 0x100b906f */
            ii(0x100c_211a, 3); mov(memb[ss, ebp - 0x14], al);          /* mov [ebp-0x14], al */
            ii(0x100c_211d, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x100c_211f, 3); mov(cl, memb[ss, ebp + 0x10]);          /* mov cl, [ebp+0x10] */
            ii(0x100c_2122, 4); movsx(ebx, memb[ss, ebp - 0x4]);        /* movsx ebx, byte [ebp-0x4] */
            ii(0x100c_2126, 4); movsx(edx, memb[ss, ebp - 0x14]);       /* movsx edx, byte [ebp-0x14] */
            ii(0x100c_212a, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100c_212d, 5); call(0x100c_12cd, -0xe65);              /* call 0x100c12cd */
            ii(0x100c_2132, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100c_2135, 4); cmp(memd[ss, ebp - 0x1c], 0);           /* cmp dword [ebp-0x1c], 0x0 */
            ii(0x100c_2139, 2); if(jnz(0x100c_2144, 0x9)) goto l_0x100c_2144; /* jnz 0x100c2144 */
            ii(0x100c_213b, 7); mov(memd[ss, ebp - 0x18], 0);           /* mov dword [ebp-0x18], 0x0 */
            ii(0x100c_2142, 2); jmp(0x100c_21a7, 0x63); goto l_0x100c_21a7; /* jmp 0x100c21a7 */
        l_0x100c_2144:
            ii(0x100c_2144, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100c_2147, 3); movsx(eax, memw[ds, edx]);              /* movsx eax, word [edx] */
            ii(0x100c_214a, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100c_214d, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100c_214f, 3); mov(edx, memd[ss, ebp - 0x1c]);         /* mov edx, [ebp-0x1c] */
            ii(0x100c_2152, 3); mov(eax, memd[ds, edx + 0x8]);          /* mov eax, [edx+0x8] */
            ii(0x100c_2155, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100c_2157, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100c_215a, 2); mov(edx, memd[ds, edx]);                /* mov edx, [edx] */
            ii(0x100c_215c, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100c_215f, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x100c_2161, 2); mov(ebx, memd[ds, eax]);                /* mov ebx, [eax] */
            ii(0x100c_2163, 2); add(ebx, edx);                          /* add ebx, edx */
            ii(0x100c_2165, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100c_2168, 5); call(0x1007_623c, -0x4_bf31);           /* call 0x1007623c */
            ii(0x100c_216d, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_216f, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x100c_2172, 4); mov(ax, memw[ds, eax + 0xe]);           /* mov ax, [eax+0xe] */
            ii(0x100c_2176, 4); sub(ax, memw[ds, edx + 0xc]);           /* sub ax, [edx+0xc] */
            ii(0x100c_217a, 3); mov(bx, memw[ds, ebx]);                 /* mov bx, [ebx] */
            ii(0x100c_217d, 3); imul(ebx, eax);                         /* imul ebx, eax */
            ii(0x100c_2180, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_2183, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x100c_2186, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100c_2189, 3); mov(edx, memd[ss, ebp - 0x1c]);         /* mov edx, [ebp-0x1c] */
            ii(0x100c_218c, 3); mov(edx, memd[ds, edx + 0x4]);          /* mov edx, [edx+0x4] */
            ii(0x100c_218f, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100c_2191, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100c_2194, 2); mov(edx, memd[ds, edx]);                /* mov edx, [edx] */
            ii(0x100c_2196, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100c_2199, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x100c_219b, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x100c_219d, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100c_219f, 3); mov(ax, memw[ds, eax]);                 /* mov ax, [eax] */
            ii(0x100c_21a2, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100c_21a4, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
        l_0x100c_21a7:
            ii(0x100c_21a7, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x100c_21aa, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_21ac, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_21ad, 1); pop(edi);                               /* pop edi */
            ii(0x100c_21ae, 1); pop(esi);                               /* pop esi */
            ii(0x100c_21af, 3); ret(0x4);                               /* ret 0x4 */
        }
    }
}
