using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_2e97-5ba1f607")]
        public void Method_1014_2e97()
        {
            ii(0x1014_2e97, 5); push(0x64);                             /* push 0x64 */
            ii(0x1014_2e9c, 5); call(Definitions.sys_check_available_stack_size, 0x2_2eb1); /* call 0x10165d52 */
            ii(0x1014_2ea1, 1); push(ebx);                              /* push ebx */
            ii(0x1014_2ea2, 1); push(ecx);                              /* push ecx */
            ii(0x1014_2ea3, 1); push(edx);                              /* push edx */
            ii(0x1014_2ea4, 1); push(esi);                              /* push esi */
            ii(0x1014_2ea5, 1); push(edi);                              /* push edi */
            ii(0x1014_2ea6, 1); push(ebp);                              /* push ebp */
            ii(0x1014_2ea7, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_2ea9, 6); sub(esp, 0x30);                         /* sub esp, 0x30 */
            ii(0x1014_2eaf, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1014_2eb2, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_2eb5, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1014_2eb7, 3); mov(edx, memd[ds, eax + 22]);           /* mov edx, [eax+0x16] */
            ii(0x1014_2eba, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_2ebd, 3); mov(ebx, memd[ds, eax + 10]);           /* mov ebx, [eax+0xa] */
            ii(0x1014_2ec0, 2); add(ebx, edx);                          /* add ebx, edx */
            ii(0x1014_2ec2, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_2ec5, 3); mov(edx, memd[ds, eax + 6]);            /* mov edx, [eax+0x6] */
            ii(0x1014_2ec8, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1014_2ecb, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_2ece, 4); imul(edx, memd[ds, eax + 14]);          /* imul edx, [eax+0xe] */
            ii(0x1014_2ed2, 2); add(ebx, edx);                          /* add ebx, edx */
            ii(0x1014_2ed4, 3); mov(memd[ss, ebp - 28], ebx);           /* mov [ebp-0x1c], ebx */
            ii(0x1014_2ed7, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_2eda, 4); mov(ax, memw[ds, eax + 18]);            /* mov ax, [eax+0x12] */
            ii(0x1014_2ede, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1014_2ee1, 4); sub(ax, memw[ds, edx + 10]);            /* sub ax, [edx+0xa] */
            ii(0x1014_2ee5, 3); mov(memd[ss, ebp - 24], eax);           /* mov [ebp-0x18], eax */
            ii(0x1014_2ee8, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_2eeb, 4); mov(ax, memw[ds, eax + 22]);            /* mov ax, [eax+0x16] */
            ii(0x1014_2eef, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1014_2ef2, 4); sub(ax, memw[ds, edx + 14]);            /* sub ax, [edx+0xe] */
            ii(0x1014_2ef6, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
            ii(0x1014_2ef9, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_2efc, 3); mov(eax, memd[ds, eax + 6]);            /* mov eax, [eax+0x6] */
            ii(0x1014_2eff, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_2f02, 1); push(eax);                              /* push eax */
            ii(0x1014_2f03, 3); mov(eax, memd[ss, ebp - 28]);           /* mov eax, [ebp-0x1c] */
            ii(0x1014_2f06, 1); push(eax);                              /* push eax */
            ii(0x1014_2f07, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_2f0a, 3); mov(eax, memd[ds, eax + 4]);            /* mov eax, [eax+0x4] */
            ii(0x1014_2f0d, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x1014_2f10, 1); push(eax);                              /* push eax */
            ii(0x1014_2f11, 4); movsx(eax, memw[ss, ebp - 20]);         /* movsx eax, word [ebp-0x14] */
            ii(0x1014_2f15, 1); push(eax);                              /* push eax */
            ii(0x1014_2f16, 4); movsx(eax, memw[ss, ebp - 24]);         /* movsx eax, word [ebp-0x18] */
            ii(0x1014_2f1a, 1); push(eax);                              /* push eax */
            ii(0x1014_2f1b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_2f1e, 3); mov(edx, memd[ds, eax + 14]);           /* mov edx, [eax+0xe] */
            ii(0x1014_2f21, 3); sub(edx, 0x46);                         /* sub edx, 0x46 */
            ii(0x1014_2f24, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_2f27, 3); mov(eax, memd[ds, eax + 4]);            /* mov eax, [eax+0x4] */
            ii(0x1014_2f2a, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x1014_2f2d, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x1014_2f30, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1014_2f33, 3); mov(edx, memd[ds, edx + 4]);            /* mov edx, [edx+0x4] */
            ii(0x1014_2f36, 3); add(edx, 8);                            /* add edx, 0x8 */
            ii(0x1014_2f39, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1014_2f3b, 1); push(eax);                              /* push eax */
            ii(0x1014_2f3c, 5); call(/* sys */ 0x1016_abbc, 0x2_7c7b);  /* call 0x1016abbc */
            ii(0x1014_2f41, 3); add(esp, 0x18);                         /* add esp, 0x18 */
            ii(0x1014_2f44, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_2f47, 3); mov(eax, memd[ds, eax + 26]);           /* mov eax, [eax+0x1a] */
            ii(0x1014_2f4a, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_2f4d, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1014_2f4f, 2); if(jnz(0x1014_2f72, 0x21)) goto l_0x1014_2f72; /* jnz 0x10142f72 */
            ii(0x1014_2f51, 7); mov(memd[ss, ebp - 12], 0);             /* mov dword [ebp-0xc], 0x0 */
            ii(0x1014_2f58, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_2f5b, 4); cmp(memd[ds, eax + 32], 0);             /* cmp dword [eax+0x20], 0x0 */
            ii(0x1014_2f5f, 2); if(jz(0x1014_2f69, 8)) goto l_0x1014_2f69; /* jz 0x10142f69 */
            ii(0x1014_2f61, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x1014_2f64, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1014_2f67, 2); jmp(0x1014_2f70, 7); goto l_0x1014_2f70; /* jmp 0x10142f70 */
        l_0x1014_2f69:
            ii(0x1014_2f69, 7); mov(memd[ss, ebp - 8], 0);              /* mov dword [ebp-0x8], 0x0 */
        l_0x1014_2f70:
            ii(0x1014_2f70, 2); jmp(0x1014_2fd7, 0x65); goto l_0x1014_2fd7; /* jmp 0x10142fd7 */
        l_0x1014_2f72:
            ii(0x1014_2f72, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_2f75, 3); mov(edx, memd[ds, eax + 24]);           /* mov edx, [eax+0x18] */
            ii(0x1014_2f78, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1014_2f7b, 4); movsx(eax, memw[ss, ebp - 24]);         /* movsx eax, word [ebp-0x18] */
            ii(0x1014_2f7f, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1014_2f82, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_2f85, 3); mov(ebx, memd[ds, eax + 26]);           /* mov ebx, [eax+0x1a] */
            ii(0x1014_2f88, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1014_2f8b, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1014_2f8d, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1014_2f90, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1014_2f92, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1014_2f95, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1014_2f98, 4); cmp(memd[ds, edx + 32], 0);             /* cmp dword [edx+0x20], 0x0 */
            ii(0x1014_2f9c, 2); if(jz(0x1014_2fd0, 0x32)) goto l_0x1014_2fd0; /* jz 0x10142fd0 */
            ii(0x1014_2f9e, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1014_2fa1, 3); mov(ebx, memd[ds, edx + 26]);           /* mov ebx, [edx+0x1a] */
            ii(0x1014_2fa4, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1014_2fa7, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1014_2faa, 3); mov(eax, memd[ds, edx + 28]);           /* mov eax, [edx+0x1c] */
            ii(0x1014_2fad, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_2fb0, 2); sub(ebx, eax);                          /* sub ebx, eax */
            ii(0x1014_2fb2, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1014_2fb4, 4); movsx(edx, memw[ss, ebp - 24]);         /* movsx edx, word [ebp-0x18] */
            ii(0x1014_2fb8, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1014_2fbb, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_2fbe, 3); mov(ebx, memd[ds, eax + 26]);           /* mov ebx, [eax+0x1a] */
            ii(0x1014_2fc1, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1014_2fc4, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1014_2fc6, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1014_2fc9, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1014_2fcb, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1014_2fce, 2); jmp(0x1014_2fd7, 7); goto l_0x1014_2fd7; /* jmp 0x10142fd7 */
        l_0x1014_2fd0:
            ii(0x1014_2fd0, 7); mov(memd[ss, ebp - 8], 0);              /* mov dword [ebp-0x8], 0x0 */
        l_0x1014_2fd7:
            ii(0x1014_2fd7, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_2fda, 3); mov(eax, memd[ds, eax + 38]);           /* mov eax, [eax+0x26] */
            ii(0x1014_2fdd, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_2fe0, 1); push(eax);                              /* push eax */
            ii(0x1014_2fe1, 4); movsx(ecx, memw[ss, ebp - 12]);         /* movsx ecx, word [ebp-0xc] */
            ii(0x1014_2fe5, 4); movsx(ebx, memw[ss, ebp - 20]);         /* movsx ebx, word [ebp-0x14] */
            ii(0x1014_2fe9, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_2fec, 3); mov(edx, memd[ds, eax + 6]);            /* mov edx, [eax+0x6] */
            ii(0x1014_2fef, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1014_2ff2, 3); mov(eax, memd[ss, ebp - 28]);           /* mov eax, [ebp-0x1c] */
            ii(0x1014_2ff5, 5); call(0x1014_2d60, -0x29a);              /* call 0x10142d60 */
            ii(0x1014_2ffa, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_2ffd, 3); mov(eax, memd[ds, eax + 40]);           /* mov eax, [eax+0x28] */
            ii(0x1014_3000, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_3003, 1); push(eax);                              /* push eax */
            ii(0x1014_3004, 4); movsx(ecx, memw[ss, ebp - 8]);          /* movsx ecx, word [ebp-0x8] */
            ii(0x1014_3008, 4); movsx(ebx, memw[ss, ebp - 20]);         /* movsx ebx, word [ebp-0x14] */
            ii(0x1014_300c, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_300f, 3); mov(edx, memd[ds, eax + 6]);            /* mov edx, [eax+0x6] */
            ii(0x1014_3012, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1014_3015, 4); movsx(eax, memw[ss, ebp - 24]);         /* movsx eax, word [ebp-0x18] */
            ii(0x1014_3019, 3); mov(esi, memd[ss, ebp - 28]);           /* mov esi, [ebp-0x1c] */
            ii(0x1014_301c, 2); add(esi, eax);                          /* add esi, eax */
            ii(0x1014_301e, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x1014_3022, 2); sub(esi, eax);                          /* sub esi, eax */
            ii(0x1014_3024, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1014_3026, 5); call(0x1014_2e31, -0x1fa);              /* call 0x10142e31 */
            ii(0x1014_302b, 5); mov(eax, 1);                            /* mov eax, 0x1 */
            ii(0x1014_3030, 5); call(/* sys */ 0x1016_a24c, 0x2_7217);  /* call 0x1016a24c */
            ii(0x1014_3035, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_3038, 3); mov(eax, memd[ds, eax + 36]);           /* mov eax, [eax+0x24] */
            ii(0x1014_303b, 6); call_abs(memd[ds, 0x101b_ddf4]);        /* call dword [0x101bddf4] */
            ii(0x1014_3041, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x1014_3044, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1014_3047, 4); cmp(ax, memw[ss, ebp - 24]);            /* cmp ax, [ebp-0x18] */
            ii(0x1014_304b, 2); if(jle(0x1014_3053, 6)) goto l_0x1014_3053; /* jle 0x10143053 */
            ii(0x1014_304d, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x1014_3050, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
        l_0x1014_3053:
            ii(0x1014_3053, 4); movsx(edx, memw[ss, ebp - 24]);         /* movsx edx, word [ebp-0x18] */
            ii(0x1014_3057, 4); movsx(eax, memw[ss, ebp - 16]);         /* movsx eax, word [ebp-0x10] */
            ii(0x1014_305b, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1014_305d, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1014_305f, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1014_3062, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1014_3064, 2); sar(eax, 1);                            /* sar eax, 1 */
            ii(0x1014_3066, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_3068, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_306b, 3); add(edx, memd[ds, eax + 10]);           /* add edx, [eax+0xa] */
            ii(0x1014_306e, 3); sub(edx, 2);                            /* sub edx, 0x2 */
            ii(0x1014_3071, 3); mov(memd[ss, ebp - 44], edx);           /* mov [ebp-0x2c], edx */
            ii(0x1014_3074, 6); call_abs(memd[ds, 0x101b_ddf0]);        /* call dword [0x101bddf0] */
            ii(0x1014_307a, 4); movsx(edx, memw[ss, ebp - 20]);         /* movsx edx, word [ebp-0x14] */
            ii(0x1014_307e, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1014_3080, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1014_3082, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1014_3085, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1014_3087, 2); sar(eax, 1);                            /* sar eax, 1 */
            ii(0x1014_3089, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_308b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_308e, 3); mov(eax, memd[ds, eax + 14]);           /* mov eax, [eax+0xe] */
            ii(0x1014_3091, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1014_3093, 3); mov(memd[ss, ebp - 40], eax);           /* mov [ebp-0x28], eax */
            ii(0x1014_3096, 4); movsx(eax, memw[ss, ebp - 16]);         /* movsx eax, word [ebp-0x10] */
            ii(0x1014_309a, 3); add(eax, memd[ss, ebp - 44]);           /* add eax, [ebp-0x2c] */
            ii(0x1014_309d, 3); add(eax, 4);                            /* add eax, 0x4 */
            ii(0x1014_30a0, 3); mov(memd[ss, ebp - 36], eax);           /* mov [ebp-0x24], eax */
            ii(0x1014_30a3, 6); call_abs(memd[ds, 0x101b_ddf0]);        /* call dword [0x101bddf0] */
            ii(0x1014_30a9, 3); mov(edx, memd[ss, ebp - 40]);           /* mov edx, [ebp-0x28] */
            ii(0x1014_30ac, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1014_30ae, 3); mov(memd[ss, ebp - 32], edx);           /* mov [ebp-0x20], edx */
            ii(0x1014_30b1, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_30b4, 3); push(memd[ds, eax + 44]);               /* push dword [eax+0x2c] */
            ii(0x1014_30b7, 6); call_abs(memd[ds, 0x101b_ddf0]);        /* call dword [0x101bddf0] */
            ii(0x1014_30bd, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1014_30c0, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1014_30c3, 5); add(eax, 4);                            /* add eax, 0x4 */
            ii(0x1014_30c8, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1014_30cb, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1014_30ce, 3); mov(edx, memd[ds, edx + 6]);            /* mov edx, [edx+0x6] */
            ii(0x1014_30d1, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1014_30d4, 3); mov(esi, memd[ss, ebp - 4]);            /* mov esi, [ebp-0x4] */
            ii(0x1014_30d7, 3); mov(esi, memd[ds, esi + 6]);            /* mov esi, [esi+0x6] */
            ii(0x1014_30da, 3); sar(esi, 0x10);                         /* sar esi, 0x10 */
            ii(0x1014_30dd, 4); imul(esi, memd[ss, ebp - 40]);          /* imul esi, [ebp-0x28] */
            ii(0x1014_30e1, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_30e4, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1014_30e6, 3); mov(eax, memd[ds, eax + 22]);           /* mov eax, [eax+0x16] */
            ii(0x1014_30e9, 3); add(eax, memd[ss, ebp - 44]);           /* add eax, [ebp-0x2c] */
            ii(0x1014_30ec, 2); add(eax, esi);                          /* add eax, esi */
            ii(0x1014_30ee, 5); call(0x100e_a763, -0x5_8990);           /* call 0x100ea763 */
            ii(0x1014_30f3, 5); push(0x1_00ff);                         /* push 0x100ff */
            ii(0x1014_30f8, 3); mov(ecx, memd[ss, ebp - 4]);            /* mov ecx, [ebp-0x4] */
            ii(0x1014_30fb, 3); mov(ecx, memd[ds, ecx + 6]);            /* mov ecx, [ecx+0x6] */
            ii(0x1014_30fe, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x1014_3101, 4); movsx(ebx, memw[ss, ebp - 24]);         /* movsx ebx, word [ebp-0x18] */
            ii(0x1014_3105, 3); mov(esi, memd[ss, ebp - 4]);            /* mov esi, [ebp-0x4] */
            ii(0x1014_3108, 3); mov(esi, memd[ds, esi + 36]);           /* mov esi, [esi+0x24] */
            ii(0x1014_310b, 6); call_abs(memd[ds, 0x101b_ddf0]);        /* call dword [0x101bddf0] */
            ii(0x1014_3111, 4); movsx(edx, memw[ss, ebp - 20]);         /* movsx edx, word [ebp-0x14] */
            ii(0x1014_3115, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1014_3117, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1014_3119, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1014_311c, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1014_311e, 2); sar(eax, 1);                            /* sar eax, 1 */
            ii(0x1014_3120, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1014_3123, 3); mov(edx, memd[ds, edx + 14]);           /* mov edx, [edx+0xe] */
            ii(0x1014_3126, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1014_3128, 3); mov(memd[ss, ebp - 48], edx);           /* mov [ebp-0x30], edx */
            ii(0x1014_312b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_312e, 3); mov(eax, memd[ds, eax + 6]);            /* mov eax, [eax+0x6] */
            ii(0x1014_3131, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_3134, 3); mov(edx, memd[ss, ebp - 48]);           /* mov edx, [ebp-0x30] */
            ii(0x1014_3137, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1014_313a, 3); mov(memd[ss, ebp - 48], edx);           /* mov [ebp-0x30], edx */
            ii(0x1014_313d, 4); movsx(edx, memw[ss, ebp - 24]);         /* movsx edx, word [ebp-0x18] */
            ii(0x1014_3141, 4); movsx(eax, memw[ss, ebp - 16]);         /* movsx eax, word [ebp-0x10] */
            ii(0x1014_3145, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1014_3147, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1014_3149, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1014_314c, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1014_314e, 2); sar(eax, 1);                            /* sar eax, 1 */
            ii(0x1014_3150, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1014_3153, 2); mov(edx, memd[ds, edx]);                /* mov edx, [edx] */
            ii(0x1014_3155, 3); mov(edx, memd[ds, edx + 22]);           /* mov edx, [edx+0x16] */
            ii(0x1014_3158, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1014_315a, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1014_315d, 3); add(eax, memd[ds, edx + 10]);           /* add eax, [edx+0xa] */
            ii(0x1014_3160, 3); add(eax, memd[ss, ebp - 48]);           /* add eax, [ebp-0x30] */
            ii(0x1014_3163, 2); mov(edx, esi);                          /* mov edx, esi */
            ii(0x1014_3165, 6); call_abs(memd[ds, 0x101b_ddec]);        /* call dword [0x101bddec] */
            ii(0x1014_316b, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1014_316e, 3); add(edx, 0xa);                          /* add edx, 0xa */
            ii(0x1014_3171, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_3174, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1014_3176, 3); mov(eax, memd[ds, eax + 18]);           /* mov eax, [eax+0x12] */
            ii(0x1014_3179, 5); call(Definitions.sys_display_draw_1, 0x2_432a); /* call 0x101674a8 */
            ii(0x1014_317e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_3180, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_3181, 1); pop(edi);                               /* pop edi */
            ii(0x1014_3182, 1); pop(esi);                               /* pop esi */
            ii(0x1014_3183, 1); pop(edx);                               /* pop edx */
            ii(0x1014_3184, 1); pop(ecx);                               /* pop ecx */
            ii(0x1014_3185, 1); pop(ebx);                               /* pop ebx */
            ii(0x1014_3186, 1); ret();                                  /* ret */
        }
    }
}
