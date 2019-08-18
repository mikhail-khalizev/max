using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_d2ff-bda8d6b5")]
        public void Method_100e_d2ff()
        {
            ii(0x100e_d2ff, 6); mov(ax, memw_a32[ds, 0x101c_3982]);     /* mov ax, [0x101c3982] */
            ii(0x100e_d305, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x100e_d308, 5); jmpd(0x100e_d3f0, 0xe3); goto l_0x100e_d3f0; /* jmp 0x100ed3f0 */
        l_0x100e_d30d:
            ii(0x100e_d30d, 5); mov(eax, memd_a32[ds, 0x101c_a550]);    /* mov eax, [0x101ca550] */
            ii(0x100e_d312, 6); cmp(eax, memd_a32[ds, 0x101c_a797]);    /* cmp eax, [0x101ca797] */
            ii(0x100e_d318, 2); if(jled(0x100e_d323, 0x9)) goto l_0x100e_d323; /* jle 0x100ed323 */
            ii(0x100e_d31a, 4); mov(memb_a32[ss, ebp - 0xc], 0x2);      /* mov byte [ebp-0xc], 0x2 */
            ii(0x100e_d31e, 5); if(jmpd_func(0x100e_d760, 0x43d)) return; /* jmp 0x100ed760 */
        l_0x100e_d323:
            ii(0x100e_d323, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x100e_d327, 5); if(jmpd_func(0x100e_d760, 0x434)) return; /* jmp 0x100ed760 */
        l_0x100e_d32c:
            ii(0x100e_d32c, 5); mov(edx, 0x1d);                         /* mov edx, 0x1d */
            ii(0x100e_d331, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100e_d336, 5); calld(0x100e_c486, -0xeb5);             /* call 0x100ec486 */
            ii(0x100e_d33b, 1); cwde();                                 /* cwde */
            ii(0x100e_d33c, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_d33e, 2); if(jnzd(0x100e_d349, 0x9)) goto l_0x100e_d349; /* jnz 0x100ed349 */
            ii(0x100e_d340, 4); mov(memb_a32[ss, ebp - 0xc], 0x2);      /* mov byte [ebp-0xc], 0x2 */
            ii(0x100e_d344, 5); if(jmpd_func(0x100e_d760, 0x417)) return; /* jmp 0x100ed760 */
        l_0x100e_d349:
            ii(0x100e_d349, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x100e_d34d, 5); if(jmpd_func(0x100e_d760, 0x40e)) return; /* jmp 0x100ed760 */
        l_0x100e_d352:
            ii(0x100e_d352, 5); mov(eax, memd_a32[ds, 0x101c_3966]);    /* mov eax, [0x101c3966] */
            ii(0x100e_d357, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_d35a, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x100e_d35e, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100e_d360, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100e_d362, 5); mov(edx, 0x1e);                         /* mov edx, 0x1e */
            ii(0x100e_d367, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100e_d36b, 5); calld(0x100e_c486, -0xeea);             /* call 0x100ec486 */
            ii(0x100e_d370, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100e_d373, 3); imul(edx, ebx);                         /* imul edx, ebx */
            ii(0x100e_d376, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100e_d37a, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100e_d380, 6); mov(ecx, memd_a32[ds, eax + 0x101c_a550]); /* mov ecx, [eax+0x101ca550] */
            ii(0x100e_d386, 2); add(ecx, edx);                          /* add ecx, edx */
            ii(0x100e_d388, 6); mov(edx, memd_a32[ds, 0x101c_3966]);    /* mov edx, [0x101c3966] */
            ii(0x100e_d38e, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100e_d391, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100e_d395, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x100e_d397, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x100e_d399, 5); mov(edx, 0x1e);                         /* mov edx, 0x1e */
            ii(0x100e_d39e, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100e_d3a3, 5); calld(0x100e_c486, -0xf22);             /* call 0x100ec486 */
            ii(0x100e_d3a8, 1); cwde();                                 /* cwde */
            ii(0x100e_d3a9, 3); imul(eax, ebx);                         /* imul eax, ebx */
            ii(0x100e_d3ac, 6); add(eax, memd_a32[ds, 0x101c_a797]);    /* add eax, [0x101ca797] */
            ii(0x100e_d3b2, 2); cmp(ecx, eax);                          /* cmp ecx, eax */
            ii(0x100e_d3b4, 2); if(jged(0x100e_d3bf, 0x9)) goto l_0x100e_d3bf; /* jge 0x100ed3bf */
            ii(0x100e_d3b6, 4); mov(memb_a32[ss, ebp - 0xc], 0x3);      /* mov byte [ebp-0xc], 0x3 */
            ii(0x100e_d3ba, 5); if(jmpd_func(0x100e_d760, 0x3a1)) return; /* jmp 0x100ed760 */
        l_0x100e_d3bf:
            ii(0x100e_d3bf, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x100e_d3c3, 5); if(jmpd_func(0x100e_d760, 0x398)) return; /* jmp 0x100ed760 */
        l_0x100e_d3c8:
            ii(0x100e_d3c8, 5); mov(edx, 0x1e);                         /* mov edx, 0x1e */
            ii(0x100e_d3cd, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100e_d3d2, 5); calld(0x100e_c486, -0xf51);             /* call 0x100ec486 */
            ii(0x100e_d3d7, 1); cwde();                                 /* cwde */
            ii(0x100e_d3d8, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_d3da, 2); if(jnzd(0x100e_d3e5, 0x9)) goto l_0x100e_d3e5; /* jnz 0x100ed3e5 */
            ii(0x100e_d3dc, 4); mov(memb_a32[ss, ebp - 0xc], 0x2);      /* mov byte [ebp-0xc], 0x2 */
            ii(0x100e_d3e0, 5); if(jmpd_func(0x100e_d760, 0x37b)) return; /* jmp 0x100ed760 */
        l_0x100e_d3e5:
            ii(0x100e_d3e5, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x100e_d3e9, 5); if(jmpd_func(0x100e_d760, 0x372)) return; /* jmp 0x100ed760 */
        l_0x100e_d3ee:
            ii(0x100e_d3ee, 2); jmpd(0x100e_d432, 0x42); goto l_0x100e_d432; /* jmp 0x100ed432 */
        l_0x100e_d3f0:
            ii(0x100e_d3f0, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x100e_d3f3, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
            ii(0x100e_d3f6, 5); cmp(memw_a32[ss, ebp - 0x2c], 0x12);    /* cmp word [ebp-0x2c], 0x12 */
            ii(0x100e_d3fb, 2); if(jbd(0x100e_d425, 0x28)) goto l_0x100e_d425; /* jb 0x100ed425 */
            ii(0x100e_d3fd, 5); cmp(memw_a32[ss, ebp - 0x2c], 0x12);    /* cmp word [ebp-0x2c], 0x12 */
            ii(0x100e_d402, 6); if(jbed(0x100e_d32c, -0xdc)) goto l_0x100e_d32c; /* jbe 0x100ed32c */
            ii(0x100e_d408, 5); cmp(memw_a32[ss, ebp - 0x2c], 0x14);    /* cmp word [ebp-0x2c], 0x14 */
            ii(0x100e_d40d, 2); if(jbd(0x100e_d423, 0x14)) goto l_0x100e_d423; /* jb 0x100ed423 */
            ii(0x100e_d40f, 5); cmp(memw_a32[ss, ebp - 0x2c], 0x14);    /* cmp word [ebp-0x2c], 0x14 */
            ii(0x100e_d414, 6); if(jbed(0x100e_d352, -0xc8)) goto l_0x100e_d352; /* jbe 0x100ed352 */
            ii(0x100e_d41a, 5); cmp(memw_a32[ss, ebp - 0x2c], 0x18);    /* cmp word [ebp-0x2c], 0x18 */
            ii(0x100e_d41f, 2); if(jzd(0x100e_d3c8, -0x59)) goto l_0x100e_d3c8; /* jz 0x100ed3c8 */
            ii(0x100e_d421, 2); jmpd(0x100e_d3ee, -0x35); goto l_0x100e_d3ee; /* jmp 0x100ed3ee */
        l_0x100e_d423:
            ii(0x100e_d423, 2); jmpd(0x100e_d3ee, -0x37); goto l_0x100e_d3ee; /* jmp 0x100ed3ee */
        l_0x100e_d425:
            ii(0x100e_d425, 5); cmp(memw_a32[ss, ebp - 0x2c], 0x9);     /* cmp word [ebp-0x2c], 0x9 */
            ii(0x100e_d42a, 6); if(jzd(0x100e_d30d, -0x123)) goto l_0x100e_d30d; /* jz 0x100ed30d */
            ii(0x100e_d430, 2); jmpd(0x100e_d3ee, -0x44); goto l_0x100e_d3ee; /* jmp 0x100ed3ee */
        l_0x100e_d432:
            ii(0x100e_d432, 5); if(jmpd_func(0x100e_d75c, 0x325)) return; /* jmp 0x100ed75c */
        }
    }
}
