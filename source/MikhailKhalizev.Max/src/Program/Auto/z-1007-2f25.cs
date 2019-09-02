using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_2f25-7de9714b")]
        public void Method_1007_2f25()
        {
            ii(0x1007_2f25, 5); push(0x30);                             /* push 0x30 */
            ii(0x1007_2f2a, 5); call(Definitions.sys_check_available_stack_size, 0xf_2e23); /* call 0x10165d52 */
            ii(0x1007_2f2f, 1); push(ebx);                              /* push ebx */
            ii(0x1007_2f30, 1); push(ecx);                              /* push ecx */
            ii(0x1007_2f31, 1); push(esi);                              /* push esi */
            ii(0x1007_2f32, 1); push(edi);                              /* push edi */
            ii(0x1007_2f33, 1); push(ebp);                              /* push ebp */
            ii(0x1007_2f34, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_2f36, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x1007_2f3c, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1007_2f3f, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1007_2f42, 4); or(memb[ss, ebp - 0xc], 1);             /* or byte [ebp-0xc], 0x1 */
            ii(0x1007_2f46, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1007_2f49, 5); call(0x1007_64fc, 0x35ae);              /* call 0x100764fc */
            ii(0x1007_2f4e, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1007_2f51, 4); and(memb[ss, ebp - 0xc], -2 /* 0xfe */); /* and byte [ebp-0xc], 0xfe */
            ii(0x1007_2f55, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_2f58, 5); call(0x1007_6338, 0x33db);              /* call 0x10076338 */
            ii(0x1007_2f5d, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_2f5f, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1007_2f62, 5); call(0x1007_643c, 0x34d5);              /* call 0x1007643c */
            ii(0x1007_2f67, 2); jmp(0x1007_2f71, 8); goto l_0x1007_2f71; /* jmp 0x10072f71 */
        l_0x1007_2f69:
            ii(0x1007_2f69, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1007_2f6c, 5); call(0x1007_6bf8, 0x3c87);              /* call 0x10076bf8 */
        l_0x1007_2f71:
            ii(0x1007_2f71, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_2f73, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1007_2f76, 5); call(0x1013_ad71, 0xc_7df6);            /* call 0x1013ad71 */
            ii(0x1007_2f7b, 2); test(al, al);                           /* test al, al */
            ii(0x1007_2f7d, 6); if(jz(0x1007_3068, 0xe5)) goto l_0x1007_3068; /* jz 0x10073068 */
            ii(0x1007_2f83, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1007_2f86, 5); call(0x1007_63a0, 0x3415);              /* call 0x100763a0 */
            ii(0x1007_2f8b, 5); call(0x1007_6188, 0x31f8);              /* call 0x10076188 */
            ii(0x1007_2f90, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1007_2f93, 4); cmp(memd[ss, ebp - 0x18], 0);           /* cmp dword [ebp-0x18], 0x0 */
            ii(0x1007_2f97, 2); if(jz(0x1007_2fcc, 0x33)) goto l_0x1007_2fcc; /* jz 0x10072fcc */
            ii(0x1007_2f99, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1007_2f9c, 5); call(0x1007_63a0, 0x33ff);              /* call 0x100763a0 */
            ii(0x1007_2fa1, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_2fa3, 3); mov(dl, memb[ds, eax + 0x26]);          /* mov dl, [eax+0x26] */
            ii(0x1007_2fa6, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x1007_2faa, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1007_2fac, 2); if(jnz(0x1007_2fbb, 0xd)) goto l_0x1007_2fbb; /* jnz 0x10072fbb */
            ii(0x1007_2fae, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1007_2fb1, 5); call(0x1007_6408, 0x3452);              /* call 0x10076408 */
            ii(0x1007_2fb6, 3); cmp(eax, memd[ss, ebp - 0x18]);         /* cmp eax, [ebp-0x18] */
            ii(0x1007_2fb9, 2); if(jz(0x1007_2fbd, 2)) goto l_0x1007_2fbd; /* jz 0x10072fbd */
        l_0x1007_2fbb:
            ii(0x1007_2fbb, 2); jmp(0x1007_2fc7, 0xa); goto l_0x1007_2fc7; /* jmp 0x10072fc7 */
        l_0x1007_2fbd:
            ii(0x1007_2fbd, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_2fbf, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1007_2fc2, 5); call(0x1007_31cf, 0x208);               /* call 0x100731cf */
        l_0x1007_2fc7:
            ii(0x1007_2fc7, 5); jmp(0x1007_3063, 0x97); goto l_0x1007_3063; /* jmp 0x10073063 */
        l_0x1007_2fcc:
            ii(0x1007_2fcc, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1007_2fcf, 5); call(0x1007_63a0, 0x33cc);              /* call 0x100763a0 */
            ii(0x1007_2fd4, 4); cmp(memb[ds, eax + 0x3d], 2);           /* cmp byte [eax+0x3d], 0x2 */
            ii(0x1007_2fd8, 2); if(jz(0x1007_2fe8, 0xe)) goto l_0x1007_2fe8; /* jz 0x10072fe8 */
            ii(0x1007_2fda, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1007_2fdd, 5); call(0x1007_63a0, 0x33be);              /* call 0x100763a0 */
            ii(0x1007_2fe2, 4); cmp(memb[ds, eax + 0x3d], 0x1b);        /* cmp byte [eax+0x3d], 0x1b */
            ii(0x1007_2fe6, 2); if(jnz(0x1007_2fea, 2)) goto l_0x1007_2fea; /* jnz 0x10072fea */
        l_0x1007_2fe8:
            ii(0x1007_2fe8, 2); jmp(0x1007_2ff8, 0xe); goto l_0x1007_2ff8; /* jmp 0x10072ff8 */
        l_0x1007_2fea:
            ii(0x1007_2fea, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1007_2fed, 5); call(0x1007_63a0, 0x33ae);              /* call 0x100763a0 */
            ii(0x1007_2ff2, 4); cmp(memb[ds, eax + 0x3d], 0x1e);        /* cmp byte [eax+0x3d], 0x1e */
            ii(0x1007_2ff6, 2); if(jnz(0x1007_3006, 0xe)) goto l_0x1007_3006; /* jnz 0x10073006 */
        l_0x1007_2ff8:
            ii(0x1007_2ff8, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1007_2ffb, 5); call(0x1007_63a0, 0x33a0);              /* call 0x100763a0 */
            ii(0x1007_3000, 4); cmp(memb[ds, eax + 0x3e], 1);           /* cmp byte [eax+0x3e], 0x1 */
            ii(0x1007_3004, 2); if(jz(0x1007_3008, 2)) goto l_0x1007_3008; /* jz 0x10073008 */
        l_0x1007_3006:
            ii(0x1007_3006, 2); jmp(0x1007_301d, 0x15); goto l_0x1007_301d; /* jmp 0x1007301d */
        l_0x1007_3008:
            ii(0x1007_3008, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1007_300b, 5); call(0x1007_63a0, 0x3390);              /* call 0x100763a0 */
            ii(0x1007_3010, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_3012, 3); mov(dl, memb[ds, eax + 0x26]);          /* mov dl, [eax+0x26] */
            ii(0x1007_3015, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x1007_3019, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1007_301b, 2); if(jz(0x1007_301f, 2)) goto l_0x1007_301f; /* jz 0x1007301f */
        l_0x1007_301d:
            ii(0x1007_301d, 2); jmp(0x1007_302d, 0xe); goto l_0x1007_302d; /* jmp 0x1007302d */
        l_0x1007_301f:
            ii(0x1007_301f, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1007_3022, 5); call(0x1007_63a0, 0x3379);              /* call 0x100763a0 */
            ii(0x1007_3027, 4); cmp(memb[ds, eax + 0x4e], 0);           /* cmp byte [eax+0x4e], 0x0 */
            ii(0x1007_302b, 2); if(jnz(0x1007_302f, 2)) goto l_0x1007_302f; /* jnz 0x1007302f */
        l_0x1007_302d:
            ii(0x1007_302d, 2); jmp(0x1007_3044, 0x15); goto l_0x1007_3044; /* jmp 0x10073044 */
        l_0x1007_302f:
            ii(0x1007_302f, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1007_3032, 5); call(0x1007_63a0, 0x3369);              /* call 0x100763a0 */
            ii(0x1007_3037, 3); mov(al, memb[ds, eax + 0x60]);          /* mov al, [eax+0x60] */
            ii(0x1007_303a, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1007_303f, 3); cmp(eax, 2);                            /* cmp eax, 0x2 */
            ii(0x1007_3042, 2); if(jz(0x1007_3046, 2)) goto l_0x1007_3046; /* jz 0x10073046 */
        l_0x1007_3044:
            ii(0x1007_3044, 2); jmp(0x1007_3063, 0x1d); goto l_0x1007_3063; /* jmp 0x10073063 */
        l_0x1007_3046:
            ii(0x1007_3046, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1007_3048, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1007_304b, 5); call(0x1007_63a0, 0x3350);              /* call 0x100763a0 */
            ii(0x1007_3050, 3); mov(edx, memd[ds, eax + 0x3a]);         /* mov edx, [eax+0x3a] */
            ii(0x1007_3053, 3); sar(edx, 0x18);                         /* sar edx, 0x18 */
            ii(0x1007_3056, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1007_3059, 5); call(0x1007_63d4, 0x3376);              /* call 0x100763d4 */
            ii(0x1007_305e, 5); call(0x1016_3053, 0xe_fff0);            /* call 0x10163053 */
        l_0x1007_3063:
            ii(0x1007_3063, 5); jmp(0x1007_2f69, -0xff); goto l_0x1007_2f69; /* jmp 0x10072f69 */
        l_0x1007_3068:
            ii(0x1007_3068, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_306a, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1007_306d, 5); call(0x1007_5f6c, 0x2efa);              /* call 0x10075f6c */
            ii(0x1007_3072, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_3074, 1); pop(ebp);                               /* pop ebp */
            ii(0x1007_3075, 1); pop(edi);                               /* pop edi */
            ii(0x1007_3076, 1); pop(esi);                               /* pop esi */
            ii(0x1007_3077, 1); pop(ecx);                               /* pop ecx */
            ii(0x1007_3078, 1); pop(ebx);                               /* pop ebx */
            ii(0x1007_3079, 1); ret();                                  /* ret */
        }
    }
}
