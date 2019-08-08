using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b18f1350-0351-4ed5-be8c-c6d7e05ae224")]
        public void Method_100f_9c44()
        {
            ii(0x100f_9c44, 7); test(memb_a32[ds, 0x101c_38d4], 0x1);   /* test byte [0x101c38d4], 0x1 */
            ii(0x100f_9c4b, 6); if(jzd_func(0x100f_a7df, 0xb8e)) return; /* jz 0x100fa7df */
            ii(0x100f_9c51, 5); mov(eax, 0x17);                         /* mov eax, 0x17 */
            ii(0x100f_9c56, 5); calld(0x100e_883d, -0x1_141e);          /* call 0x100e883d */
            ii(0x100f_9c5b, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100f_9c5e, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100f_9c61, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100f_9c63, 3); add(eax, 0xe);                          /* add eax, 0xe */
            ii(0x100f_9c66, 6); sub(memd_a32[ds, 0x101c_38cc], eax);    /* sub [0x101c38cc], eax */
            ii(0x100f_9c6c, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100f_9c6f, 4); mov(ax, memw_a32[ds, eax + 0x8]);       /* mov ax, [eax+0x8] */
            ii(0x100f_9c73, 3); mov(edx, memd_a32[ss, ebp - 0x14]);     /* mov edx, [ebp-0x14] */
            ii(0x100f_9c76, 3); sub(ax, memw_a32[ds, edx]);             /* sub ax, [edx] */
            ii(0x100f_9c79, 3); sub(eax, 0x1e);                         /* sub eax, 0x1e */
            ii(0x100f_9c7c, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100f_9c7f, 7); cmp(memd_a32[ds, 0x101c_38cc], 0);      /* cmp dword [0x101c38cc], 0x0 */
            ii(0x100f_9c86, 2); if(jged(0x100f_9c92, 0xa)) goto l_0x100f_9c92; /* jge 0x100f9c92 */
            ii(0x100f_9c88, 10); mov(memd_a32[ds, 0x101c_38cc], 0);     /* mov dword [0x101c38cc], 0x0 */
        l_0x100f_9c92:
            ii(0x100f_9c92, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100f_9c96, 6); cmp(eax, memd_a32[ds, 0x101c_38cc]);    /* cmp eax, [0x101c38cc] */
            ii(0x100f_9c9c, 2); if(jged(0x100f_9ca7, 0x9)) goto l_0x100f_9ca7; /* jge 0x100f9ca7 */
            ii(0x100f_9c9e, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100f_9ca2, 5); mov(memd_a32[ds, 0x101c_38cc], eax);    /* mov [0x101c38cc], eax */
        l_0x100f_9ca7:
            ii(0x100f_9ca7, 7); imul(edx, memd_a32[ds, 0x101c_38cc], 0x3c); /* imul edx, [0x101c38cc], 0x3c */
            ii(0x100f_9cae, 4); movsx(ebx, memw_a32[ss, ebp - 0xc]);    /* movsx ebx, word [ebp-0xc] */
            ii(0x100f_9cb2, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100f_9cb4, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100f_9cb7, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x100f_9cb9, 5); mov(edx, 0x40);                         /* mov edx, 0x40 */
            ii(0x100f_9cbe, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x100f_9cc0, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100f_9cc2, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100f_9cc5, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x100f_9cc7, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100f_9cc9, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x100f_9ccd, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_9ccf, 5); calld(0x1010_1620, 0x794c);             /* call 0x10101620 */
            ii(0x100f_9cd4, 5); if(jmpd_func(0x100f_a7df, 0xb06)) return; /* jmp 0x100fa7df */
        }
    }
}
