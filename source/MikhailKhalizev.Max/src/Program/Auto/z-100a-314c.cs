using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d185a2a6-a933-4fa2-96f9-198c37c09640")]
        public void Method_100a_314c()
        {
            ii(0x100a_314c, 5); pushd(0x40);                            /* push 0x40 */
            ii(0x100a_3151, 5); calld(Definitions.sys_check_available_stack_size, 0xc_2bfc); /* call 0x10165d52 */
            ii(0x100a_3156, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_3157, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_3158, 1); pushd(edx);                             /* push edx */
            ii(0x100a_3159, 1); pushd(esi);                             /* push esi */
            ii(0x100a_315a, 1); pushd(edi);                             /* push edi */
            ii(0x100a_315b, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_315c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_315e, 6); sub(esp, 0x24);                         /* sub esp, 0x24 */
            ii(0x100a_3164, 6); mov(ax, memw_a32[ds, 0x101c_3968]);     /* mov ax, [0x101c3968] */
            ii(0x100a_316a, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100a_316d, 4); or(memb_a32[ss, ebp - 0x4], 0x1);       /* or byte [ebp-0x4], 0x1 */
            ii(0x100a_3171, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100a_3174, 5); calld(0x1007_64fc, -0x2_cc7d);          /* call 0x100764fc */
            ii(0x100a_3179, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100a_317c, 4); and(memb_a32[ss, ebp - 0x4], -0x2 /* 0xfe */); /* and byte [ebp-0x4], 0xfe */
            ii(0x100a_3180, 5); mov(eax, memd_a32[ds, 0x101c_3964]);    /* mov eax, [0x101c3964] */
            ii(0x100a_3185, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_3188, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_318a, 2); if(jnzd(0x100a_31a8, 0x1c)) goto l_0x100a_31a8; /* jnz 0x100a31a8 */
            ii(0x100a_318c, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100a_318f, 7); sub(ax, memw_a32[ds, 0x101c_37dc]);     /* sub ax, [0x101c37dc] */
            ii(0x100a_3196, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100a_3199, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_319b, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100a_319e, 5); calld(0x1007_5f6c, -0x2_d237);          /* call 0x10075f6c */
            ii(0x100a_31a3, 5); jmpd(0x100a_32b7, 0x10f); goto l_0x100a_32b7; /* jmp 0x100a32b7 */
        l_0x100a_31a8:
            ii(0x100a_31a8, 7); mov(memd_a32[ss, ebp - 0x10], 0x3e8);   /* mov dword [ebp-0x10], 0x3e8 */
            ii(0x100a_31af, 7); mov(memd_a32[ss, ebp - 0x8], 0);        /* mov dword [ebp-0x8], 0x0 */
            ii(0x100a_31b6, 2); jmpd(0x100a_31be, 0x6); goto l_0x100a_31be; /* jmp 0x100a31be */
        l_0x100a_31b8:
            ii(0x100a_31b8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_31bb, 3); inc(memd_a32[ss, ebp - 0x8]);           /* inc dword [ebp-0x8] */
        l_0x100a_31be:
            ii(0x100a_31be, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100a_31c2, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x100a_31c5, 6); if(jged(0x100a_329b, 0xd0)) goto l_0x100a_329b; /* jge 0x100a329b */
            ii(0x100a_31cb, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100a_31cf, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100a_31d5, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x100a_31db, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100a_31e0, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_31e2, 6); if(jzd(0x100a_3296, 0xae)) goto l_0x100a_3296; /* jz 0x100a3296 */
            ii(0x100a_31e8, 7); mov(memd_a32[ss, ebp - 0x24], 0);       /* mov dword [ebp-0x24], 0x0 */
            ii(0x100a_31ef, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x100a_31f4, 5); calld(0x1007_6338, -0x2_cec1);          /* call 0x10076338 */
            ii(0x100a_31f9, 3); lea(ebx, ebp - 0x20);                   /* lea ebx, [ebp-0x20] */
            ii(0x100a_31fc, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_31fe, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100a_3200, 5); calld(0x1007_643c, -0x2_cdc9);          /* call 0x1007643c */
            ii(0x100a_3205, 2); jmpd(0x100a_320f, 0x8); goto l_0x100a_320f; /* jmp 0x100a320f */
        l_0x100a_3207:
            ii(0x100a_3207, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100a_320a, 5); calld(0x1007_6bf8, -0x2_c617);          /* call 0x10076bf8 */
        l_0x100a_320f:
            ii(0x100a_320f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_3211, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100a_3214, 5); calld(0x1013_ad71, 0x9_7b58);           /* call 0x1013ad71 */
            ii(0x100a_3219, 2); test(al, al);                           /* test al, al */
            ii(0x100a_321b, 2); if(jzd(0x100a_325b, 0x3e)) goto l_0x100a_325b; /* jz 0x100a325b */
            ii(0x100a_321d, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100a_3220, 5); calld(0x1007_63a0, -0x2_ce85);          /* call 0x100763a0 */
            ii(0x100a_3225, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_3227, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x100a_322a, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100a_322e, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100a_3230, 2); if(jnzd(0x100a_3241, 0xf)) goto l_0x100a_3241; /* jnz 0x100a3241 */
            ii(0x100a_3232, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100a_3235, 5); calld(0x1007_63a0, -0x2_ce9a);          /* call 0x100763a0 */
            ii(0x100a_323a, 5); cmp(memw_a32[ds, eax + 0x8], 0x1e);     /* cmp word [eax+0x8], 0x1e */
            ii(0x100a_323f, 2); if(jzd(0x100a_3243, 0x2)) goto l_0x100a_3243; /* jz 0x100a3243 */
        l_0x100a_3241:
            ii(0x100a_3241, 2); jmpd(0x100a_3251, 0xe); goto l_0x100a_3251; /* jmp 0x100a3251 */
        l_0x100a_3243:
            ii(0x100a_3243, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100a_3246, 5); calld(0x1007_63a0, -0x2_ceab);          /* call 0x100763a0 */
            ii(0x100a_324b, 4); cmp(memb_a32[ds, eax + 0x3d], 0x7);     /* cmp byte [eax+0x3d], 0x7 */
            ii(0x100a_324f, 2); if(jzd(0x100a_3253, 0x2)) goto l_0x100a_3253; /* jz 0x100a3253 */
        l_0x100a_3251:
            ii(0x100a_3251, 2); jmpd(0x100a_3259, 0x6); goto l_0x100a_3259; /* jmp 0x100a3259 */
        l_0x100a_3253:
            ii(0x100a_3253, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100a_3256, 3); inc(memd_a32[ss, ebp - 0x24]);          /* inc dword [ebp-0x24] */
        l_0x100a_3259:
            ii(0x100a_3259, 2); jmpd(0x100a_3207, -0x54); goto l_0x100a_3207; /* jmp 0x100a3207 */
        l_0x100a_325b:
            ii(0x100a_325b, 4); movsx(eax, memw_a32[ss, ebp - 0x24]);   /* movsx eax, word [ebp-0x24] */
            ii(0x100a_325f, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_3261, 2); if(jled(0x100a_3296, 0x33)) goto l_0x100a_3296; /* jle 0x100a3296 */
            ii(0x100a_3263, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x100a_3267, 6); imul(edx, edx, 0x247);                  /* imul edx, edx, 0x247 */
            ii(0x100a_326d, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100a_3271, 6); sub(eax, memd_a32[ds, edx + 0x101c_a550]); /* sub eax, [edx+0x101ca550] */
            ii(0x100a_3277, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_3279, 4); movsx(ebx, memw_a32[ss, ebp - 0x24]);   /* movsx ebx, word [ebp-0x24] */
            ii(0x100a_327d, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100a_327f, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100a_3282, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x100a_3284, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_3287, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_328a, 4); cmp(ax, memw_a32[ss, ebp - 0x10]);      /* cmp ax, [ebp-0x10] */
            ii(0x100a_328e, 2); if(jged(0x100a_3296, 0x6)) goto l_0x100a_3296; /* jge 0x100a3296 */
            ii(0x100a_3290, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_3293, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
        l_0x100a_3296:
            ii(0x100a_3296, 5); jmpd(0x100a_31b8, -0xe3); goto l_0x100a_31b8; /* jmp 0x100a31b8 */
        l_0x100a_329b:
            ii(0x100a_329b, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100a_329e, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100a_32a1, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_32a3, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100a_32a6, 5); calld(0x1007_5f6c, -0x2_d33f);          /* call 0x10075f6c */
            ii(0x100a_32ab, 2); jmpd(0x100a_32b7, 0xa); goto l_0x100a_32b7; /* jmp 0x100a32b7 */
        //    ii(0x100a_32ad, 2); xor(edx, edx);                          /* xor edx, edx */
        //    ii(0x100a_32af, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
        //    ii(0x100a_32b2, 5); calld(0x1007_5f6c, -0x2_d34b);          /* call 0x10075f6c */
        l_0x100a_32b7:
            ii(0x100a_32b7, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100a_32ba, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_32bc, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_32bd, 1); popd(edi);                              /* pop edi */
            ii(0x100a_32be, 1); popd(esi);                              /* pop esi */
            ii(0x100a_32bf, 1); popd(edx);                              /* pop edx */
            ii(0x100a_32c0, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_32c1, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_32c2, 1); retd(); return;                         /* ret */
        }
    }
}