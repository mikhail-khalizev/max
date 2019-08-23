using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_7c97-32a0e889")]
        public void Method_1009_7c97()
        {
            ii(0x1009_7c97, 5); push(0x6c);                             /* push 0x6c */
            ii(0x1009_7c9c, 5); call(Definitions.sys_check_available_stack_size, 0xc_e0b1); /* call 0x10165d52 */
            ii(0x1009_7ca1, 1); push(esi);                              /* push esi */
            ii(0x1009_7ca2, 1); push(edi);                              /* push edi */
            ii(0x1009_7ca3, 1); push(ebp);                              /* push ebp */
            ii(0x1009_7ca4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_7ca6, 6); sub(esp, 0x54);                         /* sub esp, 0x54 */
            ii(0x1009_7cac, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1009_7caf, 3); mov(memd[ss, ebp - 0xc], edx);          /* mov [ebp-0xc], edx */
            ii(0x1009_7cb2, 3); mov(memd[ss, ebp - 0x8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x1009_7cb5, 3); mov(memd[ss, ebp - 0x4], ecx);          /* mov [ebp-0x4], ecx */
            ii(0x1009_7cb8, 3); lea(eax, memd[ss, ebp - 0x34]);         /* lea eax, [ebp-0x34] */
            ii(0x1009_7cbb, 5); call(Definitions.my_ctor_0x101b_4184, -0x2_11d0); /* call 0x10076af0 */
            ii(0x1009_7cc0, 3); lea(eax, memd[ss, ebp - 0x38]);         /* lea eax, [ebp-0x38] */
            ii(0x1009_7cc3, 5); call(Definitions.my_ctor_0x101b_4184, -0x2_11d8); /* call 0x10076af0 */
            ii(0x1009_7cc8, 3); lea(eax, memd[ss, ebp - 0x3c]);         /* lea eax, [ebp-0x3c] */
            ii(0x1009_7ccb, 5); call(Definitions.my_ctor_0x101b_4184, -0x2_11e0); /* call 0x10076af0 */
            ii(0x1009_7cd0, 3); lea(eax, memd[ss, ebp - 0x40]);         /* lea eax, [ebp-0x40] */
            ii(0x1009_7cd3, 5); call(Definitions.my_ctor_0x101b_4184, -0x2_11e8); /* call 0x10076af0 */
            ii(0x1009_7cd8, 4); mov(memb[ss, ebp - 0x18], 0);           /* mov byte [ebp-0x18], 0x0 */
        l_0x1009_7cdc:
            ii(0x1009_7cdc, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1009_7cdf, 3); lea(eax, memd[ss, ebp - 0x34]);         /* lea eax, [ebp-0x34] */
            ii(0x1009_7ce2, 5); call(0x1008_8b44, -0xf1a3);             /* call 0x10088b44 */
            ii(0x1009_7ce7, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1009_7ceb, 1); push(eax);                              /* push eax */
            ii(0x1009_7cec, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_7cef, 3); mov(ecx, memd[ds, eax + 0x7]);          /* mov ecx, [eax+0x7] */
            ii(0x1009_7cf2, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x1009_7cf5, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1009_7cf7, 5); mov(edx, 0xffff_ffff);                  /* mov edx, 0xffffffff */
            ii(0x1009_7cfc, 3); lea(eax, memd[ss, ebp - 0x44]);         /* lea eax, [ebp-0x44] */
            ii(0x1009_7cff, 5); call(0x1007_6aac, -0x2_1258);           /* call 0x10076aac */
            ii(0x1009_7d04, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1009_7d06, 3); lea(edx, memd[ss, ebp - 0x34]);         /* lea edx, [ebp-0x34] */
            ii(0x1009_7d09, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1009_7d0c, 5); call(0x1009_794a, -0x3c7);              /* call 0x1009794a */
            ii(0x1009_7d11, 3); mov(memd[ss, ebp - 0x2c], eax);         /* mov [ebp-0x2c], eax */
            ii(0x1009_7d14, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1009_7d17, 3); lea(eax, memd[ss, ebp - 0x38]);         /* lea eax, [ebp-0x38] */
            ii(0x1009_7d1a, 5); call(0x1008_8b44, -0xf1db);             /* call 0x10088b44 */
            ii(0x1009_7d1f, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1009_7d23, 1); push(eax);                              /* push eax */
            ii(0x1009_7d24, 3); mov(ecx, memd[ss, ebp - 0x10]);         /* mov ecx, [ebp-0x10] */
            ii(0x1009_7d27, 3); mov(ecx, memd[ds, ecx + 0x7]);          /* mov ecx, [ecx+0x7] */
            ii(0x1009_7d2a, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x1009_7d2d, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1009_7d2f, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1009_7d34, 3); lea(eax, memd[ss, ebp - 0x48]);         /* lea eax, [ebp-0x48] */
            ii(0x1009_7d37, 5); call(0x1007_6aac, -0x2_1290);           /* call 0x10076aac */
            ii(0x1009_7d3c, 3); lea(edx, memd[ss, ebp - 0x38]);         /* lea edx, [ebp-0x38] */
            ii(0x1009_7d3f, 3); mov(esi, memd[ss, ebp - 0xc]);          /* mov esi, [ebp-0xc] */
            ii(0x1009_7d42, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1009_7d44, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1009_7d46, 5); call(0x1009_794a, -0x401);              /* call 0x1009794a */
            ii(0x1009_7d4b, 3); mov(memd[ss, ebp - 0x30], eax);         /* mov [ebp-0x30], eax */
            ii(0x1009_7d4e, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1009_7d51, 3); lea(eax, memd[ss, ebp - 0x3c]);         /* lea eax, [ebp-0x3c] */
            ii(0x1009_7d54, 5); call(0x1008_8b44, -0xf215);             /* call 0x10088b44 */
            ii(0x1009_7d59, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1009_7d5d, 1); push(eax);                              /* push eax */
            ii(0x1009_7d5e, 3); mov(ecx, memd[ss, ebp - 0x10]);         /* mov ecx, [ebp-0x10] */
            ii(0x1009_7d61, 3); mov(ecx, memd[ds, ecx + 0x7]);          /* mov ecx, [ecx+0x7] */
            ii(0x1009_7d64, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x1009_7d67, 5); mov(ebx, 0xffff_ffff);                  /* mov ebx, 0xffffffff */
            ii(0x1009_7d6c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_7d6e, 3); lea(eax, memd[ss, ebp - 0x4c]);         /* lea eax, [ebp-0x4c] */
            ii(0x1009_7d71, 5); call(0x1007_6aac, -0x2_12ca);           /* call 0x10076aac */
            ii(0x1009_7d76, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1009_7d78, 3); lea(edx, memd[ss, ebp - 0x3c]);         /* lea edx, [ebp-0x3c] */
            ii(0x1009_7d7b, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1009_7d7e, 5); call(0x1009_794a, -0x439);              /* call 0x1009794a */
            ii(0x1009_7d83, 3); mov(memd[ss, ebp - 0x28], eax);         /* mov [ebp-0x28], eax */
            ii(0x1009_7d86, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1009_7d89, 3); lea(eax, memd[ss, ebp - 0x40]);         /* lea eax, [ebp-0x40] */
            ii(0x1009_7d8c, 5); call(0x1008_8b44, -0xf24d);             /* call 0x10088b44 */
            ii(0x1009_7d91, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1009_7d95, 1); push(eax);                              /* push eax */
            ii(0x1009_7d96, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_7d99, 3); mov(ecx, memd[ds, eax + 0x7]);          /* mov ecx, [eax+0x7] */
            ii(0x1009_7d9c, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x1009_7d9f, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1009_7da4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_7da6, 3); lea(eax, memd[ss, ebp - 0x50]);         /* lea eax, [ebp-0x50] */
            ii(0x1009_7da9, 5); call(0x1007_6aac, -0x2_1302);           /* call 0x10076aac */
            ii(0x1009_7dae, 3); lea(edx, memd[ss, ebp - 0x40]);         /* lea edx, [ebp-0x40] */
            ii(0x1009_7db1, 3); mov(esi, memd[ss, ebp - 0xc]);          /* mov esi, [ebp-0xc] */
            ii(0x1009_7db4, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1009_7db6, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1009_7db8, 5); call(0x1009_794a, -0x473);              /* call 0x1009794a */
            ii(0x1009_7dbd, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x1009_7dc0, 6); mov(ax, memw[ds, 0x101c_8172]);         /* mov ax, [0x101c8172] */
            ii(0x1009_7dc6, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
            ii(0x1009_7dc9, 3); mov(eax, memd[ss, ebp - 0x24]);         /* mov eax, [ebp-0x24] */
            ii(0x1009_7dcc, 4); cmp(ax, memw[ss, ebp - 0x2c]);          /* cmp ax, [ebp-0x2c] */
            ii(0x1009_7dd0, 2); if(jle(0x1009_7dd8, 0x6)) goto l_0x1009_7dd8; /* jle 0x10097dd8 */
            ii(0x1009_7dd2, 3); mov(eax, memd[ss, ebp - 0x2c]);         /* mov eax, [ebp-0x2c] */
            ii(0x1009_7dd5, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
        l_0x1009_7dd8:
            ii(0x1009_7dd8, 3); mov(eax, memd[ss, ebp - 0x24]);         /* mov eax, [ebp-0x24] */
            ii(0x1009_7ddb, 4); cmp(ax, memw[ss, ebp - 0x30]);          /* cmp ax, [ebp-0x30] */
            ii(0x1009_7ddf, 2); if(jle(0x1009_7de7, 0x6)) goto l_0x1009_7de7; /* jle 0x10097de7 */
            ii(0x1009_7de1, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x1009_7de4, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
        l_0x1009_7de7:
            ii(0x1009_7de7, 3); mov(eax, memd[ss, ebp - 0x24]);         /* mov eax, [ebp-0x24] */
            ii(0x1009_7dea, 4); cmp(ax, memw[ss, ebp - 0x28]);          /* cmp ax, [ebp-0x28] */
            ii(0x1009_7dee, 2); if(jle(0x1009_7df6, 0x6)) goto l_0x1009_7df6; /* jle 0x10097df6 */
            ii(0x1009_7df0, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x1009_7df3, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
        l_0x1009_7df6:
            ii(0x1009_7df6, 3); mov(eax, memd[ss, ebp - 0x24]);         /* mov eax, [ebp-0x24] */
            ii(0x1009_7df9, 4); cmp(ax, memw[ss, ebp - 0x20]);          /* cmp ax, [ebp-0x20] */
            ii(0x1009_7dfd, 2); if(jle(0x1009_7e05, 0x6)) goto l_0x1009_7e05; /* jle 0x10097e05 */
            ii(0x1009_7dff, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x1009_7e02, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
        l_0x1009_7e05:
            ii(0x1009_7e05, 4); mov(memb[ss, ebp - 0x14], 0);           /* mov byte [ebp-0x14], 0x0 */
            ii(0x1009_7e09, 4); movsx(eax, memw[ss, ebp - 0x24]);       /* movsx eax, word [ebp-0x24] */
            ii(0x1009_7e0d, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1009_7e0f, 2); if(jnz(0x1009_7e33, 0x22)) goto l_0x1009_7e33; /* jnz 0x10097e33 */
            ii(0x1009_7e11, 5); mov(ecx, 0x2);                          /* mov ecx, 0x2 */
            ii(0x1009_7e16, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1009_7e19, 3); lea(eax, memd[ss, ebp - 0x54]);         /* lea eax, [ebp-0x54] */
            ii(0x1009_7e1c, 5); call(0x1007_5e64, -0x2_1fbd);           /* call 0x10075e64 */
            ii(0x1009_7e21, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1009_7e23, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1009_7e26, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_7e29, 5); call(0x1009_7545, -0x8e9);              /* call 0x10097545 */
            ii(0x1009_7e2e, 5); jmp(0x1009_7ecf, 0x9c); goto l_0x1009_7ecf; /* jmp 0x10097ecf */
        l_0x1009_7e33:
            ii(0x1009_7e33, 3); mov(eax, memd[ss, ebp - 0x24]);         /* mov eax, [ebp-0x24] */
            ii(0x1009_7e36, 4); cmp(ax, memw[ss, ebp - 0x2c]);          /* cmp ax, [ebp-0x2c] */
            ii(0x1009_7e3a, 2); if(jnz(0x1009_7e4d, 0x11)) goto l_0x1009_7e4d; /* jnz 0x10097e4d */
            ii(0x1009_7e3c, 3); lea(edx, memd[ss, ebp - 0x34]);         /* lea edx, [ebp-0x34] */
            ii(0x1009_7e3f, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_7e42, 5); call(0x1008_8b44, -0xf303);             /* call 0x10088b44 */
            ii(0x1009_7e47, 4); mov(memb[ss, ebp - 0x14], 0x1);         /* mov byte [ebp-0x14], 0x1 */
            ii(0x1009_7e4b, 2); jmp(0x1009_7e99, 0x4c); goto l_0x1009_7e99; /* jmp 0x10097e99 */
        l_0x1009_7e4d:
            ii(0x1009_7e4d, 3); mov(eax, memd[ss, ebp - 0x24]);         /* mov eax, [ebp-0x24] */
            ii(0x1009_7e50, 4); cmp(ax, memw[ss, ebp - 0x30]);          /* cmp ax, [ebp-0x30] */
            ii(0x1009_7e54, 2); if(jnz(0x1009_7e67, 0x11)) goto l_0x1009_7e67; /* jnz 0x10097e67 */
            ii(0x1009_7e56, 3); lea(edx, memd[ss, ebp - 0x38]);         /* lea edx, [ebp-0x38] */
            ii(0x1009_7e59, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_7e5c, 5); call(0x1008_8b44, -0xf31d);             /* call 0x10088b44 */
            ii(0x1009_7e61, 4); mov(memb[ss, ebp - 0x14], 0x1);         /* mov byte [ebp-0x14], 0x1 */
            ii(0x1009_7e65, 2); jmp(0x1009_7e99, 0x32); goto l_0x1009_7e99; /* jmp 0x10097e99 */
        l_0x1009_7e67:
            ii(0x1009_7e67, 3); mov(eax, memd[ss, ebp - 0x24]);         /* mov eax, [ebp-0x24] */
            ii(0x1009_7e6a, 4); cmp(ax, memw[ss, ebp - 0x28]);          /* cmp ax, [ebp-0x28] */
            ii(0x1009_7e6e, 2); if(jnz(0x1009_7e81, 0x11)) goto l_0x1009_7e81; /* jnz 0x10097e81 */
            ii(0x1009_7e70, 3); lea(edx, memd[ss, ebp - 0x3c]);         /* lea edx, [ebp-0x3c] */
            ii(0x1009_7e73, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_7e76, 5); call(0x1008_8b44, -0xf337);             /* call 0x10088b44 */
            ii(0x1009_7e7b, 4); mov(memb[ss, ebp - 0x14], 0x1);         /* mov byte [ebp-0x14], 0x1 */
            ii(0x1009_7e7f, 2); jmp(0x1009_7e99, 0x18); goto l_0x1009_7e99; /* jmp 0x10097e99 */
        l_0x1009_7e81:
            ii(0x1009_7e81, 3); mov(eax, memd[ss, ebp - 0x24]);         /* mov eax, [ebp-0x24] */
            ii(0x1009_7e84, 4); cmp(ax, memw[ss, ebp - 0x20]);          /* cmp ax, [ebp-0x20] */
            ii(0x1009_7e88, 2); if(jnz(0x1009_7e99, 0xf)) goto l_0x1009_7e99; /* jnz 0x10097e99 */
            ii(0x1009_7e8a, 3); lea(edx, memd[ss, ebp - 0x40]);         /* lea edx, [ebp-0x40] */
            ii(0x1009_7e8d, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_7e90, 5); call(0x1008_8b44, -0xf351);             /* call 0x10088b44 */
            ii(0x1009_7e95, 4); mov(memb[ss, ebp - 0x14], 0x1);         /* mov byte [ebp-0x14], 0x1 */
        l_0x1009_7e99:
            ii(0x1009_7e99, 4); cmp(memb[ss, ebp - 0x14], 0);           /* cmp byte [ebp-0x14], 0x0 */
            ii(0x1009_7e9d, 2); if(jz(0x1009_7ecf, 0x30)) goto l_0x1009_7ecf; /* jz 0x10097ecf */
            ii(0x1009_7e9f, 4); mov(memb[ss, ebp - 0x18], 0x1);         /* mov byte [ebp-0x18], 0x1 */
            ii(0x1009_7ea3, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_7ea6, 4); mov(ax, memw[ds, eax + 0x2]);           /* mov ax, [eax+0x2] */
            ii(0x1009_7eaa, 1); inc(eax);                               /* inc eax */
            ii(0x1009_7eab, 1); cwde();                                 /* cwde */
            ii(0x1009_7eac, 1); push(eax);                              /* push eax */
            ii(0x1009_7ead, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_7eb0, 3); mov(ax, memw[ds, eax]);                 /* mov ax, [eax] */
            ii(0x1009_7eb3, 1); inc(eax);                               /* inc eax */
            ii(0x1009_7eb4, 1); cwde();                                 /* cwde */
            ii(0x1009_7eb5, 1); push(eax);                              /* push eax */
            ii(0x1009_7eb6, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_7eb9, 2); mov(ecx, memd[ds, eax]);                /* mov ecx, [eax] */
            ii(0x1009_7ebb, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x1009_7ebe, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_7ec1, 3); movsx(ebx, memw[ds, eax]);              /* movsx ebx, word [eax] */
            ii(0x1009_7ec4, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1009_7ec7, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_7eca, 5); call(0x1009_78bd, -0x612);              /* call 0x100978bd */
        l_0x1009_7ecf:
            ii(0x1009_7ecf, 4); cmp(memb[ss, ebp - 0x14], 0);           /* cmp byte [ebp-0x14], 0x0 */
            ii(0x1009_7ed3, 6); if(jnz(0x1009_7cdc, -0x1fd)) goto l_0x1009_7cdc; /* jnz 0x10097cdc */
            ii(0x1009_7ed9, 3); mov(al, memb[ss, ebp - 0x18]);          /* mov al, [ebp-0x18] */
            ii(0x1009_7edc, 3); mov(memb[ss, ebp - 0x1c], al);          /* mov [ebp-0x1c], al */
            ii(0x1009_7edf, 3); mov(al, memb[ss, ebp - 0x1c]);          /* mov al, [ebp-0x1c] */
            ii(0x1009_7ee2, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_7ee4, 1); pop(ebp);                               /* pop ebp */
            ii(0x1009_7ee5, 1); pop(edi);                               /* pop edi */
            ii(0x1009_7ee6, 1); pop(esi);                               /* pop esi */
            ii(0x1009_7ee7, 1); ret();                                  /* ret */
        }
    }
}
