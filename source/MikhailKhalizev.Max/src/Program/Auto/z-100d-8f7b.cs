using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_8f7b-25b92dc5")]
        public void Method_100d_8f7b()
        {
            ii(0x100d_8f7b, 5); push(0x44);                             /* push 0x44 */
            ii(0x100d_8f80, 5); call(Definitions.sys_check_available_stack_size, 0x8_cdcd); /* call 0x10165d52 */
            ii(0x100d_8f85, 1); push(ecx);                              /* push ecx */
            ii(0x100d_8f86, 1); push(esi);                              /* push esi */
            ii(0x100d_8f87, 1); push(edi);                              /* push edi */
            ii(0x100d_8f88, 1); push(ebp);                              /* push ebp */
            ii(0x100d_8f89, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_8f8b, 6); sub(esp, 0x30);                         /* sub esp, 0x30 */
            ii(0x100d_8f91, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100d_8f94, 3); mov(memd[ss, ebp - 8], edx);            /* mov [ebp-0x8], edx */
            ii(0x100d_8f97, 3); mov(memd[ss, ebp - 4], ebx);            /* mov [ebp-0x4], ebx */
            ii(0x100d_8f9a, 4); movsx(edx, memw[ss, ebp - 4]);          /* movsx edx, word [ebp-0x4] */
            ii(0x100d_8f9e, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100d_8fa1, 5); call(0x100d_67d8, -0x27ce);             /* call 0x100d67d8 */
            ii(0x100d_8fa6, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100d_8fa9, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x100d_8fac, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x100d_8faf, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_8fb2, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x100d_8fb5, 4); mov(memw[ds, edx + 0x4b], ax);          /* mov [edx+0x4b], ax */
            ii(0x100d_8fb9, 5); mov(ebx, 0x101b_38d0);                  /* mov ebx, 0x101b38d0 */
            ii(0x100d_8fbe, 5); mov(edx, 0x5d);                         /* mov edx, 0x5d */
            ii(0x100d_8fc3, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100d_8fc6, 3); add(eax, 0x5b);                         /* add eax, 0x5b */
            ii(0x100d_8fc9, 5); call(Definitions.sys_call_ctor_arr_v2, 0x8_cfa2); /* call 0x10165f70 */
            ii(0x100d_8fce, 3); sub(eax, 0x5b);                         /* sub eax, 0x5b */
            ii(0x100d_8fd1, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100d_8fd4, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x100d_8fd7, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x100d_8fda, 5); mov(ebx, 0x101b_38d0);                  /* mov ebx, 0x101b38d0 */
            ii(0x100d_8fdf, 5); mov(edx, 0x5d);                         /* mov edx, 0x5d */
            ii(0x100d_8fe4, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100d_8fe7, 5); add(eax, 0x1cf);                        /* add eax, 0x1cf */
            ii(0x100d_8fec, 5); call(Definitions.sys_call_ctor_arr_v2, 0x8_cf7f); /* call 0x10165f70 */
            ii(0x100d_8ff1, 5); sub(eax, 0x1cf);                        /* sub eax, 0x1cf */
            ii(0x100d_8ff6, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100d_8ff9, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x100d_8ffc, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100d_8fff, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100d_9002, 7); mov(memd[ds, eax + 0x13], 0x101b_5f50); /* mov dword [eax+0x13], 0x101b5f50 */
            ii(0x100d_9009, 7); mov(memd[ss, ebp - 0x10], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x100d_9010, 2); jmp(0x100d_9018, 6); goto l_0x100d_9018; /* jmp 0x100d9018 */
        l_0x100d_9012:
            ii(0x100d_9012, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100d_9015, 3); inc(memd[ss, ebp - 0x10]);              /* inc dword [ebp-0x10] */
        l_0x100d_9018:
            ii(0x100d_9018, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x100d_901c, 3); cmp(eax, 0xa);                          /* cmp eax, 0xa */
            ii(0x100d_901f, 2); if(jge(0x100d_9037, 0x16)) goto l_0x100d_9037; /* jge 0x100d9037 */
            ii(0x100d_9021, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x100d_9025, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x100d_9028, 3); add(eax, memd[ss, ebp - 0xc]);          /* add eax, [ebp-0xc] */
            ii(0x100d_902b, 10); mov(memd[ds, eax + 0x375], 0);         /* mov dword [eax+0x375], 0x0 */
            ii(0x100d_9035, 2); jmp(0x100d_9012, -0x25); goto l_0x100d_9012; /* jmp 0x100d9012 */
        l_0x100d_9037:
            ii(0x100d_9037, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100d_903a, 6); mov(memw[ds, eax + 0x51], 0);           /* mov word [eax+0x51], 0x0 */
            ii(0x100d_9040, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100d_9043, 10); mov(memd[ds, eax + 0x39f], 0);         /* mov dword [eax+0x39f], 0x0 */
            ii(0x100d_904d, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100d_9050, 10); mov(memd[ds, eax + 0x3a3], 0);         /* mov dword [eax+0x3a3], 0x0 */
            ii(0x100d_905a, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100d_905d, 10); mov(memd[ds, eax + 0x3a7], 0);         /* mov dword [eax+0x3a7], 0x0 */
            ii(0x100d_9067, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100d_906a, 10); mov(memd[ds, eax + 0x3ab], 0);         /* mov dword [eax+0x3ab], 0x0 */
            ii(0x100d_9074, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100d_9077, 10); mov(memd[ds, eax + 0x349], 0);         /* mov dword [eax+0x349], 0x0 */
            ii(0x100d_9081, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100d_9084, 10); mov(memd[ds, eax + 0x34d], 0);         /* mov dword [eax+0x34d], 0x0 */
            ii(0x100d_908e, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100d_9091, 10); mov(memd[ds, eax + 0x351], 0);         /* mov dword [eax+0x351], 0x0 */
            ii(0x100d_909b, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100d_909e, 10); mov(memd[ds, eax + 0x355], 0);         /* mov dword [eax+0x355], 0x0 */
            ii(0x100d_90a8, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100d_90ab, 10); mov(memd[ds, eax + 0x359], 0);         /* mov dword [eax+0x359], 0x0 */
            ii(0x100d_90b5, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100d_90b8, 10); mov(memd[ds, eax + 0x35d], 0);         /* mov dword [eax+0x35d], 0x0 */
            ii(0x100d_90c2, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100d_90c5, 10); mov(memd[ds, eax + 0x361], 0);         /* mov dword [eax+0x361], 0x0 */
            ii(0x100d_90cf, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100d_90d2, 10); mov(memd[ds, eax + 0x365], 0);         /* mov dword [eax+0x365], 0x0 */
            ii(0x100d_90dc, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100d_90df, 10); mov(memd[ds, eax + 0x369], 0);         /* mov dword [eax+0x369], 0x0 */
            ii(0x100d_90e9, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100d_90ec, 10); mov(memd[ds, eax + 0x36d], 0);         /* mov dword [eax+0x36d], 0x0 */
            ii(0x100d_90f6, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100d_90f9, 10); mov(memd[ds, eax + 0x371], 0);         /* mov dword [eax+0x371], 0x0 */
            ii(0x100d_9103, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100d_9106, 10); mov(memd[ds, eax + 0x345], 0);         /* mov dword [eax+0x345], 0x0 */
            ii(0x100d_9110, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100d_9113, 6); mov(memw[ds, eax + 0x4d], 0);           /* mov word [eax+0x4d], 0x0 */
            ii(0x100d_9119, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100d_911c, 6); mov(memw[ds, eax + 0x4f], 0);           /* mov word [eax+0x4f], 0x0 */
            ii(0x100d_9122, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100d_9125, 6); mov(memw[ds, eax + 0x59], 0xffff);      /* mov word [eax+0x59], 0xffff */
            ii(0x100d_912b, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100d_912e, 7); mov(memb[ds, eax + 0x39e], 0);          /* mov byte [eax+0x39e], 0x0 */
            ii(0x100d_9135, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100d_9138, 6); mov(memw[ds, eax + 0x55], 0x270);       /* mov word [eax+0x55], 0x270 */
            ii(0x100d_913e, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100d_9141, 6); mov(memw[ds, eax + 0x57], 0x271);       /* mov word [eax+0x57], 0x271 */
            ii(0x100d_9147, 7); mov(memd[ss, ebp - 0x10], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x100d_914e, 2); jmp(0x100d_9156, 6); goto l_0x100d_9156; /* jmp 0x100d9156 */
        l_0x100d_9150:
            ii(0x100d_9150, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100d_9153, 3); inc(memd[ss, ebp - 0x10]);              /* inc dword [ebp-0x10] */
        l_0x100d_9156:
            ii(0x100d_9156, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x100d_915a, 3); cmp(eax, 0x5d);                         /* cmp eax, 0x5d */
            ii(0x100d_915d, 6); if(jge(0x100d_91fc, 0x99)) goto l_0x100d_91fc; /* jge 0x100d91fc */
            ii(0x100d_9163, 4); movsx(edx, memw[ss, ebp - 0x10]);       /* movsx edx, word [ebp-0x10] */
            ii(0x100d_9167, 4); movsx(ebx, memw[ss, ebp - 8]);          /* movsx ebx, word [ebp-0x8] */
            ii(0x100d_916b, 6); imul(ebx, ebx, 0x247);                  /* imul ebx, ebx, 0x247 */
            ii(0x100d_9171, 5); mov(eax, 0x101c_a468);                  /* mov eax, 0x101ca468 */
            ii(0x100d_9176, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100d_9178, 5); call(0x100d_fd2c, 0x6baf);              /* call 0x100dfd2c */
            ii(0x100d_917d, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100d_917f, 4); movsx(ebx, memw[ss, ebp - 0x10]);       /* movsx ebx, word [ebp-0x10] */
            ii(0x100d_9183, 3); shl(ebx, 2);                            /* shl ebx, 0x2 */
            ii(0x100d_9186, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100d_9189, 3); add(eax, 0x5b);                         /* add eax, 0x5b */
            ii(0x100d_918c, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100d_918e, 5); call(0x100c_b77c, -0xda17);             /* call 0x100cb77c */
            ii(0x100d_9193, 5); mov(eax, 0x24);                         /* mov eax, 0x24 */
            ii(0x100d_9198, 5); call(Definitions.sys_new, 0x8_cc63);    /* call 0x10165e00 */
            ii(0x100d_919d, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x100d_91a0, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x100d_91a3, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
            ii(0x100d_91a6, 4); cmp(memd[ss, ebp - 0x24], 0);           /* cmp dword [ebp-0x24], 0x0 */
            ii(0x100d_91aa, 2); if(jz(0x100d_91d7, 0x2b)) goto l_0x100d_91d7; /* jz 0x100d91d7 */
            ii(0x100d_91ac, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x100d_91b0, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x100d_91b3, 3); mov(ebx, memd[ss, ebp - 0xc]);          /* mov ebx, [ebp-0xc] */
            ii(0x100d_91b6, 3); add(ebx, 0x5b);                         /* add ebx, 0x5b */
            ii(0x100d_91b9, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100d_91bb, 5); call(0x100c_b6f0, -0xdad0);             /* call 0x100cb6f0 */
            ii(0x100d_91c0, 3); mov(ebx, memd[ss, ebp - 0x20]);         /* mov ebx, [ebp-0x20] */
            ii(0x100d_91c3, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100d_91c5, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100d_91c7, 5); call(0x100c_a2f8, -0xeed4);             /* call 0x100ca2f8 */
            ii(0x100d_91cc, 3); mov(memd[ss, ebp - 0x28], eax);         /* mov [ebp-0x28], eax */
            ii(0x100d_91cf, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x100d_91d2, 3); mov(memd[ss, ebp - 0x2c], eax);         /* mov [ebp-0x2c], eax */
            ii(0x100d_91d5, 2); jmp(0x100d_91dd, 6); goto l_0x100d_91dd; /* jmp 0x100d91dd */
        l_0x100d_91d7:
            ii(0x100d_91d7, 3); mov(eax, memd[ss, ebp - 0x24]);         /* mov eax, [ebp-0x24] */
            ii(0x100d_91da, 3); mov(memd[ss, ebp - 0x2c], eax);         /* mov [ebp-0x2c], eax */
        l_0x100d_91dd:
            ii(0x100d_91dd, 3); mov(edx, memd[ss, ebp - 0x2c]);         /* mov edx, [ebp-0x2c] */
            ii(0x100d_91e0, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x100d_91e4, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x100d_91e7, 3); mov(ebx, memd[ss, ebp - 0xc]);          /* mov ebx, [ebp-0xc] */
            ii(0x100d_91ea, 6); add(ebx, 0x1cf);                        /* add ebx, 0x1cf */
            ii(0x100d_91f0, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100d_91f2, 5); call(0x100c_b77c, -0xda7b);             /* call 0x100cb77c */
            ii(0x100d_91f7, 5); jmp(0x100d_9150, -0xac); goto l_0x100d_9150; /* jmp 0x100d9150 */
        l_0x100d_91fc:
            ii(0x100d_91fc, 3); mov(esi, memd[ss, ebp - 0xc]);          /* mov esi, [ebp-0xc] */
            ii(0x100d_91ff, 7); mov(memb[ds, esi + 0x343], 0);          /* mov byte [esi+0x343], 0x0 */
            ii(0x100d_9206, 3); mov(esi, memd[ss, ebp - 0xc]);          /* mov esi, [ebp-0xc] */
            ii(0x100d_9209, 7); mov(memb[ds, esi + 0x39d], 0);          /* mov byte [esi+0x39d], 0x0 */
            ii(0x100d_9210, 3); mov(esi, memd[ss, ebp - 0xc]);          /* mov esi, [ebp-0xc] */
            ii(0x100d_9213, 7); mov(memb[ds, esi + 0x344], 0);          /* mov byte [esi+0x344], 0x0 */
            ii(0x100d_921a, 5); mov(eax, 1);                            /* mov eax, 0x1 */
            ii(0x100d_921f, 5); call(0x1012_0d94, 0x4_7b70);            /* call 0x10120d94 */
            ii(0x100d_9224, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x100d_9229, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100d_922c, 5); call(0x100d_6adf, -0x2752);             /* call 0x100d6adf */
            ii(0x100d_9231, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x100d_9234, 3); add(edx, 0x17);                         /* add edx, 0x17 */
            ii(0x100d_9237, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100d_923a, 5); call(0x100d_6a11, -0x282e);             /* call 0x100d6a11 */
            ii(0x100d_923f, 5); mov(ecx, 6);                            /* mov ecx, 0x6 */
            ii(0x100d_9244, 3); mov(edi, memd[ss, ebp - 0xc]);          /* mov edi, [ebp-0xc] */
            ii(0x100d_9247, 3); lea(edi, memd[ds, edi + 0x31]);         /* lea edi, [edi+0x31] */
            ii(0x100d_924a, 3); mov(esi, memd[ss, ebp - 0xc]);          /* mov esi, [ebp-0xc] */
            ii(0x100d_924d, 3); lea(esi, memd[ds, esi + 0x17]);         /* lea esi, [esi+0x17] */
            ii(0x100d_9250, 2); rep(() => movsd());                     /* rep movsd */
            ii(0x100d_9252, 2); movsw();                                /* movsw */
            ii(0x100d_9254, 5); call(0x100f_fc13, 0x2_69ba);            /* call 0x100ffc13 */
            ii(0x100d_9259, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100d_925c, 3); mov(memd[ss, ebp - 0x30], eax);         /* mov [ebp-0x30], eax */
            ii(0x100d_925f, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x100d_9262, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_9264, 1); pop(ebp);                               /* pop ebp */
            ii(0x100d_9265, 1); pop(edi);                               /* pop edi */
            ii(0x100d_9266, 1); pop(esi);                               /* pop esi */
            ii(0x100d_9267, 1); pop(ecx);                               /* pop ecx */
            ii(0x100d_9268, 1); ret();                                  /* ret */
        }
    }
}
