FUNC_BEGIN(/* sys */ 0x10165eee, 0xbf8671b551b0779c, 0x20, ({0x53, 0x51, 0x89, 0xd3, 0x8b, 0x10, 0x8d, 0x4a, 0x1, 0x89, 0x8, 0x88, 0x1a, 0xff, 0x40, 0x10, 0x59, 0x5b, 0xc3}))
    II(0x10165eee, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10165eef, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10165ef0, 0x2)   mov(ebx, edx);                        /* mov ebx, edx */
    II(0x10165ef2, 0x2)   mov(edx, memd_a32(ds, eax));          /* mov edx, [eax] */
    II(0x10165ef4, 0x3)   lea(ecx, edx + 0x1);                  /* lea ecx, [edx+0x1] */
    II(0x10165ef7, 0x2)   mov(memd_a32(ds, eax), ecx);          /* mov [eax], ecx */
    II(0x10165ef9, 0x2)   mov(memb_a32(ds, edx), bl);           /* mov [edx], bl */
    II(0x10165efb, 0x3)   inc(memd_a32(ds, eax + 0x10));        /* inc dword [eax+0x10] */
    II(0x10165efe, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10165eff, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10165f00, 0x1)   retd();                               /* ret */
FUNC_END

