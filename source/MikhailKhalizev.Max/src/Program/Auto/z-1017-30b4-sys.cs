using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("77dd8015-3c17-4463-80f9-add95ef4e6b2")]
        public void /* sys */ Method_1017_30b4()
        {
            ii(0x1017_30b4, 1); pushd(ebx);                             /* push ebx */
            ii(0x1017_30b5, 1); pushd(ecx);                             /* push ecx */
            ii(0x1017_30b6, 1); pushd(edx);                             /* push edx */
            ii(0x1017_30b7, 3); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1017_30ba, 6); mov(ebx, memd_a32[ds, 0x1020_9540]);    /* mov ebx, [0x10209540] */
            ii(0x1017_30c0, 2); mov(edx, esp);                          /* mov edx, esp */
            ii(0x1017_30c2, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_30c4, 5); calld(/* sys */ 0x1017_8f18, 0x5e4f);   /* call 0x10178f18 */
            ii(0x1017_30c9, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_30cb, 6); if(jnzd(0x1017_3349, 0x278)) goto l_0x1017_3349; /* jnz 0x10173349 */
            ii(0x1017_30d1, 3); mov(eax, memd_a32[ss, esp]);            /* mov eax, [esp] */
            ii(0x1017_30d4, 4); test(memb_a32[ds, eax + 0x2], 0x1);     /* test byte [eax+0x2], 0x1 */
            ii(0x1017_30d8, 6); if(jzd(0x1017_3337, 0x259)) goto l_0x1017_3337; /* jz 0x10173337 */
            ii(0x1017_30de, 6); mov(ebx, memd_a32[ds, 0x1020_9540]);    /* mov ebx, [0x10209540] */
            ii(0x1017_30e4, 2); test(ebx, ebx);                         /* test ebx, ebx */
            ii(0x1017_30e6, 2); if(jzd(0x1017_30fc, 0x14)) goto l_0x1017_30fc; /* jz 0x101730fc */
            ii(0x1017_30e8, 3); cmp(ebx, 0x1);                          /* cmp ebx, 0x1 */
            ii(0x1017_30eb, 2); if(jnzd(0x1017_30f4, 0x7)) goto l_0x1017_30f4; /* jnz 0x101730f4 */
            ii(0x1017_30ed, 5); mov(eax, 0x10);                         /* mov eax, 0x10 */
            ii(0x1017_30f2, 2); jmpd(0x1017_3101, 0xd); goto l_0x1017_3101; /* jmp 0x10173101 */
        l_0x1017_30f4:
            ii(0x1017_30f4, 3); cmp(ebx, 0x4);                          /* cmp ebx, 0x4 */
            ii(0x1017_30f7, 2); if(jzd(0x1017_30fc, 0x3)) goto l_0x1017_30fc; /* jz 0x101730fc */
            ii(0x1017_30f9, 3); cmp(ebx, 0x3);                          /* cmp ebx, 0x3 */
        l_0x1017_30fc:
            ii(0x1017_30fc, 5); mov(eax, 0x1e);                         /* mov eax, 0x1e */
        l_0x1017_3101:
            ii(0x1017_3101, 3); mov(edx, memd_a32[ss, esp]);            /* mov edx, [esp] */
            ii(0x1017_3104, 2); mov(dl, memb_a32[ds, edx]);             /* mov dl, [edx] */
            ii(0x1017_3106, 6); and(edx, 0xff);                         /* and edx, 0xff */
            ii(0x1017_310c, 6); mov(memd_a32[ds, 0x1020_9540], ebx);    /* mov [0x10209540], ebx */
            ii(0x1017_3112, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1017_3114, 6); if(jzd(0x1017_3314, 0x1fa)) goto l_0x1017_3314; /* jz 0x10173314 */
            ii(0x1017_311a, 3); mov(eax, memd_a32[ss, esp]);            /* mov eax, [esp] */
            ii(0x1017_311d, 2); mov(dh, memb_a32[ds, eax]);             /* mov dh, [eax] */
            ii(0x1017_311f, 3); cmp(dh, 0x30);                          /* cmp dh, 0x30 */
            ii(0x1017_3122, 6); if(jzd(0x1017_3314, 0x1ec)) goto l_0x1017_3314; /* jz 0x10173314 */
            ii(0x1017_3128, 3); cmp(dh, 0x2e);                          /* cmp dh, 0x2e */
            ii(0x1017_312b, 6); if(jzd(0x1017_3314, 0x1e3)) goto l_0x1017_3314; /* jz 0x10173314 */
            ii(0x1017_3131, 3); cmp(dh, 0x20);                          /* cmp dh, 0x20 */
            ii(0x1017_3134, 6); if(jzd(0x1017_3314, 0x1da)) goto l_0x1017_3314; /* jz 0x10173314 */
            ii(0x1017_313a, 3); cmp(dh, 0x12);                          /* cmp dh, 0x12 */
            ii(0x1017_313d, 6); if(jzd(0x1017_3314, 0x1d1)) goto l_0x1017_3314; /* jz 0x10173314 */
            ii(0x1017_3143, 3); cmp(dh, 0x21);                          /* cmp dh, 0x21 */
            ii(0x1017_3146, 6); if(jzd(0x1017_3314, 0x1c8)) goto l_0x1017_3314; /* jz 0x10173314 */
            ii(0x1017_314c, 3); cmp(dh, 0x22);                          /* cmp dh, 0x22 */
            ii(0x1017_314f, 6); if(jzd(0x1017_3314, 0x1bf)) goto l_0x1017_3314; /* jz 0x10173314 */
            ii(0x1017_3155, 3); cmp(dh, 0x23);                          /* cmp dh, 0x23 */
            ii(0x1017_3158, 6); if(jzd(0x1017_3314, 0x1b6)) goto l_0x1017_3314; /* jz 0x10173314 */
            ii(0x1017_315e, 3); cmp(dh, 0x17);                          /* cmp dh, 0x17 */
            ii(0x1017_3161, 6); if(jzd(0x1017_3314, 0x1ad)) goto l_0x1017_3314; /* jz 0x10173314 */
            ii(0x1017_3167, 3); cmp(dh, 0x24);                          /* cmp dh, 0x24 */
            ii(0x1017_316a, 6); if(jzd(0x1017_3314, 0x1a4)) goto l_0x1017_3314; /* jz 0x10173314 */
            ii(0x1017_3170, 3); cmp(dh, 0x25);                          /* cmp dh, 0x25 */
            ii(0x1017_3173, 6); if(jzd(0x1017_3314, 0x19b)) goto l_0x1017_3314; /* jz 0x10173314 */
            ii(0x1017_3179, 3); cmp(dh, 0x26);                          /* cmp dh, 0x26 */
            ii(0x1017_317c, 6); if(jzd(0x1017_3314, 0x192)) goto l_0x1017_3314; /* jz 0x10173314 */
            ii(0x1017_3182, 2); test(ebx, ebx);                         /* test ebx, ebx */
            ii(0x1017_3184, 2); if(jzd(0x1017_319a, 0x14)) goto l_0x1017_319a; /* jz 0x1017319a */
            ii(0x1017_3186, 3); cmp(ebx, 0x1);                          /* cmp ebx, 0x1 */
            ii(0x1017_3189, 2); if(jnzd(0x1017_3192, 0x7)) goto l_0x1017_3192; /* jnz 0x10173192 */
            ii(0x1017_318b, 5); mov(eax, 0x27);                         /* mov eax, 0x27 */
            ii(0x1017_3190, 2); jmpd(0x1017_319f, 0xd); goto l_0x1017_319f; /* jmp 0x1017319f */
        l_0x1017_3192:
            ii(0x1017_3192, 3); cmp(ebx, 0x4);                          /* cmp ebx, 0x4 */
            ii(0x1017_3195, 2); if(jzd(0x1017_319a, 0x3)) goto l_0x1017_319a; /* jz 0x1017319a */
            ii(0x1017_3197, 3); cmp(ebx, 0x3);                          /* cmp ebx, 0x3 */
        l_0x1017_319a:
            ii(0x1017_319a, 5); mov(eax, 0x32);                         /* mov eax, 0x32 */
        l_0x1017_319f:
            ii(0x1017_319f, 3); mov(edx, memd_a32[ss, esp]);            /* mov edx, [esp] */
            ii(0x1017_31a2, 2); mov(dl, memb_a32[ds, edx]);             /* mov dl, [edx] */
            ii(0x1017_31a4, 6); and(edx, 0xff);                         /* and edx, 0xff */
            ii(0x1017_31aa, 6); mov(memd_a32[ds, 0x1020_9540], ebx);    /* mov [0x10209540], ebx */
            ii(0x1017_31b0, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1017_31b2, 6); if(jzd(0x1017_3314, 0x15c)) goto l_0x1017_3314; /* jz 0x10173314 */
            ii(0x1017_31b8, 3); mov(eax, memd_a32[ss, esp]);            /* mov eax, [esp] */
            ii(0x1017_31bb, 2); mov(dl, memb_a32[ds, eax]);             /* mov dl, [eax] */
            ii(0x1017_31bd, 3); cmp(dl, 0x31);                          /* cmp dl, 0x31 */
            ii(0x1017_31c0, 6); if(jzd(0x1017_3314, 0x14e)) goto l_0x1017_3314; /* jz 0x10173314 */
            ii(0x1017_31c6, 3); cmp(dl, 0x18);                          /* cmp dl, 0x18 */
            ii(0x1017_31c9, 6); if(jzd(0x1017_3314, 0x145)) goto l_0x1017_3314; /* jz 0x10173314 */
            ii(0x1017_31cf, 3); cmp(dl, 0x19);                          /* cmp dl, 0x19 */
            ii(0x1017_31d2, 6); if(jzd(0x1017_3314, 0x13c)) goto l_0x1017_3314; /* jz 0x10173314 */
            ii(0x1017_31d8, 2); test(ebx, ebx);                         /* test ebx, ebx */
            ii(0x1017_31da, 2); if(jzd(0x1017_31f0, 0x14)) goto l_0x1017_31f0; /* jz 0x101731f0 */
            ii(0x1017_31dc, 3); cmp(ebx, 0x1);                          /* cmp ebx, 0x1 */
            ii(0x1017_31df, 2); if(jnzd(0x1017_31e8, 0x7)) goto l_0x1017_31e8; /* jnz 0x101731e8 */
            ii(0x1017_31e1, 5); mov(eax, 0x1e);                         /* mov eax, 0x1e */
            ii(0x1017_31e6, 2); jmpd(0x1017_31f5, 0xd); goto l_0x1017_31f5; /* jmp 0x101731f5 */
        l_0x1017_31e8:
            ii(0x1017_31e8, 3); cmp(ebx, 0x4);                          /* cmp ebx, 0x4 */
            ii(0x1017_31eb, 2); if(jzd(0x1017_31f0, 0x3)) goto l_0x1017_31f0; /* jz 0x101731f0 */
            ii(0x1017_31ed, 3); cmp(ebx, 0x3);                          /* cmp ebx, 0x3 */
        l_0x1017_31f0:
            ii(0x1017_31f0, 5); mov(eax, 0x10);                         /* mov eax, 0x10 */
        l_0x1017_31f5:
            ii(0x1017_31f5, 3); mov(edx, memd_a32[ss, esp]);            /* mov edx, [esp] */
            ii(0x1017_31f8, 2); mov(dl, memb_a32[ds, edx]);             /* mov dl, [edx] */
            ii(0x1017_31fa, 6); and(edx, 0xff);                         /* and edx, 0xff */
            ii(0x1017_3200, 6); mov(memd_a32[ds, 0x1020_9540], ebx);    /* mov [0x10209540], ebx */
            ii(0x1017_3206, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1017_3208, 6); if(jzd(0x1017_3314, 0x106)) goto l_0x1017_3314; /* jz 0x10173314 */
            ii(0x1017_320e, 3); mov(eax, memd_a32[ss, esp]);            /* mov eax, [esp] */
            ii(0x1017_3211, 2); mov(ch, memb_a32[ds, eax]);             /* mov ch, [eax] */
            ii(0x1017_3213, 3); cmp(ch, 0x13);                          /* cmp ch, 0x13 */
            ii(0x1017_3216, 6); if(jzd(0x1017_3314, 0xf8)) goto l_0x1017_3314; /* jz 0x10173314 */
            ii(0x1017_321c, 3); cmp(ch, 0x1f);                          /* cmp ch, 0x1f */
            ii(0x1017_321f, 6); if(jzd(0x1017_3314, 0xef)) goto l_0x1017_3314; /* jz 0x10173314 */
            ii(0x1017_3225, 3); cmp(ch, 0x14);                          /* cmp ch, 0x14 */
            ii(0x1017_3228, 6); if(jzd(0x1017_3314, 0xe6)) goto l_0x1017_3314; /* jz 0x10173314 */
            ii(0x1017_322e, 3); cmp(ch, 0x16);                          /* cmp ch, 0x16 */
            ii(0x1017_3231, 6); if(jzd(0x1017_3314, 0xdd)) goto l_0x1017_3314; /* jz 0x10173314 */
            ii(0x1017_3237, 3); cmp(ch, 0x2f);                          /* cmp ch, 0x2f */
            ii(0x1017_323a, 6); if(jzd(0x1017_3314, 0xd4)) goto l_0x1017_3314; /* jz 0x10173314 */
            ii(0x1017_3240, 2); test(ebx, ebx);                         /* test ebx, ebx */
            ii(0x1017_3242, 2); if(jzd(0x1017_3258, 0x14)) goto l_0x1017_3258; /* jz 0x10173258 */
            ii(0x1017_3244, 3); cmp(ebx, 0x1);                          /* cmp ebx, 0x1 */
            ii(0x1017_3247, 2); if(jnzd(0x1017_3250, 0x7)) goto l_0x1017_3250; /* jnz 0x10173250 */
            ii(0x1017_3249, 5); mov(eax, 0x2c);                         /* mov eax, 0x2c */
            ii(0x1017_324e, 2); jmpd(0x1017_325d, 0xd); goto l_0x1017_325d; /* jmp 0x1017325d */
        l_0x1017_3250:
            ii(0x1017_3250, 3); cmp(ebx, 0x4);                          /* cmp ebx, 0x4 */
            ii(0x1017_3253, 2); if(jzd(0x1017_3258, 0x3)) goto l_0x1017_3258; /* jz 0x10173258 */
            ii(0x1017_3255, 3); cmp(ebx, 0x3);                          /* cmp ebx, 0x3 */
        l_0x1017_3258:
            ii(0x1017_3258, 5); mov(eax, 0x11);                         /* mov eax, 0x11 */
        l_0x1017_325d:
            ii(0x1017_325d, 3); mov(edx, memd_a32[ss, esp]);            /* mov edx, [esp] */
            ii(0x1017_3260, 2); mov(dl, memb_a32[ds, edx]);             /* mov dl, [edx] */
            ii(0x1017_3262, 6); and(edx, 0xff);                         /* and edx, 0xff */
            ii(0x1017_3268, 6); mov(memd_a32[ds, 0x1020_9540], ebx);    /* mov [0x10209540], ebx */
            ii(0x1017_326e, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1017_3270, 6); if(jzd(0x1017_3314, 0x9e)) goto l_0x1017_3314; /* jz 0x10173314 */
            ii(0x1017_3276, 3); mov(eax, memd_a32[ss, esp]);            /* mov eax, [esp] */
            ii(0x1017_3279, 3); cmp(memb_a32[ds, eax], 0x2d);           /* cmp byte [eax], 0x2d */
            ii(0x1017_327c, 6); if(jzd(0x1017_3314, 0x92)) goto l_0x1017_3314; /* jz 0x10173314 */
            ii(0x1017_3282, 2); test(ebx, ebx);                         /* test ebx, ebx */
            ii(0x1017_3284, 2); if(jnzd(0x1017_328d, 0x7)) goto l_0x1017_328d; /* jnz 0x1017328d */
            ii(0x1017_3286, 5); mov(eax, 0x15);                         /* mov eax, 0x15 */
            ii(0x1017_328b, 2); jmpd(0x1017_32b6, 0x29); goto l_0x1017_32b6; /* jmp 0x101732b6 */
        l_0x1017_328d:
            ii(0x1017_328d, 3); cmp(ebx, 0x1);                          /* cmp ebx, 0x1 */
            ii(0x1017_3290, 2); if(jnzd(0x1017_3299, 0x7)) goto l_0x1017_3299; /* jnz 0x10173299 */
            ii(0x1017_3292, 5); mov(eax, 0x15);                         /* mov eax, 0x15 */
            ii(0x1017_3297, 2); jmpd(0x1017_32b6, 0x1d); goto l_0x1017_32b6; /* jmp 0x101732b6 */
        l_0x1017_3299:
            ii(0x1017_3299, 3); cmp(ebx, 0x4);                          /* cmp ebx, 0x4 */
            ii(0x1017_329c, 2); if(jnzd(0x1017_32a5, 0x7)) goto l_0x1017_32a5; /* jnz 0x101732a5 */
            ii(0x1017_329e, 5); mov(eax, 0x15);                         /* mov eax, 0x15 */
            ii(0x1017_32a3, 2); jmpd(0x1017_32b6, 0x11); goto l_0x1017_32b6; /* jmp 0x101732b6 */
        l_0x1017_32a5:
            ii(0x1017_32a5, 3); cmp(ebx, 0x3);                          /* cmp ebx, 0x3 */
            ii(0x1017_32a8, 2); if(jnzd(0x1017_32b1, 0x7)) goto l_0x1017_32b1; /* jnz 0x101732b1 */
            ii(0x1017_32aa, 5); mov(eax, 0x15);                         /* mov eax, 0x15 */
            ii(0x1017_32af, 2); jmpd(0x1017_32b6, 0x5); goto l_0x1017_32b6; /* jmp 0x101732b6 */
        l_0x1017_32b1:
            ii(0x1017_32b1, 5); mov(eax, 0x2c);                         /* mov eax, 0x2c */
        l_0x1017_32b6:
            ii(0x1017_32b6, 3); mov(edx, memd_a32[ss, esp]);            /* mov edx, [esp] */
            ii(0x1017_32b9, 2); mov(dl, memb_a32[ds, edx]);             /* mov dl, [edx] */
            ii(0x1017_32bb, 6); and(edx, 0xff);                         /* and edx, 0xff */
            ii(0x1017_32c1, 6); mov(memd_a32[ds, 0x1020_9540], ebx);    /* mov [0x10209540], ebx */
            ii(0x1017_32c7, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1017_32c9, 2); if(jzd(0x1017_3314, 0x49)) goto l_0x1017_3314; /* jz 0x10173314 */
            ii(0x1017_32cb, 2); test(ebx, ebx);                         /* test ebx, ebx */
            ii(0x1017_32cd, 2); if(jnzd(0x1017_32d6, 0x7)) goto l_0x1017_32d6; /* jnz 0x101732d6 */
            ii(0x1017_32cf, 5); mov(eax, 0x2c);                         /* mov eax, 0x2c */
            ii(0x1017_32d4, 2); jmpd(0x1017_32ff, 0x29); goto l_0x1017_32ff; /* jmp 0x101732ff */
        l_0x1017_32d6:
            ii(0x1017_32d6, 3); cmp(ebx, 0x1);                          /* cmp ebx, 0x1 */
            ii(0x1017_32d9, 2); if(jnzd(0x1017_32e2, 0x7)) goto l_0x1017_32e2; /* jnz 0x101732e2 */
            ii(0x1017_32db, 5); mov(eax, 0x11);                         /* mov eax, 0x11 */
            ii(0x1017_32e0, 2); jmpd(0x1017_32ff, 0x1d); goto l_0x1017_32ff; /* jmp 0x101732ff */
        l_0x1017_32e2:
            ii(0x1017_32e2, 3); cmp(ebx, 0x4);                          /* cmp ebx, 0x4 */
            ii(0x1017_32e5, 2); if(jnzd(0x1017_32ee, 0x7)) goto l_0x1017_32ee; /* jnz 0x101732ee */
            ii(0x1017_32e7, 5); mov(eax, 0x2c);                         /* mov eax, 0x2c */
            ii(0x1017_32ec, 2); jmpd(0x1017_32ff, 0x11); goto l_0x1017_32ff; /* jmp 0x101732ff */
        l_0x1017_32ee:
            ii(0x1017_32ee, 3); cmp(ebx, 0x3);                          /* cmp ebx, 0x3 */
            ii(0x1017_32f1, 2); if(jnzd(0x1017_32fa, 0x7)) goto l_0x1017_32fa; /* jnz 0x101732fa */
            ii(0x1017_32f3, 5); mov(eax, 0x2c);                         /* mov eax, 0x2c */
            ii(0x1017_32f8, 2); jmpd(0x1017_32ff, 0x5); goto l_0x1017_32ff; /* jmp 0x101732ff */
        l_0x1017_32fa:
            ii(0x1017_32fa, 5); mov(eax, 0x15);                         /* mov eax, 0x15 */
        l_0x1017_32ff:
            ii(0x1017_32ff, 3); mov(edx, memd_a32[ss, esp]);            /* mov edx, [esp] */
            ii(0x1017_3302, 2); mov(dl, memb_a32[ds, edx]);             /* mov dl, [edx] */
            ii(0x1017_3304, 6); and(edx, 0xff);                         /* and edx, 0xff */
            ii(0x1017_330a, 6); mov(memd_a32[ds, 0x1020_9540], ebx);    /* mov [0x10209540], ebx */
            ii(0x1017_3310, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1017_3312, 2); if(jnzd(0x1017_3337, 0x23)) goto l_0x1017_3337; /* jnz 0x10173337 */
        l_0x1017_3314:
            ii(0x1017_3314, 3); mov(eax, memd_a32[ss, esp]);            /* mov eax, [esp] */
            ii(0x1017_3317, 3); mov(dh, memb_a32[ds, eax + 0x2]);       /* mov dh, [eax+0x2] */
            ii(0x1017_331a, 6); mov(ebx, memd_a32[ds, 0x1020_9540]);    /* mov ebx, [0x10209540] */
            ii(0x1017_3320, 3); test(dh, 0x18);                         /* test dh, 0x18 */
            ii(0x1017_3323, 2); if(jnzd(0x1017_332f, 0xa)) goto l_0x1017_332f; /* jnz 0x1017332f */
            ii(0x1017_3325, 2); mov(ch, dh);                            /* mov ch, dh */
            ii(0x1017_3327, 3); or(ch, 0x8);                            /* or ch, 0x8 */
            ii(0x1017_332a, 3); mov(memb_a32[ds, eax + 0x2], ch);       /* mov [eax+0x2], ch */
            ii(0x1017_332d, 2); jmpd(0x1017_3337, 0x8); goto l_0x1017_3337; /* jmp 0x10173337 */
        l_0x1017_332f:
            ii(0x1017_332f, 2); mov(cl, dh);                            /* mov cl, dh */
            ii(0x1017_3331, 3); and(cl, 0xe7);                          /* and cl, 0xe7 */
            ii(0x1017_3334, 3); mov(memb_a32[ds, eax + 0x2], cl);       /* mov [eax+0x2], cl */
        l_0x1017_3337:
            ii(0x1017_3337, 5); calld(/* sys */ 0x1017_4880, 0x1544);   /* call 0x10174880 */
            ii(0x1017_333c, 6); mov(ebx, memd_a32[ds, 0x1020_9540]);    /* mov ebx, [0x10209540] */
            ii(0x1017_3342, 3); add(esp, 0x4);                          /* add esp, 0x4 */
            ii(0x1017_3345, 1); popd(edx);                              /* pop edx */
            ii(0x1017_3346, 1); popd(ecx);                              /* pop ecx */
            ii(0x1017_3347, 1); popd(ebx);                              /* pop ebx */
            ii(0x1017_3348, 1); retd(); return;                         /* ret */
        l_0x1017_3349:
            ii(0x1017_3349, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1017_334e, 6); mov(ebx, memd_a32[ds, 0x1020_9540]);    /* mov ebx, [0x10209540] */
            ii(0x1017_3354, 3); add(esp, 0x4);                          /* add esp, 0x4 */
            ii(0x1017_3357, 1); popd(edx);                              /* pop edx */
            ii(0x1017_3358, 1); popd(ecx);                              /* pop ecx */
            ii(0x1017_3359, 1); popd(ebx);                              /* pop ebx */
            ii(0x1017_335a, 1); retd(); return;                         /* ret */
        }
    }
}
